using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Reflection;
using NationalInstruments.Composition;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Shell;
using NationalInstruments.Core;
using NationalInstruments.Design;
using NationalInstruments.DataTypes;
using NationalInstruments.Shell;
using LabVIEW.gRPC;
using System.Threading;
using System.IO;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// The view model which controls how changes on the view are propagated to the model.
    /// This ViewModel extends directly from VisualViewModel which is the base view model for all PF control view models
    /// This class implementes IControlContextMenuHelper which gives it the ability to provide custom right click menus
    /// </summary>
    public class StringControlViewModel : VisualViewModel
    {
        //// Load assembly from subdirectory.
        //static string directory = Thread.GetDomain().BaseDirectory;
        //static string dllPath = Path.Combine(directory, "labview-grpc-assembly", "lvgrpc.dll");
        //Assembly lvgrpc = Assembly.LoadFrom(dllPath);
        //Assembly lvgrpc = Assembly.Load("lvgrpc, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null");

        private readonly StringControlModel _model;
        /// <summary>
        /// Constructs a new instance of the StringControlViewModel class
        /// </summary>
        /// <param name="model">The StringControlModel associated with this view model.</param>
        public StringControlViewModel(StringControlModel model)
            : base(model)
        {
            _model = model;
            // Subscribe to the change event of Model
            _model.PropertyChanged += OnModelChanged;
        }

        private string _data = "";
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private double _wait = 5;
        private string _addr = "localhost:50051";
        private string _cert = "";

        private string _chnName = "";
        public string ChnName
        {
            get { return _chnName; }
            set { _chnName = value; OnViewModelChanged(ChnName, nameof(ChnName)); }
        }

        ulong gRPCId = 0;
        RequestData requestData = new RequestData();
        ResponseData responseData = new ResponseData();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        /// Handle the event from model
        private void OnModelChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Connect":
                    if (_model.Connect == true)
                    {
                        try
                        {
                            VeriStandgrpc_client.CreateClient(_addr, _cert, out gRPCId);
                        }
                        catch (Exception e1)
                        {
                            _status = getErrReason(e1);
                            NotifyPropertyChanged(nameof(Status));
                        }

                        // Try to create the session again if first time failed
                        if (gRPCId == 0)
                        {
                            Task.Delay(500);
                            try
                            {
                                VeriStandgrpc_client.CreateClient(_addr, _cert, out gRPCId);
                            }
                            catch (Exception e1)
                            {
                                _status = getErrReason(e1);
                                NotifyPropertyChanged(nameof(Status));
                            }
                        }

                        dispatcherTimer.Tick += new EventHandler(DataTimer_Tick);
                        dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1000 / _wait);
                        dispatcherTimer.Start();
                    }
                    else
                    {
                        try
                        {
                            VeriStandgrpc_client.DestroyClient(gRPCId);
                            gRPCId = 0;
                        }
                        catch (Exception e2)
                        {
                            _status = getErrReason(e2);
                            NotifyPropertyChanged(nameof(Status));
                        }

                        dispatcherTimer.Stop();
                        dispatcherTimer.Tick -= DataTimer_Tick;
                    }
                    break;
                default:
                    break;
            }
        }
        
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            if (gRPCId != 0)
            {
                requestData.channel = _chnName;
                requestData.data = _data;
                try
                {
                    VeriStandgrpc_client.GrpcWrite(gRPCId, requestData, out responseData, 100, 0);
                    if (responseData.status == "OK")
                        _status = "";
                    else
                        _status = responseData.status;
                }
                catch (Exception e3)
                {
                    _status = getErrReason(e3);
                }
            }
            NotifyPropertyChanged(nameof(Status));
        }

        private string getErrReason(Exception error)
        {
            string errTxt;
            errTxt = error.Message.Substring(error.Message.IndexOf("<ERR>") + 6);
            // Get the text of possible reason 
            return errTxt;
        }

        /// <summary>
        /// Creates the view associated with this view model by initializing a new instance of our custom control class StringControl
        /// This is an opportunity to provide callbacks to the view and to hook up event handlers.  In this case we add a value changed event handler so we can
        /// react when the view changes value.
        /// </summary>
        /// <returns>Stringcontrol view</returns>
        public override object CreateView()
        {
            var view = new StringControl(this);
            WeakEventManager<StringControl, CustomChannelValueChangedEventArgs>.AddHandler(view, "ViewValueChanged", SetViewModelValue);
            return view;
        }

        /// <summary>
        /// Called by the view when a value change occurs.  
        /// </summary>
        /// <param name="sender">sending object - not used</param>
        /// <param name="eventArgs">custom event information telling us which channel changed and what its value is</param>
        private void SetViewModelValue(object sender, CustomChannelValueChangedEventArgs eventArgs)
        {
            switch (eventArgs.ChannelName)
            {
                case "stringValue":
                    _data = eventArgs.ChannelValue as string; break;
                default:
                    break;
            }           
        }

        /// <summary>
        /// Event that is fired when the value on the control changes
        /// </summary>
        public event EventHandler<CustomChannelValueChangedEventArgs> ValueChanged;

        /// <summary>
        /// Raises the ChannelValueChanged event. Invoked when the channel value changes.
        /// </summary>
        /// <param name="channelValue">New channel value</param>
        /// <param name="channelName">Name of the channel that changed</param>
        protected virtual void OnViewModelChanged(string channelValue, string channelName)
        {
            var channelValueChangedSubscribers = ValueChanged;
            if (channelValueChangedSubscribers != null)
            {
                channelValueChangedSubscribers(this, new CustomChannelValueChangedEventArgs(channelValue, channelName));
            }
        }

        #region ConfigurationPane
        /// <summary>
        ///  Creates configuration pane content for this control. See comments on
        ///  <see cref="IProvideCommandContent"/> for more information about correct usage of this function.
        /// </summary>
        /// <param name="context">The current display context</param>
        public override void CreateCommandContent(ICommandPresentationContext context)
        {
            base.CreateCommandContent(context);
            // specify that we are adding things to the configuration pane
            using (context.AddConfigurationPaneContent())
            {
                // First add the group command which lets us know what top level configuration pane group to put the child commands in
                using (context.AddGroup(ConfigurationPaneCommands.BehaviorGroupCommand))
                {
                    // add child commands whose visuals will show up in the specified parent group.
                    context.Add(waitConfig, new NumericTextBoxFactory(NITypes.Double));
                    context.Add(addrConfig, TextBoxFactory.ForConfigurationPane);
                    var filters = new FileDialogFilterCollection();
                    filters.Add(new FileDialogFilter() { Extensions = new[] { "crt" }, Label = "Certificate File" });
                    context.Add(certConfig, new PathSelectorFactory() { Filters = filters });
                    context.Add(chnConfig, TextBoxFactory.ForConfigurationPane);
                }
            }
        }

        /// A numeric command
        public static readonly ICommandEx waitConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = "Rate (Hz)",
            UniqueId = "NI.ConfigCommands:Wait",
        };

        /// <summary>
        /// A string command shown as a textbox
        /// UIType can be used for some standard types, for all others, see examples where a VisualFactory is included.
        /// when adding the command to the ICommandPresentationContext.
        /// </summary>
        public static readonly ICommandEx addrConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = "Address",
            UniqueId = "NI.ConfigCommands:Addr",
            UIType = UITypeForCommand.TextBox,
        };

        public static readonly ICommandEx certConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = "Certificate Path",
            UniqueId = "NI.ConfigCommands:CertPath",
        };

        public static readonly ICommandEx chnConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = "Channel Name",
            UniqueId = "NI.ConfigCommands:Server",
            UIType = UITypeForCommand.TextBox,
        };

        /// <summary>
        /// A generic CanExecute handler.
        /// The role of this handler is to take the current state in the model and transfer it to the parameter,
        /// which is used by the view to display the current value.
        /// In general, you would likely write a different one for each command that did the appropriate
        /// cast of the parameter to get/set the value.
        /// </summary>
        /// <param name="parameter">command parameter - this is where the current 'value' should be held</param>
        /// <param name="selection">user selection, for commands based on selection</param>
        /// <param name="host">composition host</param>
        /// <param name="site">for communicating with user interface APIs</param>
        /// <returns>true if it can handle</returns>
        private static bool HandleCanExecuteCommand(ICommandParameter parameter, IEnumerable<IViewModel> selection, ICompositionHost host, DocumentEditSite site)
        {
            var viewModel = selection.OfType<ElementViewModel>().First() as StringControlViewModel;
            var booleanParameter = parameter as ICheckableCommandParameter;
            var numericParameter = parameter as IValueCommandParameter;
            var textParameter = parameter as ITextCommandParameter;

            if (booleanParameter != null)
            {
                booleanParameter.IsChecked = true;
            }
            else if (textParameter != null)
            {
                switch (parameter.LabelTitle)
                {
                    case "Address":
                        textParameter.Text = viewModel._addr; break;
                    case "Certificate Path":
                        textParameter.Text = viewModel._cert; break;
                    case "Channel Name":
                        textParameter.Text = viewModel._chnName; break;
                    default:
                        break;
                }
            }
            else if (numericParameter != null)
            {
                numericParameter.Value = viewModel._wait;
            }
            return true; // or false to disable the command
        }

        /// <summary>
        /// Here we handle the user changing the given command.
        /// Our job is to take the current value in the parameter and update our model
        /// </summary>
        /// <param name="parameter">command parameter - this is where the current 'value' should be held</param>
        /// <param name="selection">user selection, for commands based on selection</param>
        /// <param name="host">composition host</param>
        /// <param name="site">for communicating with user interface APIs</param>
        private static void HandleExecuteCommand(ICommandParameter parameter, IEnumerable<IViewModel> selection, ICompositionHost host, DocumentEditSite site)
        {
            var viewModel = selection.OfType<ElementViewModel>().First() as StringControlViewModel;
            var booleanParameter = parameter as ICheckableCommandParameter;
            var numericParameter = parameter as IValueCommandParameter;
            var textParameter = parameter as ITextCommandParameter;

            if (booleanParameter != null)
            {
                booleanParameter.IsChecked = true;
            }
            else if (textParameter != null)
            {
                if (parameter.LabelTitle == "Address")
                    viewModel._addr = textParameter.Text;
                else if (parameter.LabelTitle == "Certificate Path")
                    viewModel._cert = textParameter.Text;
                else if (parameter.LabelTitle == "Channel Name")
                    viewModel._chnName = textParameter.Text;
            }
            else if (numericParameter != null)
            {
                viewModel._wait = Convert.ToDouble(numericParameter.Value);
            }
        }
        #endregion
    }
}

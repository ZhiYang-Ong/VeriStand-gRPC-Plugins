using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Linq;
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
using NationalInstruments.SourceModel;
using LabVIEW.gRPC;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// The view model which controls how changes on the view are propagated to the model.
    /// This ViewModel extends directly from VisualViewModel which is the base view model for all PF control view models
    /// This class implementes IControlContextMenuHelper which gives it the ability to provide custom right click menus
    /// </summary>
    public class StringIndicatorViewModel : VisualViewModel
    {
        //// Load assembly from subdirectory.
        //static string directory = Thread.GetDomain().BaseDirectory;
        //static string dllPath = Path.Combine(directory, "labview-grpc-assembly", "lvgrpc.dll");
        //Assembly lvgrpc = Assembly.LoadFrom(dllPath);
        //Assembly lvgrpc = Assembly.Load("lvgrpc, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null");

        private static IViewModel selectedViewModel;
        private readonly StringIndicatorModel _model;
        /// <summary>
        /// Constructs a new instance of the StringIndicatorViewModel class
        /// </summary>
        /// <param name="model">The StringIndicatorModel associated with this view model.</param>
        public StringIndicatorViewModel(StringIndicatorModel model)
            : base(model)
        {
            selectedViewModel = this;

            _model = model;
            // Subscribe to the change event of Model
            _model.PropertyChanged += OnModelPropertyChanged;
        }

        private StringIndicator _view;
        /// <summary>
        /// Creates the view associated with this view model by initializing a new instance of our custom control class StringIndicator
        /// This is an opportunity to provide callbacks to the view and to hook up event handlers.  In this case we add a value changed event handler so we can
        /// react when the view changes value.
        /// </summary>
        /// <returns>StringIndicator view</returns>
        public override object CreateView()
        {
            var view = new StringIndicator(this);
            _view = view;

            // Subscribe to the change event of view
            view.PropertyChanged += OnViewPropertyChanged;
            return view;
        }

        /// <summary>
        ///  De-register event on dispose.
        /// </summary>
        public override void DisposeView()
        {
            _view.PropertyChanged -= OnViewPropertyChanged;
            _model.PropertyChanged -= OnModelPropertyChanged;
        }

        #region UserDefinedLogic
        // DispatcherTimer doesn't work in model hence we implement the user logic in view model.

        public string Data { get; set; }
        public string Status { get; set; }

        ulong gRPCId = 0;
        RequestData requestData = new RequestData();
        ResponseData responseData = new ResponseData();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private void StartGrpc()
        {
            try
            {
                VeriStandgrpc_client.CreateClient(_model.Addr, _model.Cert, out gRPCId);
            }
            catch (Exception e1)
            {
                Status = getErrReason(e1);
                NotifyPropertyChanged(nameof(Status));
            }

            // Try to create the session again if first time failed
            if (gRPCId == 0)
            {
                Task.Delay(500);
                try
                {
                    VeriStandgrpc_client.CreateClient(_model.Addr, _model.Cert, out gRPCId);
                }
                catch (Exception e1)
                {
                    Status = getErrReason(e1);
                    NotifyPropertyChanged(nameof(Status));
                }
            }

            dispatcherTimer.Tick += new EventHandler(DataTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1000 / _model.Rate);
            dispatcherTimer.Start();
        }

        private void StopGrpc()
        {
            try
            {
                VeriStandgrpc_client.DestroyClient(gRPCId);
                gRPCId = 0;
            }
            catch (Exception e2)
            {
                Status = getErrReason(e2);
                NotifyPropertyChanged(nameof(Status));
            }

            dispatcherTimer.Stop();
            dispatcherTimer.Tick -= DataTimer_Tick;
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            if (gRPCId != 0)
            {
                requestData.channel = _model.Channel;
                try
                {
                    VeriStandgrpc_client.GrpcRead(gRPCId, requestData, out responseData, 100, 0);
                    if (responseData.status == "OK")
                    {
                        Data = responseData.data;
                        Status = string.Empty;
                    }
                    else
                    {
                        Data = string.Empty;
                        Status = responseData.status;
                    }
                }
                catch (Exception e3)
                {
                    Data = string.Empty;
                    Status = getErrReason(e3);
                }
            }
            NotifyPropertyChanged(nameof(Data));
            NotifyPropertyChanged(nameof(Status));
        }

        private string getErrReason(Exception error)
        {
            string errTxt;
            errTxt = error.Message.Substring(error.Message.IndexOf("<ERR>") + 6);
            // Get the text of possible reason 
            return errTxt;
        }
        #endregion

        #region Events
        ///// <summary>
        ///// Called by the view when a value change occurs.
        ///// </summary>
        ///// <param name="sender">sending object - not used</param>
        ///// <param name="eventArgs">custom event information telling us which channel changed and what its value is</param>
        private void OnViewPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                default:
                    break;
            }
        }

        /// <summary>
        /// Process the notification from model.
        /// </summary>
        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Connect":
                    if (_model.Connect == true)
                        StartGrpc();
                    else
                        StopGrpc();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region ConfigurationPane
        public const string RatePropName = "Rate (Hz)";
        public const string AddressPropName = "Address";
        public const string CertPropName = "Certificate Path";
        public const string StringChannelName = "Channel Name";

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
            LabelTitle = RatePropName,
            UniqueId = "NI.ConfigCommands:Wait",
        };

        /// <summary>
        /// A string command shown as a textbox
        /// UIType can be used for some standard types, for all others, see examples where a VisualFactory is included.
        /// when adding the command to the ICommandPresentationContext.
        /// </summary>
        public static readonly ICommandEx addrConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = AddressPropName,
            UniqueId = "NI.ConfigCommands:Addr",
            UIType = UITypeForCommand.TextBox,
        };

        public static readonly ICommandEx certConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = CertPropName,
            UniqueId = "NI.ConfigCommands:CertPath",
        };

        public static readonly ICommandEx chnConfig = new ShellSelectionRelayCommand(HandleExecuteCommand, HandleCanExecuteCommand)
        {
            LabelTitle = StringChannelName,
            UniqueId = "NI.ConfigCommands:ChnName",
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
            var viewModel = selection.OfType<ElementViewModel>().First() as StringIndicatorViewModel;
            var _model = viewModel._model;
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
                    case AddressPropName:
                        textParameter.Text = _model.Addr; break;
                    case CertPropName:
                        textParameter.Text = _model.Cert; break;
                    case StringChannelName:
                        textParameter.Text = _model.Channel; break;
                    default:
                        break;
                }
            }
            else if (numericParameter != null)
            {
                switch (parameter.LabelTitle)
                {
                    case RatePropName:
                        numericParameter.Value = _model.Rate; break;
                    default:
                        break;
                }
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
            var viewModel = selection.OfType<ElementViewModel>().First() as StringIndicatorViewModel;
            var _model = viewModel._model;
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
                    case AddressPropName:
                        UpdateSerializedProperty(AddressPropName, textParameter.Text); break;
                    case CertPropName:
                        UpdateSerializedProperty(CertPropName, textParameter.Text); break;
                    case StringChannelName:
                        UpdateSerializedProperty(StringChannelName, textParameter.Text); break;
                    default:
                        break;
                }
            }
            else if (numericParameter != null)
            {
                switch (parameter.LabelTitle)
                {
                    case RatePropName:
                        UpdateSerializedProperty(RatePropName, numericParameter.Value); break;
                    default:
                        break;
                }
            }
        }

        private static void UpdateSerializedProperty(string channelName, object channelValue)
        {
            var uiModel = (UIModel)selectedViewModel.Model;
            // we are setting values on the model so start a new transaction. set the purpose of the transaction to user so that it can be undone
            using (var transaction = uiModel.TransactionManager.BeginTransaction("Set channel", TransactionPurpose.User))
            {
                var _uiModel = uiModel as StringIndicatorModel;
                if (_uiModel != null)
                {
                    switch (channelName)
                    {
                        case RatePropName:
                            _uiModel.Rate = (double)channelValue;
                            //_uiModel.NotifyModelChanged("MiddleName");
                            break;
                        case AddressPropName:
                            _uiModel.Addr = (string)channelValue;
                            break;
                        case CertPropName:
                            _uiModel.Cert = (string)channelValue;
                            break;
                        case StringChannelName:
                            _uiModel.Channel = (string)channelValue;
                            break;
                        default:
                            break;
                    }
                    transaction.Commit();
                }
            }
        }
        #endregion
    }
}

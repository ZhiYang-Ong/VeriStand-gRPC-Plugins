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
using System.Runtime.CompilerServices;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// The view model which controls how changes on the view are propagated to the model.
    /// This ViewModel extends directly from VisualViewModel which is the base view model for all PF control view models
    /// This class implementes IControlContextMenuHelper which gives it the ability to provide custom right click menus
    /// </summary>
    public class MergeStringViewModel : VisualViewModel
    {
        private readonly MergeStringModel _model;
        /// <summary>
        /// Constructs a new instance of the MergeStringViewModel class
        /// </summary>
        /// <param name="model">The MergeStringModel associated with this view model.</param>
        public MergeStringViewModel(MergeStringModel model)
            : base(model)
        {
            _model = model;
            //// Subscribe to the change event of Model
            _model.PropertyChanged += OnModelPropertyChanged;
        }

        private MergeString _view;
        /// Creates the view associated with this view model by initializing a new instance of our custom control class MergeString
        /// This is an opportunity to provide callbacks to the view and to hook up event handlers.  In this case we add a value changed event handler so we can
        /// react when the view changes value.
        /// </summary>
        /// <returns>MergeString view</returns>
        public override object CreateView()
        {
            var view = new MergeString(this);
            _view = view;
            //WeakEventManager<MergeString, CustomChannelValueChangedEventArgs>.AddHandler(view, "ViewValueChanged", SetViewModelValue);

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

        //DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; private set; }
        

        #region EventHandler
        ///// <summary>
        ///// Called by the view when a value change occurs.
        ///// </summary>
        ///// <param name="sender">sending object - not used</param>
        ///// <param name="eventArgs">custom event information telling us which channel changed and what its value is</param>
        private void OnViewPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "FirstName":   // Forward the view value change to model
                    _model.FirstName = FirstName;
                    _model.NotifyModelChanged(nameof(FirstName)); break;
                case "LastName":   // Forward the view value value to model
                    _model.LastName = LastName;
                    _model.NotifyModelChanged(nameof(LastName)); break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Process the notification from model.
        /// </summary>
        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "FullName":    // Forward the model value change to view
                    FullName = _model.FullName;
                    NotifyPropertyChanged(nameof(FullName)); break;
                default:
                    break;
            }
        }
        #endregion

        #region ConfigurationPane
        private string _chnName = "";
        public string ChnName
        {
            get { return _chnName; }
            set
            {
                _chnName = value;
                //OnViewModelChanged(ChnName, nameof(ChnName));
            }
        }

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
                    //var filters = new FileDialogFilterCollection();
                    //filters.Add(new FileDialogFilter() { Extensions = new[] { "crt" }, Label = "Certificate File" });
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
            var viewModel = selection.OfType<ElementViewModel>().First() as MergeStringViewModel;
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
                    case "Channel Name":
                        textParameter.Text = viewModel._chnName; break;
                    default:
                        break;
                }
            }
            //else if (numericParameter != null)
            //{
            //    numericParameter.Value = viewModel._wait;
            //}
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
            var viewModel = selection.OfType<ElementViewModel>().First() as MergeStringViewModel;
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
                    case "Channel Name":
                        viewModel._chnName = textParameter.Text; break;
                    default:
                        break;
                }
            }
            //else if (numericParameter != null)
            //{
            //    viewModel._wait = Convert.ToDouble(numericParameter.Value);
            //}
        }
        #endregion
    }
}

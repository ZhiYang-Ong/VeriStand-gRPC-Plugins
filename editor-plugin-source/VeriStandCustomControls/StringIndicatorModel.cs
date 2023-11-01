using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Linq;
using NationalInstruments.CBSCommon;
using NationalInstruments.CommonModel;
using NationalInstruments.Core;
using NationalInstruments.DynamicProperties;
using NationalInstruments.Hmi.Core.Controls.Models;
using NationalInstruments.Hmi.Core.Services;
using NationalInstruments.SourceModel;
using NationalInstruments.SourceModel.Persistence;
using NationalInstruments.VeriStand.ServiceModel;
using NationalInstruments.VeriStand.SourceModel;
using NationalInstruments.VeriStand.SourceModel.Screen;
using NationalInstruments.VeriStand.SystemStorage;
using static NationalInstruments.Core.ExceptionHelper;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    #region PaletteDefinition
    /// <summary>
    /// This class is an implementation of ICustomVeriStandControl. By specifying it as an Export, we are identifying
    /// it as a plugin to VeriStand.
    /// The interface implementation defines how the control should appear in the palette.
    /// </summary>
    [Export(typeof(ICustomVeriStandControl))]
        public class StringIndicatorModelExporter : ICustomVeriStandControl
    {
        /// <summary>
        /// MergeScript which defines what to drop on the screen from the palette.  Can be used to set default values on the control
        /// </summary>
        public string Target =>
            "<pf:MergeScript xmlns:pf=\"http://www.ni.com/PlatformFramework\">" +
                "<pf:MergeItem>" +
                    "<StringIndicator xmlns=\"https://github.com/ZhiYang-Ong/VeriStandPlugins\" Width=\"[float]105\" Height=\"[float]50\"/>" +
                "</pf:MergeItem>" +
            "</pf:MergeScript>";

        /// <summary>
        /// Name of the control as it will appear in the palette
        /// </summary>
        public string Name => "String Indicator";

        /// <summary>
        /// Path to the image to use in the palette
        /// </summary>
        public string TopImagePath => "/NationalInstruments.VeriStand.GrpcPlugins;component/Resources/gRPC_top.png";
        public string ImagePath => "/NationalInstruments.VeriStand.GrpcPlugins;component/Resources/gRPC_Indtr.png";

        /// <summary>
        /// Tool tip to display in the palette
        /// </summary>
        public string ToolTip => "A string control.";

        /// <summary>
        /// Unique id for the control. The only requirement is that this doesn't overlap with existing controls or other custom controls.
        /// This is used for serialization and the context help system.
        /// </summary>
        public string UniqueId => "StringIndicator";

        /// <summary>
        /// If a folder hierarchy is desired it can be returned here.  If multiple controls should show up in the same subfolder either use the same PaletteElementCategory object in their
        /// hierarchy list or use a category with the same unique id.  Unique IDs cannot be duplicated at different hierarchy levels.
        /// </summary>
        public IList<PaletteElementCategory> PaletteHierarchy =>
            new List<PaletteElementCategory>() { new PaletteElementCategory("gRPC Plugins", TopImagePath, "grpc", .1) };
    }
    #endregion

    /// <summary>
    /// Model class which defines the business logic for the String Control.
    /// </summary>
    public class StringIndicatorModel : VisualModel, INotifyPropertyChanged,
#if MUTATE2020R4
        IDataEngineStateChangeObserver
#else
        ISubscribeProviderStatusUpdates
#endif
    {
        #region BasicLogic
        /// <summary>
        /// The name to use for serialization of this model.  This name must match the name used in the Target xml in the ICustomVeriStandControl interface
        /// </summary>
        private const string StringTextName = "StringIndicator";

        /// <summary>
        /// String used to put errors from this control in their own bucket so code from this model doesn't interfere with the rest of the error
        /// reporting behavior in VeriStand
        /// </summary>
        private const string StringIndicatorModelErrorString = "StringIndicatorModelErrors";

        /// <summary>
        /// Specifies the name of the String channel
        /// </summary>
        public const string StringChannelName = "StringChannel";

        /// <summary>
        /// Specifies the PropertySymbol for the first registered channel.  Any custom attribute that needs to serialized so that it is saved needs to be a property symbol.
        /// </summary>
        public static readonly PropertySymbol StringChannelSymbol =
            ExposePropertySymbol<StringIndicatorModel>(StringChannelName, string.Empty);

        /// <summary>
        /// Provide a xaml generation helper. This is used to help generate xaml for the properties on this control.
        /// </summary>
        public override XamlGenerationHelper XamlGenerationHelper
        {
            get { return new StringIndicatorXamlHelper(); }
        }

        /// <summary>
        /// Gets the type of the specified property.  This must be implemented for any new properties that get added that need to be serialized.
        /// </summary>
        /// <param name="identifier">The property to get the type of.</param>
        /// <returns>The exact runtime type of the specified property.</returns>
        public override Type GetPropertyType(PropertySymbol identifier)
        {
            switch (identifier.Name)
            {
                case StringChannelName:
                    return typeof(string);
                default:
                    return base.GetPropertyType(identifier);
            }
        }

        /// <summary>
        /// Gets the default value of the specified property.  This must be implemented for any new properties that get added that need to be serialized.
        /// </summary>
        /// <param name="identifier">The property to get the default value of.</param>
        /// <returns>The default value of the specified property.</returns>
        public override object DefaultValue(PropertySymbol identifier)
        {
            switch (identifier.Name)
            {
                case StringChannelName:
                    return string.Empty;
                default:
                    return base.DefaultValue(identifier);
            }
        }

        /// <summary>
        /// XML element name, including full namespace, for universal persistence.
        /// </summary>
        public override XName XmlElementName
        {
            get { return XName.Get(StringTextName, PluginNamespaceSchema.ParsableNamespaceName); }
        }

        /// <summary>
        /// Factory method for creating a new StringIndicatorModel
        /// </summary>
        /// <param name="info">Information required to create the model, such as the parser.</param>
        /// <returns>A constructed and initialized StringIndicatorModel instance.</returns>
        [XmlParserFactoryMethod(StringTextName, PluginNamespaceSchema.ParsableNamespaceName)]
        public static StringIndicatorModel Create(IElementCreateInfo info)
        {
            var model = new StringIndicatorModel();
#if MUTATE2020
            model.Initialize(info);
#else
            model.Init(info);
#endif
            return model;
        }

        /// <summary>
        /// Private class which helps with xaml generation for this model.  For most custom models this should just need to override the control type from the generic XamlGenerationHelper
        /// </summary>
        private class StringIndicatorXamlHelper : XamlGenerationHelper
        {
            public override Type ControlType => typeof(StringIndicator);
        }
        #endregion

        #region VeriStandGateway
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        /// <summary>
        ///   Called when VeriStand connects to the gateway. This control should register for the channel value change
        /// events it is interested in when this happens.
        /// </summary>
        /// <returns>Task which can be awaited</returns>
        private bool _connect = false;
        public bool Connect
        {
            get { return _connect; }
            set { _connect = value; OnPropertyChanged(nameof(Connect)); }
        }

        public async Task OnConnectedAsync()
        {
            // use Host.BeginInvoke to clear error messages when connecting to the gateway.  The error message collection must be interacted with by the UI thread
            // which is why we must use BeginInvoke since OnConnectToGateway is not guaranteed to be called by the UI thread
            Host.BeginInvoke(AsyncTaskPriority.WorkerHigh, () =>
                {
                    MessageScope?.AllMessages.ClearMessageByCategoryAndReportingElement(StringIndicatorModelErrorString, this);
                });

            _connect = true;
            OnPropertyChanged(nameof(Connect));
            await Task.Delay(100);
        }

        private void ReportErrorToModel(Exception ex)
        {
            // Clear any existing errors and then report a new error message.  Use Host.BeginInvoke here since this must occur on the UI thread
            Host.BeginInvoke(AsyncTaskPriority.WorkerHigh, () =>
            {
                MessageScope?.AllMessages.ClearMessageByCategoryAndReportingElement(
                    StringIndicatorModelErrorString,
                    this);
//#if MUTATE2021
//                this.SafeReportError(StringIndicatorModelErrorString, null, MessageDescriptor.Empty, ex);
//#else
                this.ReportError(StringIndicatorModelErrorString, null, MessageDescriptor.Empty, ex);
//#endif
            });
        }

        /// <summary>
        /// Called when VeriStand is connecting to the gateway.
        /// </summary>
        /// <returns>awaitable task</returns>
        public Task OnConnectingAsync()
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Called when VeriStand is disconnecting from the VeriStand gateway or the control is removed from the application.
        /// The control should unregister from channel value change events when this happens.
        /// </summary>
        /// <returns>Task which can be awaited</returns>
        public async Task OnDisconnectingAsync()
        {
            // use Host.BeginInvoke to clear error messages when connecting to the gateway.  The error message collection must be interacted with by the UI thread
            // which is why we must use BeginInvoke since OnConnectToGateway is not guaranteed to be called by the UI thread
            Host.BeginInvoke(
                AsyncTaskPriority.WorkerHigh,
                () =>
                    MessageScope?.AllMessages.ClearMessageByCategoryAndReportingElement(
                        StringIndicatorModelErrorString,
                        this));

            _connect = false;
            OnPropertyChanged(nameof(Connect));
            await Task.Delay(100);            
        }

        /// <summary>
        /// Called when VeriStand becomes disconnected from the gateway.
        /// </summary>
        /// <returns>awaitable task</returns>
        public Task OnDisconnectedAsync()
        {
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task OnStartAsync()
        {
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task OnShutdownAsync()
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}

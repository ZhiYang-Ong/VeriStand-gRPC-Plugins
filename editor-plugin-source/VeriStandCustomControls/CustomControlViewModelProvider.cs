using System.ComponentModel.Composition;
using NationalInstruments.Composition;
using NationalInstruments.Shell;
using NationalInstruments.VeriStand.Design.Screen;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// Exports the view models (and associated models) supported by the ScreenSurface.
    /// </summary>
    [PartMetadata(ExportIdentifier.RootContainerKey, "")]
    [ExportProvideViewModels(typeof(ScreenEditControl), supportedModels: "NationalInstruments.VeriStand.GrpcPlugins")]
    public class CustomControlViewModelProvider : ViewModelProvider
    {
        /// <inheritdoc />
        /// <remarks>
        /// This method should use AddSupportedModel to specify the relationship between all models and view models exported
        /// from this assembly.
        /// </remarks>
        protected override void AddSupportedModels()
        {
            AddSupportedModel<StringControlModel>(e => new StringControlViewModel(e));
            AddSupportedModel<StringIndicatorModel>(e => new StringIndicatorViewModel(e));
        }
    }
}

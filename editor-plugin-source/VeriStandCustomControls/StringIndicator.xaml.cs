using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// Interaction logic for StringIndicator.xaml
    /// </summary>
    public partial class StringIndicator : INotifyPropertyChanged
    {
        private readonly StringIndicatorViewModel _viewModel;
        /// <summary>
        /// Constructor for StringIndicator
        /// </summary>
        /// <param name="viewModel">view model associated with this control</param>
        public StringIndicator(StringIndicatorViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;

            // Subscribe to the change event of ViewModel
            _viewModel.PropertyChanged += OnViewModelChanged;
        }

        /// Forward the change event to View
        private void OnViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Data")
                OnPropertyChanged(nameof(stringValue));
            else if (e.PropertyName == "Status")
                OnPropertyChanged(nameof(Status));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string stringValue
        {
            get { return _viewModel.Data; }
            set {
                _viewModel.Data = value;
                OnPropertyChanged(nameof(stringValue));
            }
        }

        public string Status
        {
            get { return _viewModel.Status; }
            set
            {
                _viewModel.Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
    }
}

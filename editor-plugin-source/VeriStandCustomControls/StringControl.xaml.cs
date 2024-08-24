using System;
using System.Windows;
using System.Windows.Input;
using NationalInstruments.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// Interaction logic for StringControl.xaml
    /// </summary>
    public partial class StringControl : INotifyPropertyChanged
    {
        private readonly StringControlViewModel _viewModel;
        /// <summary>
        /// Constructor for StringControl
        /// </summary>
        /// <param name="viewModel">view model associated with this control</param>
        public StringControl(StringControlViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;

            // Subscribe to the change event of ViewModel
            _viewModel.PropertyChanged += OnViewModelChanged;
        }

        public string Data
        {
            get { return _viewModel.Data; }
            set { _viewModel.Data = value; OnPropertyChanged(nameof(Data));}
        }

        public string Status
        {
            get { return _viewModel.Status; }
            set { _viewModel.Status = value; OnPropertyChanged(nameof(Status));}
        }

        #region Events 
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Event that is fired when the view value changes, using INotifyPropertyChanged
        /// </summary>
        /// <param name="name">String representing the property name</param>
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        ///// <summary>
        ///// Event that is fired when the value on the view model changes
        ///// </summary>
        private void OnViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    OnPropertyChanged(nameof(Status)); break;
                case "FontSize":
                    DataControl.FontSize = _viewModel.FontSize;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

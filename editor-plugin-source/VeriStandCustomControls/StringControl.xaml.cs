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

        /// Forward the change event to View
        private void OnViewModelChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Status")
                OnPropertyChanged(nameof(Status));
        }

        /// <summary>
        /// Event that is fired to change value on control
        /// </summary>
        /// <param name="name">String representing the property name</param>
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _value;
        public string stringValue
        {
            get { return _value; }
            set
            {
                _value = value;
                OnValueChanged(stringValue, nameof(stringValue));
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

        /// <summary>
        /// Event that is fired when the value on the control changes
        /// </summary>
        public event EventHandler<CustomChannelValueChangedEventArgs> ValueChanged;

        /// <summary>
        /// Raises the ChannelValueChanged event. Invoked when the channel value changes.
        /// </summary>
        /// <param name="channelValue">New channel value</param>
        /// <param name="channelName">Name of the channel that changed</param>
        protected virtual void OnValueChanged(string channelValue, string channelName)
        {
            var channelValueChangedSubscribers = ValueChanged;
            if (channelValueChangedSubscribers != null)
            {
                channelValueChangedSubscribers(this, new CustomChannelValueChangedEventArgs(channelValue, channelName));
            }
        }
    }
}

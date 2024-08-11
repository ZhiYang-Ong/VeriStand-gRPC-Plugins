using System;
using System.Windows;
using System.Windows.Input;
using NationalInstruments.Controls;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// Interaction logic for MergeString.xaml
    /// </summary>
    public partial class MergeString : INotifyPropertyChanged
    {
        private readonly MergeStringViewModel _viewModel;
        /// <summary>
        /// Constructor for MergeString
        /// </summary>
        /// <param name="viewModel">view model associated with this control</param>
        public MergeString(MergeStringViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;

            // Subscribe to the change event of ViewModel
            _viewModel.PropertyChanged += OnViewModelChanged;
        }

        public string FirstName
        {
            get { return _viewModel.FirstName; }
            set
            {
                _viewModel.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _viewModel.LastName; }
            set
            {
                _viewModel.LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string FullName
        {
            get { return _viewModel.FullName; }
            set
            {
                OnPropertyChanged("FullName");
            }
        }

        #region EventHandlers
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
                case "FullName":
                    OnPropertyChanged("FullName"); break;
                default:
                    break;
            }
        }

        ///// <summary>
        ///// Event that is fired when the value on the control changes
        ///// </summary>
        //public event EventHandler<CustomChannelValueChangedEventArgs> ViewChanged;

        ///// <summary>
        ///// Routes the view channel event to view model, using WeakEventManager
        ///// </summary>
        ///// <param name="channelValue">New channel value</param>
        ///// <param name="channelName">Name of the channel that changed</param>
        //protected virtual void OnViewChanged(double channelValue, string channelName)
        //{
        //    var channelValueChangedSubscribers = ViewChanged;
        //    if (channelValueChangedSubscribers != null)
        //    {
        //        channelValueChangedSubscribers(this, new CustomChannelValueChangedEventArgs(channelValue, channelName));
        //    }
        //}
        #endregion
    }
}

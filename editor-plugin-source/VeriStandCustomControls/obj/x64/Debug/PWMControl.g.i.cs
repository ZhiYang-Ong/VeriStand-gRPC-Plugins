﻿#pragma checksum "..\..\..\PWMControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05FB94BD535B89FA7EA753FA12700981DE53E760"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NationalInstruments.Controls;
using NationalInstruments.VeriStand.GrpcPlugins;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NationalInstruments.VeriStand.GrpcPlugins {
    
    
    /// <summary>
    /// PulseWidthModulationControl
    /// </summary>
    public partial class PulseWidthModulationControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.Controls.NumericTextBoxDouble FrequencyTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.Controls.NumericTextBoxDouble DutyCycleTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.Controls.SliderDouble DutyCycleSlider;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NormalRadioButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FaultToGroundRadioButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PWMControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FaultToHighButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NationalInstruments.VeriStand.GrpcPlugins;component/pwmcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PWMControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FrequencyTextBox = ((NationalInstruments.Controls.NumericTextBoxDouble)(target));
            
            #line 25 "..\..\..\PWMControl.xaml"
            this.FrequencyTextBox.ValueChanged += new System.EventHandler<NationalInstruments.Controls.ValueChangedEventArgs<double>>(this.FrequencyTextBox_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DutyCycleTextBox = ((NationalInstruments.Controls.NumericTextBoxDouble)(target));
            
            #line 29 "..\..\..\PWMControl.xaml"
            this.DutyCycleTextBox.ValueChanged += new System.EventHandler<NationalInstruments.Controls.ValueChangedEventArgs<double>>(this.DutyCycleTextBox_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DutyCycleSlider = ((NationalInstruments.Controls.SliderDouble)(target));
            
            #line 32 "..\..\..\PWMControl.xaml"
            this.DutyCycleSlider.ValueChanged += new System.EventHandler<NationalInstruments.Controls.ValueChangedEventArgs<double>>(this.DutyCycleSlider_OnValueChanged);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\PWMControl.xaml"
            this.DutyCycleSlider.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.HandlePreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\PWMControl.xaml"
            this.DutyCycleSlider.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.HandlePreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NormalRadioButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\PWMControl.xaml"
            this.NormalRadioButton.Click += new System.Windows.RoutedEventHandler(this.NormalButton_OnClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FaultToGroundRadioButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\PWMControl.xaml"
            this.FaultToGroundRadioButton.Click += new System.Windows.RoutedEventHandler(this.FaultToGroundButton_OnClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FaultToHighButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\PWMControl.xaml"
            this.FaultToHighButton.Click += new System.Windows.RoutedEventHandler(this.FaultToHighButton_OnClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


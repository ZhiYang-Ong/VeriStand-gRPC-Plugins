﻿#pragma checksum "..\..\..\TwoChannelAdorner.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5172AC36B480BF826F90C85318B8E6AA6076AFEA"
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
using NationalInstruments.VeriStand.Shell;
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
    /// TwoChannelAdorner
    /// </summary>
    public partial class TwoChannelAdorner : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 117 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FirstChannelSelect;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.VeriStand.Shell.ChannelPopup FirstUiSdfPopup;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecondChannelSelect;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.VeriStand.Shell.ChannelPopup SecondUiSdfPopup;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.Controls.StringControl FirstTextControl;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\TwoChannelAdorner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NationalInstruments.Controls.StringControl SecondTextControl;
        
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
            System.Uri resourceLocater = new System.Uri("/NationalInstruments.VeriStand.GrpcPlugins;component/twochanneladorner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TwoChannelAdorner.xaml"
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
            this.FirstChannelSelect = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.FirstUiSdfPopup = ((NationalInstruments.VeriStand.Shell.ChannelPopup)(target));
            return;
            case 3:
            this.SecondChannelSelect = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.SecondUiSdfPopup = ((NationalInstruments.VeriStand.Shell.ChannelPopup)(target));
            return;
            case 5:
            this.FirstTextControl = ((NationalInstruments.Controls.StringControl)(target));
            return;
            case 6:
            this.SecondTextControl = ((NationalInstruments.Controls.StringControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


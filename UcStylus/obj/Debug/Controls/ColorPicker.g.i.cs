﻿#pragma checksum "..\..\..\Controls\ColorPicker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC1265AC2A6631D8685348B7A3844D90715B2CC0CD94A3B51639479F2863747B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UcStylus.Controls;


namespace UcStylus.Controls {
    
    
    /// <summary>
    /// ColorPicker
    /// </summary>
    public partial class ColorPicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Controls\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PickerPanel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Controls\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.GradientStop MiddleStop;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SpectrumGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Controls\ColorPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HexCode;
        
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
            System.Uri resourceLocater = new System.Uri("/UcStylus;component/controls/colorpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\ColorPicker.xaml"
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
            this.PickerPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 11 "..\..\..\Controls\ColorPicker.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RgbGradient_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MiddleStop = ((System.Windows.Media.GradientStop)(target));
            return;
            case 4:
            this.SpectrumGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 20 "..\..\..\Controls\ColorPicker.xaml"
            this.SpectrumGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SpectrumGrid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HexCode = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


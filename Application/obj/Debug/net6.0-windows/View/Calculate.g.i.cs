﻿#pragma checksum "..\..\..\..\View\Calculate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B82B307CA86A0160A4947EA322DE42CAE0CECBA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FiltersApplication.Utilities;
using FiltersApplication.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace FiltersApplication.View {
    
    
    /// <summary>
    /// Calculate
    /// </summary>
    public partial class Calculate : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 145 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FuelText;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Start_Btn;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageLoad;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StartCalculate;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridLoad;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimerLabel;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoadText;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderSuccess;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\..\..\View\Calculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridAshClean;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FiltersApplication;component/view/calculate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Calculate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FuelText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Start_Btn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 171 "..\..\..\..\View\Calculate.xaml"
            this.Start_Btn.Click += new System.Windows.RoutedEventHandler(this.Start_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ImageLoad = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.StartCalculate = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.GridLoad = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.TimerLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.LoadText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.BorderSuccess = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.GridAshClean = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


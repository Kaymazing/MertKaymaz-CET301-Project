﻿#pragma checksum "..\..\..\PaymentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41D272EFBB6A1E4F385459001B22C3B2059CF267"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using MertKaymaz_301Project;
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


namespace MertKaymaz_301Project {
    
    
    /// <summary>
    /// PaymentWindow
    /// </summary>
    public partial class PaymentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sparaclar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPayment;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PWtaksitsayi;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PWmethod;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PWtaksit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CWekle;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CWsil;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CWguncelleexpand;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PWbooking;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MertKaymaz-301Project;component/paymentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PaymentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\PaymentWindow.xaml"
            ((MertKaymaz_301Project.PaymentWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\PaymentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CWAnaMenu);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sparaclar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.dgPayment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\..\PaymentWindow.xaml"
            this.dgPayment.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dgPayment_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PWtaksitsayi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PWmethod = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.PWtaksit = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.CWekle = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\PaymentWindow.xaml"
            this.CWekle.Click += new System.Windows.RoutedEventHandler(this.CWekle_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CWsil = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\PaymentWindow.xaml"
            this.CWsil.Click += new System.Windows.RoutedEventHandler(this.CMsil_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CWguncelleexpand = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\PaymentWindow.xaml"
            this.CWguncelleexpand.Click += new System.Windows.RoutedEventHandler(this.CWguncelleexpand_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PWbooking = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


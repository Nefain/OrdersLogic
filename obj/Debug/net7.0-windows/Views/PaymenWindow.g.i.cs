﻿#pragma checksum "..\..\..\..\Views\PaymenWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2781A36A29B6BD1DCA55F5A318D32063665E4543"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OrdersLogic;
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


namespace OrdersLogic {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrderComboBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrderList;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TrancheList;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TrancheComboBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PaymentsList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPayment;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPayment;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\PaymenWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowOrderTranche;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OrdersLogic;V1.0.0.0;component/views/paymenwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PaymenWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrderComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\..\Views\PaymenWindow.xaml"
            this.OrderComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderList = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.TrancheList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.TrancheComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\Views\PaymenWindow.xaml"
            this.TrancheComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TrancheComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PaymentsList = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.AddPayment = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Views\PaymenWindow.xaml"
            this.AddPayment.Click += new System.Windows.RoutedEventHandler(this.AddPayment_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ShowPayment = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Views\PaymenWindow.xaml"
            this.ShowPayment.Click += new System.Windows.RoutedEventHandler(this.ShowPayment_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ShowOrderTranche = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Views\PaymenWindow.xaml"
            this.ShowOrderTranche.Click += new System.Windows.RoutedEventHandler(this.ShowOrderTranche_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Reports\Accounts\TrialBalance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB0767D04E8EC8DDD1C5B3C4A5FE8A4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace WpfClientApp.Reports.Accounts {
    
    
    /// <summary>
    /// TrialBalance
    /// </summary>
    public partial class TrialBalance : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 5 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfClientApp.Reports.Accounts.TrialBalance TrialBalanceWindow;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mComboFinancialYear;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mDataGridBGroup;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonPrint;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mButtonClose;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfClientApp;component/reports/accounts/trialbalance.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
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
            this.TrialBalanceWindow = ((WpfClientApp.Reports.Accounts.TrialBalance)(target));
            return;
            case 2:
            this.mComboFinancialYear = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
            this.mComboFinancialYear.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.mComboFinancialYear_SelectionChanged));
            
            #line default
            #line hidden
            return;
            case 3:
            this.mDataGridBGroup = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
            this.mDataGridBGroup.RowDetailsVisibilityChanged += new System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>(this.mDataGridBGroup_RowDetailsVisibilityChanged);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
            this.mDataGridBGroup.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.mDataGridBGroup_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mButtonPrint = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.mButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
            this.mButtonClose.Click += new System.Windows.RoutedEventHandler(this.mButtonClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 64 "..\..\..\..\Reports\Accounts\TrialBalance.xaml"
            ((System.Windows.Controls.DataGrid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.mDataGridCGroup_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


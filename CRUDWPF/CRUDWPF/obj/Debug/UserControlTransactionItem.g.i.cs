﻿#pragma checksum "..\..\UserControlTransactionItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6A278261D9533D31F26978369B2D99CF3ECF55613A2EF0819102EC05B76219A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CRUDWPF;
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


namespace CRUDWPF {
    
    
    /// <summary>
    /// UserControlTransactionItem
    /// </summary>
    public partial class UserControlTransactionItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_Supplier;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_ID;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_Search;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_Qty;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_Transaction;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo_Item;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UserControlTransactionItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_refresh;
        
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
            System.Uri resourceLocater = new System.Uri("/CRUDWPF;component/usercontroltransactionitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlTransactionItem.xaml"
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
            
            #line 13 "..\..\UserControlTransactionItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dg_Supplier = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\UserControlTransactionItem.xaml"
            this.dg_Supplier.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Dg_Supplier_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_ID = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\UserControlTransactionItem.xaml"
            this.txt_ID.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Txt_Name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\UserControlTransactionItem.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Txt_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\UserControlTransactionItem.xaml"
            this.Txt_Search.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Txt_Search_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 35 "..\..\UserControlTransactionItem.xaml"
            this.Txt_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txt_Search_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\UserControlTransactionItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Txt_Qty = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\UserControlTransactionItem.xaml"
            this.Txt_Qty.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Txt_Qty_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Combo_Transaction = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\UserControlTransactionItem.xaml"
            this.Combo_Transaction.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Combo_Transaction_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Combo_Item = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\UserControlTransactionItem.xaml"
            this.Combo_Item.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Combo_Item_DataContextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_refresh = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\UserControlTransactionItem.xaml"
            this.btn_refresh.Click += new System.Windows.RoutedEventHandler(this.Btn_refresh_Click);
            
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
            case 3:
            
            #line 27 "..\..\UserControlTransactionItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


﻿#pragma checksum "..\..\GetValues.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B6CB85005E0604B1432D2C02AB77316F566E5673145C576455FFB5665C54556"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
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


namespace Client {
    
    
    /// <summary>
    /// GetValues
    /// </summary>
    public partial class GetValues : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GetValuesLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GIDSLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxGIDS;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AtributsLabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ComboBoxAtributs;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox Opis;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GetValues.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetValuesButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/getvalues.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GetValues.xaml"
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
            this.GetValuesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.GIDSLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ComboBoxGIDS = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\GetValues.xaml"
            this.ComboBoxGIDS.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxGIDS_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AtributsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ComboBoxAtributs = ((System.Windows.Controls.ListBox)(target));
            
            #line 15 "..\..\GetValues.xaml"
            this.ComboBoxAtributs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxAtributs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Opis = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 19 "..\..\GetValues.xaml"
            this.Opis.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Opis_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GetValuesButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\GetValues.xaml"
            this.GetValuesButton.Click += new System.Windows.RoutedEventHandler(this.GetValues_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


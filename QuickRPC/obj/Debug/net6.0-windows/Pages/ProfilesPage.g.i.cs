﻿#pragma checksum "..\..\..\..\Pages\ProfilesPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101956365B7B1AC4621BC08965558802BCCC1B38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Command;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using QuickRPC.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace QuickRPC.Pages {
    
    
    /// <summary>
    /// ProfilesPage
    /// </summary>
    public partial class ProfilesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Pages\ProfilesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.SearchBar ProfilesSeachBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\ProfilesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProfilesBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuickRPC;component/pages/profilespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ProfilesPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProfilesSeachBox = ((HandyControl.Controls.SearchBar)(target));
            
            #line 15 "..\..\..\..\Pages\ProfilesPage.xaml"
            this.ProfilesSeachBox.SearchStarted += new System.EventHandler<HandyControl.Data.FunctionEventArgs<string>>(this.SearchBar_SearchStarted);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\Pages\ProfilesPage.xaml"
            this.ProfilesSeachBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProfilesSeachBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProfilesBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\..\..\Pages\ProfilesPage.xaml"
            this.ProfilesBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProfilesBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


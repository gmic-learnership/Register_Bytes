﻿#pragma checksum "..\..\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6BAFACD95ACC58667C174680D8B40A4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Rectify;
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


namespace Rectify {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnManage;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl pageLogo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popLink;
        
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
            System.Uri resourceLocater = new System.Uri("/Rectify;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
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
            
            #line 8 "..\..\Home.xaml"
            ((Rectify.Home)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\Home.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRegister_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnManage = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Home.xaml"
            this.btnManage.Click += new System.Windows.RoutedEventHandler(this.btnManage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pageLogo = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 5:
            this.LoginName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Home.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btn_back);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 55 "..\..\Home.xaml"
            ((System.Windows.Documents.Run)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.run_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.popLink = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 9:
            
            #line 58 "..\..\Home.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 59 "..\..\Home.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.lnk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


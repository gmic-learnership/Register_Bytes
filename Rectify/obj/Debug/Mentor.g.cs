﻿#pragma checksum "..\..\Mentor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "660D185D489CA4D37314EE0EC9252246"
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
    /// Mentor
    /// </summary>
    public partial class Mentor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFname;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLname;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtConfirm;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbStudentMentor;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegiter;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl pageLogo;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\Mentor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Mentor.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Rectify;component/mentor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mentor.xaml"
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
            
            #line 8 "..\..\Mentor.xaml"
            ((Rectify.Mentor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtLname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtConfirm = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.cmbStudentMentor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnRegiter = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\Mentor.xaml"
            this.btnRegiter.Click += new System.Windows.RoutedEventHandler(this.btnRegiter_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\Mentor.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btn_back);
            
            #line default
            #line hidden
            return;
            case 10:
            this.pageLogo = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 11:
            this.LoginName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 68 "..\..\Mentor.xaml"
            ((System.Windows.Documents.Run)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.run_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 13:
            this.popLink = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 14:
            
            #line 71 "..\..\Mentor.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 72 "..\..\Mentor.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.lnk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9A765D45ABF490FF398A5FF3669A31E4BD30BEDBA0ADAFFB15B7F2DF9DFD509"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using app_main.Pages.Auth_and_Reg;


namespace app_main.Pages.Auth_and_Reg {
    
    
    /// <summary>
    /// AuthPage
    /// </summary>
    public partial class AuthPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockEmptyLogin;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordTextbox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockEmptyPassword;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockNoUser;
        
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
            System.Uri resourceLocater = new System.Uri("/app_main;component/pages/auth%20and%20reg/authpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
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
            this.loginTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBlockEmptyLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.passwordTextbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            
            #line 47 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Auth_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 50 "..\..\..\..\Pages\Auth and Reg\AuthPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Reg_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBlockEmptyPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBlockNoUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

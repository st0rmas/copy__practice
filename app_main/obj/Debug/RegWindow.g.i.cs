﻿#pragma checksum "..\..\RegWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F80A54A2699FDD0CC788622A2CD328BDF4154E6AC59E48DE67371F1A22F3110B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using app_main.windows;


namespace app_main.windows {
    
    
    /// <summary>
    /// RegWindow
    /// </summary>
    public partial class RegWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 102 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockEmptyLogin;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockEmptyPassword;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password2RegTextbox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockEmptyPassword2;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginRegTextbox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordRegTextbox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPasswordNotEqual;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockUserAlreadyExist;
        
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
            System.Uri resourceLocater = new System.Uri("/app_main;component/regwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegWindow.xaml"
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
            this.TextBlockEmptyLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TextBlockEmptyPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.password2RegTextbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.TextBlockEmptyPassword2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 118 "..\..\RegWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Return_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 120 "..\..\RegWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_CreateAccount_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.loginRegTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.passwordRegTextbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.TextBlockPasswordNotEqual = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TextBlockUserAlreadyExist = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


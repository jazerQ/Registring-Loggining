﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64FECDD54F388A64BFC95F2DB6284DDB24434CC4"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 218 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxUsername;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelForPass;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TBtnEye;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image EyeToggle;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxEmail;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSignIn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((WpfApp1.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 183 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TBoxUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 218 "..\..\..\MainWindow.xaml"
            this.TBoxUsername.GotFocus += new System.Windows.RoutedEventHandler(this.TBoxUsername_GotFocus);
            
            #line default
            #line hidden
            
            #line 218 "..\..\..\MainWindow.xaml"
            this.TBoxUsername.LostFocus += new System.Windows.RoutedEventHandler(this.TBoxUsername_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 225 "..\..\..\MainWindow.xaml"
            this.PBoxPassword.GotFocus += new System.Windows.RoutedEventHandler(this.PBoxPassword_GotFocus);
            
            #line default
            #line hidden
            
            #line 225 "..\..\..\MainWindow.xaml"
            this.PBoxPassword.LostFocus += new System.Windows.RoutedEventHandler(this.PBoxPassword_LostFocus);
            
            #line default
            #line hidden
            
            #line 230 "..\..\..\MainWindow.xaml"
            this.PBoxPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.PBoxPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBoxPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 232 "..\..\..\MainWindow.xaml"
            this.TBoxPassword.GotFocus += new System.Windows.RoutedEventHandler(this.TBoxPassword_GotFocus);
            
            #line default
            #line hidden
            
            #line 232 "..\..\..\MainWindow.xaml"
            this.TBoxPassword.LostFocus += new System.Windows.RoutedEventHandler(this.TBoxPassword_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.labelForPass = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TBtnEye = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\..\MainWindow.xaml"
            this.TBtnEye.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EyeToggle = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.TBoxEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 245 "..\..\..\MainWindow.xaml"
            this.TBoxEmail.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 245 "..\..\..\MainWindow.xaml"
            this.TBoxEmail.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 250 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 255 "..\..\..\MainWindow.xaml"
            this.BtnSignIn.Click += new System.Windows.RoutedEventHandler(this.BtnSignIn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\Windows\CreateTaskWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B4763EB93C006E2C813509DC20F654E183C316197715F17FFD91EDBD42DD7BA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopWPFUI.State.Navigators;
using DesktopWPFUI.Windows;
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


namespace DesktopWPFUI.Windows {
    
    
    /// <summary>
    /// CreateTaskWindow
    /// </summary>
    public partial class CreateTaskWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Start;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTagButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\CreateTaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel TagsStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/TodoApp;component/windows/createtaskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\CreateTaskWindow.xaml"
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
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\CreateTaskWindow.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSaveHandleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Start = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.AddTagButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Windows\CreateTaskWindow.xaml"
            this.AddTagButton.Click += new System.Windows.RoutedEventHandler(this.AddTagButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TagsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


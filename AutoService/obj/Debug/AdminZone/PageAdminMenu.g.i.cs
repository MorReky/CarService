﻿#pragma checksum "..\..\..\AdminZone\PageAdminMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D0F93F45467C028AD2A886BAA0F4FADBADF522A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoService.AdminZone;
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


namespace AutoService.AdminZone {
    
    
    /// <summary>
    /// PageAdminMenu
    /// </summary>
    public partial class PageAdminMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\AdminZone\PageAdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditService;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AdminZone\PageAdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClientRecord;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AdminZone\PageAdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnComingRecord;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoService;component/adminzone/pageadminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminZone\PageAdminMenu.xaml"
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
            this.BtnEditService = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\AdminZone\PageAdminMenu.xaml"
            this.BtnEditService.Click += new System.Windows.RoutedEventHandler(this.BtnEditService_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClientRecord = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\AdminZone\PageAdminMenu.xaml"
            this.BtnClientRecord.Click += new System.Windows.RoutedEventHandler(this.BtnClientRecord_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnComingRecord = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\AdminZone\PageAdminMenu.xaml"
            this.BtnComingRecord.Click += new System.Windows.RoutedEventHandler(this.BtnComingRecord_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\View\Admin\AdminMenuPM.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "291FF0A7442DBADDD674832AC21BAD75126B4B4F18096DDA677040176A8650CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ITCompany_v1._0.View.Admin;
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
using System.Windows.Interactivity;
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


namespace ITCompany_v1._0.View.Admin {
    
    
    /// <summary>
    /// AdminMenuPM
    /// </summary>
    public partial class AdminMenuPM : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox chooseProjectManager;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPMName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeletePM;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditPM;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddPM;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox chooseProject;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox chooseProjectManager_Copy;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAddPMName;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAppointPM;
        
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
            System.Uri resourceLocater = new System.Uri("/ITCompany v1.0;component/view/admin/adminmenupm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
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
            this.Exit1 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
            this.Exit1.Click += new System.Windows.RoutedEventHandler(this.close_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chooseProjectManager = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.tbPMName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnDeletePM = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.BtnEditPM = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.BtnAddPM = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.chooseProject = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.chooseProjectManager_Copy = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.tbAddPMName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.BtnAppointPM = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\View\Admin\AdminMenuPM.xaml"
            this.BtnAppointPM.Click += new System.Windows.RoutedEventHandler(this.BtnAddPM_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

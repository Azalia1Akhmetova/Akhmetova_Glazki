﻿#pragma checksum "..\..\AgentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "955EAC92F417CED563513587CD4120A558580A515B018B913C1629814FB87947"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Akhmetova_Glazki;
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


namespace Akhmetova_Glazki {
    
    
    /// <summary>
    /// AgentPage
    /// </summary>
    public partial class AgentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCount;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBAllRecords;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftDirButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PageListBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightDirButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCombo;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterCombo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AgentListView;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AgentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PriorityChange;
        
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
            System.Uri resourceLocater = new System.Uri("/Akhmetova_Glazki;component/agentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgentPage.xaml"
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
            
            #line 9 "..\..\AgentPage.xaml"
            ((Akhmetova_Glazki.AgentPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TBAllRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.LeftDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AgentPage.xaml"
            this.LeftDirButton.Click += new System.Windows.RoutedEventHandler(this.LeftDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 24 "..\..\AgentPage.xaml"
            this.PageListBox.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PageListBox_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightDirButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AgentPage.xaml"
            this.RightDirButton.Click += new System.Windows.RoutedEventHandler(this.RightDirButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\AgentPage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SortCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\AgentPage.xaml"
            this.SortCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FilterCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\AgentPage.xaml"
            this.FilterCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\AgentPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.AgentListView = ((System.Windows.Controls.ListView)(target));
            
            #line 64 "..\..\AgentPage.xaml"
            this.AgentListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AgentListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.PriorityChange = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\AgentPage.xaml"
            this.PriorityChange.Click += new System.Windows.RoutedEventHandler(this.PriorityChange_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 12:
            
            #line 99 "..\..\AgentPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


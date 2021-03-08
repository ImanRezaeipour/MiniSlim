﻿#pragma checksum "..\..\..\..\Views\Shared\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "758E429F8056350216B88F582F914054"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Animation;
using Telerik.Windows.Controls.Behaviors;
using Telerik.Windows.Controls.Carousel;
using Telerik.Windows.Controls.Docking;
using Telerik.Windows.Controls.DragDrop;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls.LayoutControl;
using Telerik.Windows.Controls.Legend;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls.RadialMenu;
using Telerik.Windows.Controls.RibbonView;
using Telerik.Windows.Controls.RichTextBoxUI;
using Telerik.Windows.Controls.RichTextBoxUI.ColorPickers;
using Telerik.Windows.Controls.RichTextBoxUI.TableControls;
using Telerik.Windows.Controls.TransitionEffects;
using Telerik.Windows.Controls.TreeListView;
using Telerik.Windows.Controls.TreeView;
using Telerik.Windows.Controls.Wizard;
using Telerik.Windows.Data;
using Telerik.Windows.Documents.FormatProviders.Html;
using Telerik.Windows.Documents.FormatProviders.OpenXml.Docx;
using Telerik.Windows.Documents.FormatProviders.Rtf;
using Telerik.Windows.Documents.FormatProviders.Txt;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.UI;
using Telerik.Windows.DragDrop;
using Telerik.Windows.DragDrop.Behaviors;
using Telerik.Windows.Input.Touch;
using Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;
using Telerik.Windows.Media.Imaging.Tools.UI;
using Telerik.Windows.Shapes;


namespace BioMiniSlim.Wpf.Views.Shared {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Telerik.Windows.Controls.RadWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Views\Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadButton PersonListButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\Views\Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadButton PersonCreateButton;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\Views\Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Frame;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\Views\Shared\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadButton PersonFindButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BioMiniSlim.Wpf;component/views/shared/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Shared\MainWindow.xaml"
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
            
            #line 4 "..\..\..\..\Views\Shared\MainWindow.xaml"
            ((BioMiniSlim.Wpf.Views.Shared.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PersonListButton = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 7 "..\..\..\..\Views\Shared\MainWindow.xaml"
            this.PersonListButton.Click += new System.Windows.RoutedEventHandler(this.PersonListButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PersonCreateButton = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 8 "..\..\..\..\Views\Shared\MainWindow.xaml"
            this.PersonCreateButton.Click += new System.Windows.RoutedEventHandler(this.PersonCreateButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Frame = ((System.Windows.Controls.Frame)(target));
            return;
            case 5:
            this.PersonFindButton = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 10 "..\..\..\..\Views\Shared\MainWindow.xaml"
            this.PersonFindButton.Click += new System.Windows.RoutedEventHandler(this.PersonFindButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C8BB188390C60304BDF441F3CD89864E786ED753088F4F836D520BC2C30DDE8"
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox GenreList;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNameGenre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSaveGenre;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDeleteGenre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNewGenre;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.GenreList = ((System.Windows.Controls.ListBox)(target));
            
            #line 14 "..\..\Window1.xaml"
            this.GenreList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilmsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxNameGenre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ButtonSaveGenre = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Window1.xaml"
            this.ButtonSaveGenre.Click += new System.Windows.RoutedEventHandler(this.ButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonDeleteGenre = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Window1.xaml"
            this.ButtonDeleteGenre.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonNewGenre = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Window1.xaml"
            this.ButtonNewGenre.Click += new System.Windows.RoutedEventHandler(this.ButtonNew_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


#pragma checksum "..\..\..\InfoEntry.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95D020F19E8F52D93209A1315C867B106E50184E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Greenify;
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


namespace Greenify {
    
    
    /// <summary>
    /// InfoEntry
    /// </summary>
    public partial class InfoEntry : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendDataBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateUserInfo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateGaze;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox oil;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox milage;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox avion;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox rec_pap;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\InfoEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox rec_metal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Greenify;component/infoentry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InfoEntry.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SendDataBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\InfoEntry.xaml"
            this.SendDataBtn.Click += new System.Windows.RoutedEventHandler(this.SendDataBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DateUserInfo = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\InfoEntry.xaml"
            this.DateUserInfo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DateGaze = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.oil = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.milage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.avion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.rec_pap = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.rec_metal = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


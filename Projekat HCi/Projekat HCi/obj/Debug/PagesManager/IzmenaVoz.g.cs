#pragma checksum "..\..\..\PagesManager\IzmenaVoz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8272963CB0B6E45D6E42C43DBD350307D7E7749F508CB180437F66B79869D319"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekat_HCi.PagesManager;
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


namespace Projekat_HCi.PagesManager {
    
    
    /// <summary>
    /// IzmenaVoz
    /// </summary>
    public partial class IzmenaVoz : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Projekat_HCi.PagesManager.IzmenaVoz izmena_voz;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgrMain;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox naziv_1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_1;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox br_m;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\PagesManager\IzmenaVoz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox br_v;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekat HCi;component/pagesmanager/izmenavoz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PagesManager\IzmenaVoz.xaml"
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
            this.izmena_voz = ((Projekat_HCi.PagesManager.IzmenaVoz)(target));
            return;
            case 2:
            this.dgrMain = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.naziv_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.id_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.br_m = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.br_v = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 61 "..\..\..\PagesManager\IzmenaVoz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 62 "..\..\..\PagesManager\IzmenaVoz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


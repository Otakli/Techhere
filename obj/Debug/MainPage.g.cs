﻿

#pragma checksum "C:\Users\Radon\documents\visual studio 2015\Projects\Techhere\Techhere\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A5E7805501E09751B108484CF498C66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Techhere
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 56 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.image_logo_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 139 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Pivot)(target)).PivotItemLoaded += this.pivot_page_PivotItemLoaded;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 135 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).LostFocus += this.textBox_LostFocus;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 85 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button_menu_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 98 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button_kullanici_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



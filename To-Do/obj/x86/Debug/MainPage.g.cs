﻿#pragma checksum "E:\VS Projects\To-Do_App\To-Do\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E012004F5B3E77394D350DC7423B5C628A0C1992A3E389711EF61A74D9F561D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace To_Do
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 109: // MainPage.xaml line 471
                {
                    this.AppTitleBar = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 110: // MainPage.xaml line 487
                {
                    this.nview = (global::Microsoft.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.nview).DisplayModeChanged += this.nview_DisplayModeChanged;
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.nview).SelectionChanged += this.NavigationView_SelectionChanged;
                }
                break;
            case 111: // MainPage.xaml line 518
                {
                    this.LoadingUI = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 112: // MainPage.xaml line 494
                {
                    this.inf = (global::Microsoft.UI.Xaml.Controls.InfoBadge)(target);
                }
                break;
            case 113: // MainPage.xaml line 511
                {
                    this.bgIMG = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 114: // MainPage.xaml line 512
                {
                    this.acrylic = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 115: // MainPage.xaml line 513
                {
                    this.acrylictint = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 116: // MainPage.xaml line 514
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


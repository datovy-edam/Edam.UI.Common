﻿#pragma checksum "C:\prjs\Edam.Libraries\Edam.UI\Edam.UI.Common\Edam.UI.ProjectLibrary\Controls\Booklets\BookletTextCellControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20E361893C7808642CBE421C8A819F3BEE7787DF037D79F0967FF4C01DE6C34E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Edam.UI.Controls.Booklets
{
    partial class BookletTextCellControl : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2503")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Controls\Booklets\BookletTextCellControl.xaml line 11
                {
                    this.PanelControl = global::WinRT.CastExtensions.As<global::Edam.UI.Controls.Booklets.FramePanelControl>(target);
                    ((global::Edam.UI.Controls.Booklets.FramePanelControl)this.PanelControl).GotFocus += this.PanelControl_GotFocus;
                }
                break;
            case 3: // Controls\Booklets\BookletTextCellControl.xaml line 13
                {
                    this.TextInputPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2503")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


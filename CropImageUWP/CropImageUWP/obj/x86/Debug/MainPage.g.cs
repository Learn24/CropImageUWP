﻿#pragma checksum "C:\Users\Robel\Source\Repos\CropImageUWP\CropImageUWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "159B8FD9BB30540D178338E26C1C5EA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CropImageUWP
{
    partial class MainPage : 
        global::CropImageUWP.Common.LayoutAwarePage, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.pageRoot = (global::CropImageUWP.Common.LayoutAwarePage)(target);
                }
                break;
            case 2:
                {
                    this.contentRoot = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.titleGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.Footer = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.FooterPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element6 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 154 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element6).Click += this.Footer_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.statusText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.sourceImageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.previewGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.selectInfoInBitmapText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.previewImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12:
                {
                    this.originalImageInfoText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.sourceImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14:
                {
                    this.imageCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 15:
                {
                    this.nonselectRegion = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 16:
                {
                    this.selectRegion = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 17:
                {
                    this.topLeftCorner = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 18:
                {
                    this.topRightCorner = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 19:
                {
                    this.bottomLeftCorner = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 20:
                {
                    this.bottomRightCorner = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                }
                break;
            case 21:
                {
                    this.operationPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 22:
                {
                    this.openImageButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.openImageButton).Click += this.openImageButton_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.saveImageButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.saveImageButton).Click += this.saveImageButton_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.ApplicationViewStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 25:
                {
                    this.FullScreenLandscape = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 26:
                {
                    this.Filled = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 27:
                {
                    this.FullScreenPortrait = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 28:
                {
                    this.Snapped = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


﻿#pragma checksum "d:\work\Lottozo\LottoWPUnified\LottozoWP7\Views\UserControls\NumberButton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6AEF24D9DB8E8FCC1082F77175B9DEA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Lottoszamok.Views.UserControls {
    
    
    public partial class NumberButton : System.Windows.Controls.Button {
        
        internal System.Windows.Controls.TextBlock NumberTextBlock;
        
        internal System.Windows.Controls.Image IsSelectedImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Lottoszamok;component/Views/UserControls/NumberButton.xaml", System.UriKind.Relative));
            this.NumberTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("NumberTextBlock")));
            this.IsSelectedImage = ((System.Windows.Controls.Image)(this.FindName("IsSelectedImage")));
        }
    }
}


﻿#pragma checksum "D:\work\Lottozo\LottoWPUnified\LottozoWP7\Views\UserControls\FieldEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB6C8129CE108B72513B424F22C7F515"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
    
    
    public partial class FieldEditor : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock FieldTitle;
        
        internal System.Windows.Controls.Button deleteButton;
        
        internal System.Windows.Controls.Button selectButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Lottoszamok;component/Views/UserControls/FieldEditor.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.FieldTitle = ((System.Windows.Controls.TextBlock)(this.FindName("FieldTitle")));
            this.deleteButton = ((System.Windows.Controls.Button)(this.FindName("deleteButton")));
            this.selectButton = ((System.Windows.Controls.Button)(this.FindName("selectButton")));
        }
    }
}


﻿#pragma checksum "C:\storage\work\Lottoszamok\LottoWPUnified\LottozoWP7\Views\LottoView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "95F668378F9CE4A6257E504DE8D149A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Lottoszamok.Views {
    
    
    public partial class LottoView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock TimeText;
        
        internal System.Windows.Controls.Grid NumbersGrid;
        
        internal System.Windows.Controls.TextBlock Award;
        
        internal System.Windows.Controls.TextBlock FiveMatch;
        
        internal System.Windows.Controls.TextBlock FiveAward;
        
        internal System.Windows.Controls.TextBlock FourMatch;
        
        internal System.Windows.Controls.TextBlock FourAward;
        
        internal System.Windows.Controls.TextBlock ThreeMatch;
        
        internal System.Windows.Controls.TextBlock ThreeAward;
        
        internal System.Windows.Controls.TextBlock TwoMatch;
        
        internal System.Windows.Controls.TextBlock TwoAward;
        
        internal System.Windows.Controls.Button GoToLottoTicket;
        
        internal System.Windows.Controls.Image LottoImage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Lottoszamok;component/Views/LottoView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TimeText = ((System.Windows.Controls.TextBlock)(this.FindName("TimeText")));
            this.NumbersGrid = ((System.Windows.Controls.Grid)(this.FindName("NumbersGrid")));
            this.Award = ((System.Windows.Controls.TextBlock)(this.FindName("Award")));
            this.FiveMatch = ((System.Windows.Controls.TextBlock)(this.FindName("FiveMatch")));
            this.FiveAward = ((System.Windows.Controls.TextBlock)(this.FindName("FiveAward")));
            this.FourMatch = ((System.Windows.Controls.TextBlock)(this.FindName("FourMatch")));
            this.FourAward = ((System.Windows.Controls.TextBlock)(this.FindName("FourAward")));
            this.ThreeMatch = ((System.Windows.Controls.TextBlock)(this.FindName("ThreeMatch")));
            this.ThreeAward = ((System.Windows.Controls.TextBlock)(this.FindName("ThreeAward")));
            this.TwoMatch = ((System.Windows.Controls.TextBlock)(this.FindName("TwoMatch")));
            this.TwoAward = ((System.Windows.Controls.TextBlock)(this.FindName("TwoAward")));
            this.GoToLottoTicket = ((System.Windows.Controls.Button)(this.FindName("GoToLottoTicket")));
            this.LottoImage = ((System.Windows.Controls.Image)(this.FindName("LottoImage")));
        }
    }
}


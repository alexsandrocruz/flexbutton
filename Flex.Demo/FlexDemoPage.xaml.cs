﻿using Xamarin.Forms;
using Flex.Controls;
using System;

namespace Flex.Demo
{
    public partial class FlexDemoPage : ContentPage
    {
        public FlexDemoPage()
        {
            InitializeComponent();
        }

        void DemoButton_TouchedDown(object sender, EventArgs e)
        {
            ButtonStatus.Text = "Pressed";
        }

        void DemoButton_TouchedUp(object sender, EventArgs e)
        {
            ButtonStatus.Text = "Released";
        }
    }
}

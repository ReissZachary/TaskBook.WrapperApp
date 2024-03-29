﻿using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TaskBook.WrapperApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }       

        private async void ButtonAddTodo_Click(object sender, RoutedEventArgs e)
        {
            var testMessage = new MessageDialog("Todo Added!");
            await testMessage.ShowAsync();
        }
    }
}

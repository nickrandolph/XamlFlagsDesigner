﻿using Windows.UI.Xaml.Controls;

namespace XamlFlagsDesigner.UserControl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; } = new MainPageViewModel();


        public MainPage()
        {
            InitializeComponent();
        }
    }
}

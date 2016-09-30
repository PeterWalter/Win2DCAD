using System;
using Win2DCAD.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace Win2DCAD.Views
    {
    public sealed partial class MainPage :Page
        {
        public MainPage()
            {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            }
        }
    }

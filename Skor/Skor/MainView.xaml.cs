﻿namespace Skor
{
    using Xamarin.Forms;

    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}

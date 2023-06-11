using System;
using System.Collections.Generic;
using System.ComponentModel;
using Vizualizace.Models;
using Vizualizace.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vizualizace.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
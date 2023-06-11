using System.ComponentModel;
using Vizualizace.ViewModels;
using Xamarin.Forms;

namespace Vizualizace.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
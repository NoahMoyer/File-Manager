using File_Manager.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace File_Manager.Views
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
using SQLiteTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SQLiteTest.Views
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
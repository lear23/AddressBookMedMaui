using MauiAddressBook.ViewsModels;

namespace MauiAddressBook
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

     
    }

}

using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListsView : ContentPage
{
    public GroceryListsView(GroceryListViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }  
}
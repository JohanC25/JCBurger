using JCBurger.Models;
using JCBurger.Data;

namespace JCBurger.Views;

[QueryProperty("Item","Item")]
public partial class JCBurgerItemPage : ContentPage
{
	public JCBurgers Item
	{
		get =>BindingContext as JCBurgers;
		set =>BindingContext = value;
	}

    public JCBurgerItemPage()
	{
		InitializeComponent();
	}
	
	private void OnSaveClicked(object sender, EventArgs e)
	{
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

	private void OnCancelClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}
}
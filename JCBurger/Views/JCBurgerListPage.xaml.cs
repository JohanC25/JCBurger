using JCBurger.Models;

namespace JCBurger.Views;

public partial class JCBurgerListPage : ContentPage
{
	public JCBurgerListPage()
	{
		InitializeComponent();
        List<JCBurgers> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//JCBurgerItemPage");
    }
    public void JCActualizar()
    {
        List<JCBurgers> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            JCActualizar();
        }
    }
}
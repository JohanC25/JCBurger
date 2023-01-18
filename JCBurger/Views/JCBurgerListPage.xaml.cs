using JCBurger.Models;

namespace JCBurger.Views;

public partial class JCBurgerListPage : ContentPage
{
	public JCBurgerListPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public void OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(JCBurgerItemPage),true,new Dictionary<string, object> { ["Item"] = new JCBurgers()});
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<JCBurgers> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
}
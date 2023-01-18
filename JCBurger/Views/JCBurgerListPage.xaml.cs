using JCBurger.Models;

namespace JCBurger.Views;

public partial class JCBurgerListPage : ContentPage
{
	public JCBurgerListPage()
	{
		InitializeComponent();
        List<JCBurgers> burger = App.BurgerRepo.GetAllBurgers();
        BindingContext = this;
        burgerList.ItemsSource = burger;
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

    async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(JCBurgerItemPage), true, new Dictionary<string, object> { ["Item"] = (JCBurgers)e.CurrentSelection.FirstOrDefault() });
    }
}
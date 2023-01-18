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

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(JCBurgerItemPage), true, new Dictionary<string, object> 
        {
            ["Item"] = new JCBurgers()
        });
    }

    public void Update()
    {
        List<JCBurgers> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource= burger;
    }

    protected override void OnAppearing()
    {
        Update();
    }

    async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(JCBurgerItemPage), true, new Dictionary<string, object> 
        { 
            ["Item"] = (JCBurgers)e.CurrentSelection.FirstOrDefault()
        });
    }
}
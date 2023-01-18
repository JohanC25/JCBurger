using JCBurger.Models;
using System.Threading.Tasks;
using JCBurger.Data;

namespace JCBurger.Views;

public partial class JCBurgerItemPage : ContentPage
{
	JCBurgers Item = new JCBurgers();
	bool _flag;

    public JCBurgerItemPage()
	{
		InitializeComponent();
		JCBurgerListPage burgerListView = new JCBurgerListPage();
		burgerListView.JCActualizar();
	}
	
	private void OnSaveClicked(object sender, EventArgs e)
	{
        Item.JCName = nameB.Text;
        Item.JCDescription = descB.Text;
        Item.JCWithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("//JCBurgerListPage");
    }

	private void OnCancelClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//JCBurgerListPage");
	}

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
}
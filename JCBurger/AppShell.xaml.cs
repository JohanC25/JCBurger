﻿using JCBurger.Views;

namespace JCBurger;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(JCBurgerItemPage), typeof(JCBurgerItemPage));
    }
}

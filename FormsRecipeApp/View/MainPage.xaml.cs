using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FormsRecipeApp
{
	public partial class MainPage : ContentPage
	{
		
		MainPageViewModel mainPageViewModel;
		
		public MainPage()
		{			
			mainPageViewModel = new MainPageViewModel();
			BindingContext = mainPageViewModel;
			InitializeComponent();
		}

		public void OnSelected(object o, ItemTappedEventArgs e)
		{
			var recepToSee = e.Item as Recipe;
			Navigation.PushAsync(new DetailPage(recepToSee));
		}

	}
}

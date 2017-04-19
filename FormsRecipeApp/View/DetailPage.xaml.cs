using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FormsRecipeApp
{
	public partial class DetailPage : ContentPage
	{
		DetailPageViewModel detailPageViewModel;

		public DetailPage(Recipe recipe)
		{
			detailPageViewModel = new DetailPageViewModel(recipe);
			BindingContext = detailPageViewModel;
			InitializeComponent();
		}

		void DecreaseButton_clicked(object sender, EventArgs e)
		{
			FileList.ItemsSource = detailPageViewModel.UpdateRecipeIngredientsByMultiply(false);
			LabelNumberOfMultiply.Text = "" + detailPageViewModel.RecipeToKook.NumberOfMultiply;
		}

		void IncreaseButton_clicked(object sender, EventArgs e)
		{
			FileList.ItemsSource = detailPageViewModel.UpdateRecipeIngredientsByMultiply(true);
			LabelNumberOfMultiply.Text = "" + detailPageViewModel.RecipeToKook.NumberOfMultiply;
		}

		public void OnTaskAdd(object o, EventArgs e)
		{
			DisplayAlert("Mark checked","Mark test","OK");
		}
	}
}

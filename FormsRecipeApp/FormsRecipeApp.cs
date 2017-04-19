using System;

using Xamarin.Forms;

namespace FormsRecipeApp
{
	public class App : Application
	{
		public App()
		{
			var firstPage = new MainPage();
			firstPage.Title = "Recepten";



			MainPage = new NavigationPage(firstPage)
			{
				BarBackgroundColor = Color.FromHex("#F7F7F7"),
				BarTextColor = Color.Black,
				BackgroundColor = Color.FromHex("#EFEFEF")
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

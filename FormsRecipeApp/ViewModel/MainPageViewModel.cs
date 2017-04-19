using System;
using System.Collections.Generic;
using System.Linq;

namespace FormsRecipeApp
{
	public class MainPageViewModel
	{
		public List<Recipe> Recipes { get; set; }
		
		public MainPageViewModel()
		{
			RecipeDataSource source = new RecipeDataSource();
			Recipes = source.GetRecipes().ToList();
		}

	}
}

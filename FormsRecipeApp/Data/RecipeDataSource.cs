using System;
using System.Collections.Generic;

namespace FormsRecipeApp
{
	public abstract class ApiDataSource
	{
		public string Name = "API";
	}

	public class RecipeDataSource : ApiDataSource,IRecipeDataSource
	{
		public RecipeDataSource()
		{
		}

		public IEnumerable<Recipe> GetRecipes()
		{
			return new List<Recipe>{
				new Recipe(
					"Curry van zoete aardappel",
					"ScreenShot.png",
					"30 min. bereiden",
					new List<Ingredient>()
					{
					new Ingredient("witte rijst", 75,"gram","ScreenShot.png", false),
						new Ingredient("uien", 1,"aantal","ScreenShot.png", false),
						new Ingredient("olijfolie", 0.25f,"eetlepel","ScreenShot.png", false),
						new Ingredient("groene curry paste", 14.5f,"gram","ScreenShot.png", false),
						new Ingredient("kipdijfiletreepjes", 100,"gram","ScreenShot.png", false),
						new Ingredient("kokosmelk", 100,"mililiter","ScreenShot.png", false),
						new Ingredient("verse doperwten", 100,"gram","ScreenShot.png", false),
						new Ingredient("babyspinazie", 50,"gram","ScreenShot.png", false)
					},
					0
				),
				new Recipe(
					"Pittige curry met kip en groene groente",
					"ScreenShot.png",
					"30 min. bereiden",
					new List<Ingredient>()
					{
						new Ingredient("witte rijst", 75,"gram","ScreenShot.png", false),
						new Ingredient("uien", 1,"aantal","ScreenShot.png", false),
						new Ingredient("olijfolie", 0.25f,"eetlepel","ScreenShot.png", false),
						new Ingredient("groene curry paste", 14.5f,"gram","ScreenShot.png", false),
						new Ingredient("kipdijfiletreepjes", 100,"gram","ScreenShot.png", false),
						new Ingredient("kokosmelk", 100,"mililiter","ScreenShot.png",false),
						new Ingredient("verse doperwten", 100,"gram","ScreenShot.png", false),
						new Ingredient("babyspinazie", 50,"gram","ScreenShot.png", false)
					},
					1
				)
			};
		}
	}
}

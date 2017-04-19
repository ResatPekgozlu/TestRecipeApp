using System;
using System.Collections.Generic;

namespace FormsRecipeApp
{
	public class Recipe
	{
		public int Code { get; set; }
		public string RecipeTitle { get; set; }
		public string FotoUrl { get; set; }
		public string MinuteToMake { get; set; }
		public int NumberOfMultiply { get; set; }
        public int MaxNumberOfMultiply { get; set; }
		public List<Ingredient> Ingredients { get; set; }

		public Recipe(string name, string fotoUrl,string minuteToMake,List<Ingredient> ingredients,int code)
		{
			RecipeTitle = name;
			FotoUrl = fotoUrl;
			MinuteToMake = minuteToMake;
			Ingredients = ingredients;
			Code = code;
			NumberOfMultiply = 1;
			MaxNumberOfMultiply = 5;
		}
	}
}

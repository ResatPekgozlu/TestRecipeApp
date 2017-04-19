using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace FormsRecipeApp
{
	public class DetailPageViewModel
	{
		public List<Ingredient> Ingredients { get; set; }
		public Recipe RecipeToKook { get; set; }

		public DetailPageViewModel(Recipe recipe)
		{
			this.RecipeToKook = recipe;
			this.Ingredients = recipe.Ingredients;

		}

		public dynamic UpdateRecipeIngredientsByMultiply(bool isIncrease)
		{
			RecipeToKook.NumberOfMultiply = (isIncrease) ? RecipeToKook.NumberOfMultiply + 1 : RecipeToKook.NumberOfMultiply - 1;

			if (RecipeToKook.NumberOfMultiply>RecipeToKook.MaxNumberOfMultiply ||RecipeToKook.NumberOfMultiply<1 )
			{
                RecipeToKook.NumberOfMultiply = 1;
			}

            var OrderdedList = Ingredients.Select(c => new
			{
				Name = c.Name,
				UnitQuantity = c.UnitQuantity * RecipeToKook.NumberOfMultiply,
				IsToken = c.IsToken,
				UnitName = c.UnitName,
				UnitFotoUrl = c.UnitFotoUrl,
				UnitMultiply = RecipeToKook.NumberOfMultiply
		 });

			return OrderdedList;
		}

	}
}

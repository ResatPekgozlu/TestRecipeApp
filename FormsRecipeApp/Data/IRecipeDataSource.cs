using System;
using System.Collections.Generic;

namespace FormsRecipeApp
{
	public interface IRecipeDataSource
	{
		IEnumerable<Recipe> GetRecipes();
	}
}

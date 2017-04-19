using System;
using System.Collections.Generic;
using System.Linq;

namespace FormsRecipeApp
{
	public static class IRecipeDataSourceExtensions
	{
		public static string getFirstLetterResat(this string name)
		{
			return "Resat " + name;
		}

	}
}

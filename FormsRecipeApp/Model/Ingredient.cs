namespace FormsRecipeApp
{
	public class Ingredient
	{
		public string Name { get; set; }
		public float UnitQuantity { get; set; }
		public int UnitMultiply { get; set; }
		public string UnitName { get; set; }
		public string UnitFotoUrl { get; set; }
		public bool IsToken { get; set; }

		public Ingredient(string name, float unitQuantity, string unitName, string unitFotoUrl, bool isToken)
		{
			Name = name;
			UnitQuantity = unitQuantity;
			UnitName = unitName;
			IsToken = isToken;
            UnitFotoUrl = unitFotoUrl;
			UnitMultiply = 1;
		}

	}
}
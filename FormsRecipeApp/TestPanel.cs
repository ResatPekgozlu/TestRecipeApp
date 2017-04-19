using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FormsRecipeApp
{
	public class TestPanel
	{
		public TestPanel()
		{
			var customers = Retrieve();

			var SortByCode = customers.OrderBy(c => c.FirstName);
			var SortByCodeReverse = customers.OrderBy(c => c.FirstName).Reverse();
			var SortBytype = customers.OrderBy(c => c.Id);
			//nullable values sort
			var SortByNullableType = customers.OrderByDescending(c => c.Id.HasValue)
											.ThenBy(c => c.Id);


			var CustomersNames = customers.Select(c => c.LastName + " , " + c.FirstName);

			var GetNamesAndEmailWithanonimusClass = customers.Select(c => new
			{
				Name=c.LastName,
				c.FirstName
			});





		}

		public List<Customer> Retrieve()
		{
			return new List<Customer>
			{
				new Customer("Resat","Pekgozlu",10),
                new Customer("Maurits","Oussoren",21),
                new Customer("Vera","Willems",7),

			};

		}



		

	}

	public class Customer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public int? Id { get; set; }

		public Customer(string firstName, string lastName, int id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Id = id;
		}

	}

}

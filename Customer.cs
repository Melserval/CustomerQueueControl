using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerQueueControl
{
	class Customer
	{
		private readonly string _name;
		private string _desc;
		private List<Dish> _meal;

		public Customer(string name, string desc=null)
		{
			this._name = name;
			this._meal = new List<Dish>();
			this._desc = desc ?? name;
		}

		public string Name => this._name;
		public string Desc => this._desc;

		public int FlapjackCount => this._meal.Count;

		public void TakeFlapjacks(Dish food, int howmany)
		{
			for (; howmany > 0; howmany--)
			{
				this._meal.Add(food);
			}
		}

		public void EatFlapjacks(System.Windows.Forms.TextBox textBox)
		{
			if (this._meal.Count > 0)
			{
				textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
				textBox.Text = $"*** {this.Name} обедает. ***" + Environment.NewLine;

				while (this._meal.Count > 0)
				{
					textBox.Text += $"съел {this._meal.Last().DisplayName}." + Environment.NewLine;
					this._meal.RemoveAt(this._meal.Count - 1);
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breackfast_for_Lamberjack
{
	class Lamberjack
	{
		private readonly string _name;
		private List<Flapjack> _meal;

		public Lamberjack(string name)
		{
			this._name = name;
			this._meal = new List<Flapjack>();
		}

		public string Name => this._name;

		public int FlapjackCount => this._meal.Count;

		public void TakeFlapjacks(Flapjack food, int howmany)
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
					textBox.Text +=  $"съел {this._meal.Last().DisplayName}." + Environment.NewLine;
					this._meal.RemoveAt(this._meal.Count - 1);
				}
			} 
		}
	}
}

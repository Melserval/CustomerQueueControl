using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackfast_for_Lamberjack
{
	// Перечень блюд в меню.
	// настройка содержимого и управление отображением.
	[Serializable]
	class MealMenu
	{
		private List<Flapjack> itemsMenu = new List<Flapjack>();
		private ListBox displaylistMenu;
		public MealMenu(System.Windows.Forms.ListBox list)
		{
			this.displaylistMenu = list;
		}

		public List<Flapjack> List => itemsMenu;

		public void Add(params Flapjack[] meals)
		{
			foreach (Flapjack meal in meals)
			{
				this.itemsMenu.Add(meal);
				this.displaylistMenu.Items.Add(meal.DisplayName);
			}
		}

		public void Remove(Flapjack meal)
		{
			int i = this.itemsMenu.IndexOf(meal);
			if (i > -1)
			{
				this.itemsMenu.RemoveAt(i);
				this.displaylistMenu.Items.RemoveAt(i);
			}
		}
	}
}

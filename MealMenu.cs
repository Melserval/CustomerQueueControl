using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomerQueueControl
{
	// Перечень блюд в меню.
	// настройка содержимого и управление отображением.
	class MealMenu
	{
		private List<Dish> itemsMenu = new List<Dish>();
		private ListBox displaylistMenu;
		public MealMenu(System.Windows.Forms.ListBox list)
		{
			this.displaylistMenu = list;
		}

		public List<Dish> List => itemsMenu;

		public void Add(params Dish[] meals)
		{
			foreach (Dish meal in meals)
			{
				this.itemsMenu.Add(meal);
				this.displaylistMenu.Items.Add(meal.DisplayName);
			}
		}

		public void Remove(Dish meal)
		{
			int i = this.itemsMenu.IndexOf(meal);
			if (i > -1)
			{
				this.itemsMenu.RemoveAt(i);
				this.displaylistMenu.Items.RemoveAt(i);
			}
		}

		public Dish GetItem(int index)
		{
			return this.itemsMenu[index];
		}

		public Dish GetItem(string name)
		{
			return this.itemsMenu.Find(item => name.Equals(item.DisplayName, StringComparison.OrdinalIgnoreCase));
		}

		public List<Dish> GetMenuList()
		{
			return this.itemsMenu;
		}

		public void SetMenuList(List<Dish> items)
		{
			this.displaylistMenu.Items.Clear();
			this.Add(items.ToArray());
		}

		public void Clear()
		{
			this.itemsMenu.Clear();
			this.displaylistMenu.Items.Clear();
		}
	}
}

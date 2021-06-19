using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomerQueueControl
{
	public partial class Form1 : Form
	{
		// имена файлов сериализации.
		static string dataMenu = "menu.dat";
		static string dataLamb = "lamb.line.dat";

		// список блюд - основное меню.
		private MealMenu mainMealMenu;

		// список-очередь клиентов.
		private Queue<Customer> breakfastLine;

		// количество экземпляров пайка.
		private Dictionary<Dish, int> flapjackOrder;

		// делегаты для операций с очередью клиентов в breakfastLine.


		public Form1()
		{
			InitializeComponent();
			this.flapjackOrder = new Dictionary<Dish, int>();
			this.breakfastLine = new Queue<Customer>();
			this.mainMealMenu = new MealMenu(this.listBox_menu);

			this.openFileDialog_menu.Filter = "JSON |*.json| All Files |*.*";
			this.openFileDialog_customer.Filter = "JSON |*.json| All Files |*.*";
		}

		#region --- методы операций управления очередью клиентов. ---

		// Добавление нового клиента в очередь
		private void lamberEnqueue(Customer lamb)
		{
			this.breakfastLine.Enqueue(lamb);
			this.listBox_customerLine.Items.Add(lamb.Name);
			if (this.breakfastLine.Count == 1)
			{
				this.textBox_currentCustomerName.Text = lamb.Name;
			}
			// включение контролов зависящих от наличия очереди.

			this.listBox_menu.Enabled = true;
			this.button_nextLamberjack.Enabled = true;
		}


		#endregion

		// загрузка сериализованных данных.
		private void loadSerializeData()
		{

			if (File.Exists(dataMenu))
			{

			}

			if (File.Exists(dataLamb))
			{

			}

		}


		// обработка выбора количества пайков.
		private void button_foodNum_addFlapjack_Click(object sender, EventArgs e)
		{
			// очередь пустая - некому выдать паек.
			if (this.breakfastLine.Peek() == null) return;

			// не выбран пункт меню.
			if (this.listBox_menu.SelectedIndex < 0) return;

			int flapCount = int.Parse((sender as Button).Tag as string);

			Dish food = this.mainMealMenu.List.Find(item => item.DisplayName == this.listBox_menu.SelectedItem.ToString());
			if (this.flapjackOrder.ContainsKey(food))
			{
				this.flapjackOrder[food] += flapCount;
			}
			else
			{
				this.flapjackOrder.Add(food, flapCount);
			}
			this.listBox_orderState.Items.Add($"выдано {flapCount} {food.DisplayName}");
		}

		// Добавление (создание) нового клиента из формы.
		private void button_addLamberjack_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_customerName.Text))
			{
				MessageBox.Show("Необходимо ввести имя клиента.");
				return;
			}

			this.lamberEnqueue(new Customer(
				textBox_customerName.Text,
				String.IsNullOrEmpty(textBox_customerDesc.Text) ? null : textBox_customerDesc.Text
			));
			this.textBox_customerName.Clear();
			this.textBox_customerDesc.Clear();
		}

		// Завершение операций с текущим клиентом в очереди.
		private void button_nextLamberjack_Click(object sender, EventArgs e)
		{ // TODO: Нужно разобраться со всем этим - не годится что вся логика в обработчике клика.
			this.textBox_hasFlatjack.Text = null;
			if (this.breakfastLine.Count == 0) return;

			foreach (var currentOrder in this.flapjackOrder)
			{
				this.breakfastLine.Peek().TakeFlapjacks(currentOrder.Key, currentOrder.Value);
			}
			try
			{
				OrderLoger.Save(
					this.flapjackOrder.ToDictionary(element => element.Key.DisplayName, element => element.Value),
					this.breakfastLine.Peek().Name
				);
			} catch	(Exception error)
			{
				MessageBox.Show($"Что то не получилось: {error.Message}");
			}
			this.flapjackOrder.Clear();
			this.breakfastLine.Dequeue().EatFlapjacks(this.textBox_hasFlatjack);
			this.listBox_customerLine.Items.RemoveAt(0);
			this.listBox_orderState.Items.Clear();

			// выключение контролов и очистка полей зависящих от наличия очереди.
			if (this.breakfastLine.Count == 0)
			{
				this.listBox_menu.Enabled = false;
				this.groupBox_buttonSetCount.Enabled = false;
				this.button_nextLamberjack.Enabled = false;
				this.textBox_currentCustomerName.Clear();
			}
			else // если очередь не опустела отображает следующего получателя.
			{
				this.textBox_currentCustomerName.Text = this.breakfastLine.Peek().Name;
			}
		}

		private void button_removeFoodCount_Click(object sender, EventArgs e)
		{
			if (this.listBox_orderState.SelectedIndex < 0) return;
		}

		private void button_addFoodCount_Click(object sender, EventArgs e)
		{
			if (this.listBox_orderState.SelectedIndex < 0) return;

		}


		private void listBox_menu_SelectedIndexChanged(object sender, EventArgs e)
		{
			// если клик был на контейнере, без выбора пункта меню.
			if (this.listBox_menu.SelectedIndex < 0 || 
				this.listBox_menu.SelectedItem == null) return;
			
			// TODO: Нужно переделать поиск экземпляра меню, что бы искать по имени, а не индексу.
			this.groupBox_buttonSetCount.Enabled = true;
			this.textBox_descriptionMenuItem.Text = this.mainMealMenu
				.GetItem(this.listBox_menu.SelectedIndex)
				.Description;
		}


		// Диалог для выбора файла списка блюд меню.
		private void button_loadMenu_Click(object sender, EventArgs e)
		{
			if (openFileDialog_menu.ShowDialog() == DialogResult.OK)
			{
				if (OuterDataLoader.FileMenu(openFileDialog_menu.FileName, out List<Dish> items))
				{
					this.mainMealMenu.Add(items.ToArray());
				}
			}
		}

		// Диалог для выбора файла списка клиентов.
		private void button_loadCustomer_Click(object sender, EventArgs e)
		{
			if (openFileDialog_customer.ShowDialog() == DialogResult.OK)
			{
				if (OuterDataLoader.FileCustomer(openFileDialog_customer.FileName, out List<Customer> items))
				{
					items.ForEach(this.lamberEnqueue);
				}
			}
		}

		// Сохранение данных (сериализация) при закрытии формы.
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			File.WriteAllText("form.log", "Form is deactivated.");
		}

		// Добавление (создание) нового блюда из формы.
		private void button_addDish_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.textBox_dishName.Text))
			{
				MessageBox.Show("Необходимо ввести название блюда");
				return;
			}
			if (String.IsNullOrEmpty(this.textBox_dishPrice.Text) || 
				!double.TryParse(this.textBox_dishPrice.Text, out double price))
			{
				MessageBox.Show("Необходимо указать цену или она имеет неверный формат.");
				return;
			}
			// TODO: Разобраться с преобразованием запятой и настройками локали.

			this.mainMealMenu.Add(
				new Dish(
					this.textBox_dishName.Text,
					price,
					String.IsNullOrEmpty(this.textBox_dishDesc.Text) ? null : this.textBox_dishDesc.Text
				)
			);
			this.textBox_dishName.Clear();
			this.textBox_dishPrice.Clear();
			this.textBox_dishDesc.Clear();
		}
	}
}

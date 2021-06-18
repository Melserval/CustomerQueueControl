using System;
using System.Collections.Generic;
using System.IO;

namespace CustomerQueueControl
{
	class OrderLoger
	{

		public static void Save(string ordersDirPath, string cusname, Dictionary<Dish, int> items)
		{
			try
			{
				StreamWriter sw = new StreamWriter($@"{ordersDirPath}\order_{DateTime.Now.Millisecond}.txt");
				sw.WriteLine("{0} :: {1}{2}{2}", cusname, DateTime.Now.ToString(), Environment.NewLine);
				foreach (KeyValuePair<Dish, int> item in items)
				{
					sw.WriteLine("{0, 3}:{1}", item.Value, item.Key.DisplayName);
				}
				sw.Close();
			}
			catch (Exception e)
			{

				System.Windows.Forms.MessageBox.Show($"Не удалось сохранить заказ. Ошибка: {e.Message}");
			}
		}
	}
}

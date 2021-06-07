using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CustomerQueueControl
{
	// Загрузка данных программы из внешних источников.
	static class OuterDataLoader
	{

		// Список блюд из файла.
		public static bool FileMenu(string fileMenuPath, out List<Dish> items)
		{
			try
			{
				string jsonStr = File.ReadAllText(fileMenuPath);
				items = JsonSerializer.Deserialize<List<Dish>>(
					jsonStr,
					new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
				);
			}
			catch (Exception)
			{

				throw;
			}

			return items.Count() > 0;
		}

		// Загрузка Клиентов из файла.
		public static bool FileCustomer(string fileLambersPath, out List<Customer> items)
		{
			try
			{
				string jsonStr = File.ReadAllText(fileLambersPath);
				items = JsonSerializer.Deserialize<List<Customer>>(
					jsonStr,
					new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
				);
			}
			catch (Exception)
			{

				throw;
			}
			return items.Count() > 0;
		}
	}
}

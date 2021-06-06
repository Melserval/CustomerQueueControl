using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Breackfast_for_Lamberjack
{
	// Загрузка данных программы из внешних источников.
	static class OuterDataLoader
	{

		// Список блюд из файла.
		public static bool FileMenu(string fileMenuPath, out List<Flapjack> items)
		{
			try
			{
				string jsonStr = File.ReadAllText(fileMenuPath);
				items = JsonSerializer.Deserialize<List<Flapjack>>(
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
		public static bool FileCustomer(string fileLambersPath, out List<Lamberjack> items)
		{
			try
			{
				string jsonStr = File.ReadAllText(fileLambersPath);
				items = JsonSerializer.Deserialize<List<Lamberjack>>(
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

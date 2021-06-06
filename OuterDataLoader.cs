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

		/// <summary>
		/// Загрузка Клиентов из файла.
		/// </summary>
		/// <param name="fileLambersPath">путь к файлу</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static bool FileCustomer(string fileLambersPath, out List<Lamberjack> items)
		{
			items = new List<Lamberjack>();
			string temp;
			using (StreamReader lamber_sr = new StreamReader(fileLambersPath))
			{
				while ((temp = lamber_sr.ReadLine()) != null)
				{
					items.Add(new Lamberjack(temp.Trim()));
				}
			}
			return items.Count() > 0;
		}
	}
}

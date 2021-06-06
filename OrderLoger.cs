using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Breackfast_for_Lamberjack
{
	class OrderLoger
	{
		private const string baseOrdersDir =
			@"D:\Projects\HelloC#\Breackfast for Lamberjack\Orders";

		public static void Save(Dictionary<string, int> items, string name)
		{
			string path = String.Format(@"{0}\order_{1}.txt", 
				                     baseOrdersDir, DateTime.Now.Millisecond);

			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine("{0} :: {1}{2}{2}", name, DateTime.Now.ToString(), Environment.NewLine);
			foreach (KeyValuePair<string, int> item in items)
			{
				sw.WriteLine("{0, 3}:{1}", item.Value, item.Key);
			}
			sw.Close();
		}
	}
}

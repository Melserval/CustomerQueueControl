using System;
using System.Windows.Forms;

namespace CustomerQueueControl
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			// это мастер ветка и все изменения пишутся сюда.
			// это значения из сериализабле. 

		}
	}
}

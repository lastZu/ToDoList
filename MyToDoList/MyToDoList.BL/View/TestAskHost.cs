using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.View
{
	public class TestAskHost
	{
		private static TestAskHost Instans { get; set; }
		public static string Name { get; private set; }

		private TestAskHost () {}

		public static TestAskHost CreateAsk()
		{
			if (Instans == null)
				Instans = new TestAskHost();
			Name = null;

			Instans.AskName();

			return Instans;
		}

		private void AskName()
		{
			string nameList;

			Console.WriteLine("Введите имя списка:");
			nameList = Console.ReadLine();
			while (nameList.Equals(""))
				nameList = Console.ReadLine();
			Name = nameList;
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}

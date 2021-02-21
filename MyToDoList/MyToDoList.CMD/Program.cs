using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.BL.Controller;
using MyToDoList.BL.Controller.TestControllers;




namespace MyToDoList.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
			TestHostController hostController;
			int numList;
			int numTask;

			try
            {
				TestHostController[] myPlans = new TestHostController[2];

				hostController = new TestHostController();
				myPlans[0] = hostController;

				hostController = new TestHostController();
				myPlans[1] = hostController;

				Program.Print(myPlans);

				while (true)
				{
					Console.WriteLine("Введите номер списка");
					numList = int.Parse(Console.ReadLine());

					Console.WriteLine("Введите номер задачи \n(0) добавить новую задачу\n(1) Повернуть список");
					numTask = int.Parse(Console.ReadLine());

					if (numTask == 0)
						myPlans[numList].Add();
					if (numTask == 1)
						myPlans[numList].Muve();

					Program.Print(myPlans);
				}
			}
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

		public static void Print(TestHostController[] Plans)
		{
			foreach (var host in Plans)
			{
				Console.WriteLine(host.getName());
				Console.WriteLine("-----------------------------");
				foreach (var task in host.getTasks())
					Console.WriteLine(task.Name);
				Console.WriteLine();
			}
		}
    }
}

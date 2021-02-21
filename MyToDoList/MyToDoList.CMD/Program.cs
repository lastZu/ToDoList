using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.BL.Controller;


namespace MyToDoList.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new UserController(null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}

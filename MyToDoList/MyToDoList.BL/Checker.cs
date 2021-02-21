using MyToDoList.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL
{
    /// <summary>
    /// Класс проверок на не допустимые значения
    /// </summary>
    public class Checker
    {
        /// <summary>
        /// Проверка строки на пустое значение
        /// </summary>
        /// <param name="str">Если строка пустая или Null вызывается Исключение ArgumentException</param>
        public static void CheckProperty(string str)
        {
            if (str == "")
            {
                throw new ArgumentException("Не коректный ввод", nameof(str));
            }
        }

        /// <summary>
        /// Проверка User на пустое значение
        /// </summary>
        /// <param name="user">Если параметр Null вызывается Исключение ArgumentException</param>
        public static void CheckProperty(User user)
        {
            if (user == null)
                throw new ArgumentException("User не задан", nameof(user));
        }
    }
}

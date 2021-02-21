using MyToDoList.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyToDoList.BL.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создаем контроллер и выбираем пользователя
        /// </summary>     
        public UserController (User user)
        {
            Checker.CheckProperty(user);
            User = user;
        }

        public override string ToString()
        {
            return User.ToString() + " Controller";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Save ()
        {
            return false;
        }

        public User Load()
        {
            return new User("");
        }

    }
}

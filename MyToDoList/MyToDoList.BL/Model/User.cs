using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        #region Properties
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Login { get; }
        #endregion

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        public User (string login)
        {
            Checker.CheckProperty(login);
            Login = login;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}

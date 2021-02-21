using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model
{
	/// <summary>
	/// Объект для которого можно создавать списки задач
	/// </summary>
    public interface IClient : IMuvingObject
    {
        string Name { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model
{
	/// <summary>
	/// Основные поля задачи
	/// </summary>
    public struct TaskFields
    {
        public string Name { get; set; }

        public TaskCondition Status { get; set; } 
    }
}

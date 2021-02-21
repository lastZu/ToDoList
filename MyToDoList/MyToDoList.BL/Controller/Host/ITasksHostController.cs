using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.BL.Model;

namespace MyToDoList.BL.Controller
{
	interface ITasksHostController
	{
		/// <summary>
		/// Запускаем создание задачи
		/// </summary>
		/// <param name="taskFields">Структура данных полей задачи</param>
		/// <param name="tasksHost">Объект из которого вызван запрос на создание</param>
		/// <returns>Задача</returns>
		ITaskObject InitializeTaskData(TaskFields taskFields, ITasksHost tasksHost);
	}
}

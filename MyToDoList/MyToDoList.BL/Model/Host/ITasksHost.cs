using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model
{
	/// <summary>
	/// Список задач
	/// </summary>
    interface ITasksHost : IMuvingObject
    {
		/// <summary>
		/// Создать задачу
		/// </summary>
		/// <param name="taskFields">Структура полей задачи</param>
		/// <returns>Возвращает созданную задачу</returns>
		ITaskObject CreateTask (TaskFields taskFields);

		/// <summary>
		/// Удалить задачу
		/// </summary>
		/// <param name="task">Задача</param>
		/// <returns>Результат удаления</returns>
		bool DeleteTask (ITaskObject task);

		/// <summary>
		/// Изменить приоритет задачи в списке
		/// </summary>
		/// <param name="task">Задача</param>
		void ChangePriorityTask(ITaskObject task);
    }
}

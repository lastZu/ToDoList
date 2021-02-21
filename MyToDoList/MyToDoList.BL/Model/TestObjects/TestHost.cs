using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model.TestObjects
{
	public class TestHost : ITasksHost
	{
		public string Name { get; set; }

		public List<TextTask> TaskList { get; }

		public TestHost ()
		{
			TaskList = new List<TextTask>();
		}

		public void ChangePriorityTask(ITaskObject task)
		{
			throw new NotImplementedException();
		}

		public void ChangePriorityTask()
		{
			TextTask temp = TaskList[0];
			TaskList.Remove(temp);
			TaskList.Add(temp);
		}

		public ITaskObject CreateTask(TaskFields taskFields)
		{
			TextTask task = new TextTask(taskFields.Name);
			TaskList.Add(task);

			return (ITaskObject)task;
		}

		public bool DeleteTask(ITaskObject task)
		{
			throw new NotImplementedException();
		}
	}
}

using MyToDoList.BL.Model.TestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.BL.Model;
using MyToDoList.BL.View;

namespace MyToDoList.BL.Controller.TestControllers
{
	public class TestHostController : ITasksHostController
	{
		private TestHost Host { get; set; }

		public TestHostController ()
		{
			Host = new TestHost();
			InitializeTaskData();
		}

		private void InitializeTaskData()
		{
			TestAskHost.CreateAsk();

			Host.Name = TestAskHost.Name;
		}

		public void Add()
		{
			TestAskHost.CreateAsk();
			Host.CreateTask(new TaskFields() { Name = TestAskHost.Name});
		}

		public void Muve()
		{
			Host.ChangePriorityTask();
		}

		public List<TextTask> getTasks()
		{
			return Host.TaskList;
		}

		public string getName()
		{
			return Host.Name;
		}
	}
}

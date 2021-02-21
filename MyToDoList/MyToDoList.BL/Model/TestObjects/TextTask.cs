using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model.TestObjects
{
	public class TextTask : ITaskObject
	{
		public string Name { get; set; }

		public TextTask (string name)
		{
			Name = name;
		}
	}
}

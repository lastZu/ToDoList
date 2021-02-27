using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.BL.Model
{
	class TasksDirector : Director
	{
		public IBilder Bilder { get; set; }

		public void create(string name)
		{
			Bilder.setName(name);
		}
	}
}

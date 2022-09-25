using nilnul.task.proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task._demo
{
	public partial class Project_demo0
	{
		nilnul.task.proj.Project Gen() {
			//first generate some tasks.
			var random=new Random();
			var taskNum=random.Next(5,10);
			var tasks = new Task[taskNum];

			for (int i = 0; i < taskNum; i++)
			{

				tasks[i] = new Task();
				var min = random.Next(1, 9);
				var span = random.Next(1, 9);
				var max = min + span;
				var mod =  random.Next(min+1, max);

				tasks[i].distribution = new prob.dist.inst.Pert(min, mod, max);
			 
			}

			//generate lattice

			Precedences precedenceCollection = new Precedences();
			precedenceCollection.add(tasks[0], tasks[1]);
			precedenceCollection.add(tasks[0], tasks[2]);
			precedenceCollection.add(tasks[0], tasks[3]);
			precedenceCollection.add(tasks[1], tasks[4]);
			precedenceCollection.add(tasks[2], tasks[4]);
			precedenceCollection.add(tasks[3], tasks[5]);
			precedenceCollection.add(tasks[4], tasks[6]);
			precedenceCollection.add(tasks[5], tasks[6]);

			nilnul.task.proj.Project proj = new task.proj.Project();
			proj.precedences= precedenceCollection;



			return new task.proj.Project();
		}

		
	}
}

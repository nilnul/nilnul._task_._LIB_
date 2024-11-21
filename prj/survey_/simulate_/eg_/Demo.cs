using nilnul.num.rational;
using nilnul.task.prj.sample;
using nilnul.task._prj_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.task.prj.survey_.simulate_.eg_
{
	public  class Demo
	{
		static nilnul.task.Prj Gen() {
			//first generate some tasks.
			
			var taskNum=8;
			var tasks = new Duration[taskNum];

			for (int i = 0; i < taskNum; i++)
			{
				tasks[i] = new Duration(i.ToString());
			}

			

			tasks[0].distribution = Duration.CreateDistribution(0);
			//tasks[0].name = "0";

			tasks[1].distribution = Duration.CreateDistribution(2, 5, 14);
			tasks[2].distribution = Duration.CreateDistribution(3, 12, 21);
			tasks[3].distribution = Duration.CreateDistribution(5, 14, 17);
			tasks[4].distribution = Duration.CreateDistribution(2, 5, 8);
			tasks[5].distribution = Duration.CreateDistribution(6, 15, 30);
			tasks[6].distribution = Duration.CreateDistribution(1, 4, 7);
			tasks[7].distribution = Duration.CreateDistribution(0);
			//generate lattice

			Priors precedenceCollection = new Priors();
			precedenceCollection.add(tasks[0], tasks[1]);
			precedenceCollection.add(tasks[0], tasks[2]);
			precedenceCollection.add(tasks[1], tasks[3]);
			precedenceCollection.add(tasks[2], tasks[4]);
			precedenceCollection.add(tasks[2], tasks[5]);
			precedenceCollection.add(tasks[3], tasks[6]);
			precedenceCollection.add(tasks[4], tasks[6]);
			precedenceCollection.add(tasks[6], tasks[7]);
			precedenceCollection.add(tasks[5], tasks[7]);

			nilnul.task.Prj proj = new task.Prj();
			proj.precedences= precedenceCollection;

			return proj;
		}

		static public Prj proj{
			get{
				return Gen();
			}
		}

		public Demo()
		{

		}

		static public IEnumerable< Sample_quotient> Realize(int times) {

			return Sample_quotient.Realize(proj, times);


			
		}

		static public IEnumerable<Rational_InheritFraction> Durations(int times) {

			return Realize(times).Select(c =>  Cpm_quotient.Duration(c));
		
		}
					



		
	}
}

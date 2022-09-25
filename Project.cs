using nilnul.task.proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task.proj
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// a collection of tasks, among which their are relations such as precedence.
	/// </remarks>
	public partial class Project
	{
		public Precedences precedences=new Precedences();

		public Project()
		{

		}

		public Dictionary<Task,double> durations;	//realized

		public Dictionary<Task,double> durationRealized() {
			durations=new Dictionary<Task,double>();
			Random random=new Random();
			;
			foreach (var item in precedences.tasks)
			{
				durations.Add(item,item.distribution.inversePdf(random.NextDouble()));
				
				
			}

			return durations;


		
		}



		public Dictionary<Task, double[]> taskEsEfLsLfSlack;


		public void computeCriticalPath() { 

			//
			Dictionary<Task, double> taskDuration_s;


		
		}

		public List<Dictionary<Task,double>> repeat(uint times) {

			//

			List<Dictionary<Task,double>> durationsOfProj=new List<Dictionary<Task,double>>();
			for (uint i = 0; i < times; i++)
			{
				var durationsRealized=durationRealized();
				durationsOfProj.Add(durationsRealized);

				
			}

			return durationsOfProj;


		
		}


					

	}
}

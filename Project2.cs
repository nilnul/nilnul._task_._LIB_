using nilnul.task._prj_;
using System;
using System.Collections.Generic;

namespace nilnul.task
{
	/// <summary>
	/// each task is <see cref="task.Durant"/>
	/// </summary>
	public  class Prj:prj_.IPensive
	{
		public Priors precedences=new Priors();

		public Prj()
		{

		}

		public Dictionary<Duration,double> durations;	//realized


		/// <summary>
		/// sample
		/// </summary>
		/// <returns></returns>
		public Dictionary<Duration,double> durationRealized() {
			durations=new Dictionary<Duration,double>();
			Random random=new Random();
			;
			foreach (var item in precedences.tasks)
			{
				durations.Add(item,item.distribution.invert(random.NextDouble()));
				
				
			}

			return durations;


		
		}



		public Dictionary<Duration, double[]> taskEsEfLsLfSlack;


		// void computeCriticalPath() { 

		//	//		Dictionary<Duration, double> taskDuration_s;


		
		//}

		/// <summary>
		/// sample many times; survey
		/// </summary>
		/// <param name="times"></param>
		/// <returns></returns>

		public List<Dictionary<Duration,double>> repeat(uint times) {

			//

			List<Dictionary<Duration,double>> durationsOfProj=new List<Dictionary<Duration,double>>();
			for (uint i = 0; i < times; i++)
			{
				var durationsRealized=durationRealized();
				durationsOfProj.Add(durationsRealized);

				
			}

			return durationsOfProj;


		
		}


					

	}
}

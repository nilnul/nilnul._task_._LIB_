using nilnul.task.co_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.task
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="nilnul.task_.IProject"/>, this emphasize that here it is a collection of tasks, among which their are relations such as precedence.
	/// </remarks>
	public interface IPrj:nilnul.task_.IProject {

	}
	public  class Prj:IPrj
	{
		public Deps precedences=new Deps();

		public Prj()
		{

		}

		public Dictionary<Duration,double> durations;	//realized

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

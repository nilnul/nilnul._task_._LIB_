using nilnul.num.rational;
using nilnul.task.co_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rational = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.task.prj
{
	/// <summary>
	/// proj is executed in simulation, such that the duration of task is a definite value
	/// </summary>
	///
	public class Sample_quotient
	{
		public Prj project;

		public TaskDuration[] durations;

		public Rational duration(Duration task) {
			return durations.Where(c => c.task == task).First().duration;
		}

		public IEnumerable<Duration> tasks {
			get {
				return project.precedences.tasks;
			}
		}


		public class TaskDuration {
			public Duration task;

			public Rational duration;

			public void sample() {
				duration=Rational_InheritFraction.ToRational_tillDenominator(task.distribution.inverse(),10000);

			}

			static public TaskDuration Sample(Duration task) {
				var r = new TaskDuration();
				r.task = task;
				r.sample();
				return r;
			}

	


		}

		static public Sample_quotient Realize(Prj proj) {

			var r = new Sample_quotient();
			r.project = proj;
			r.durations = proj.precedences.tasks.Select(c => TaskDuration.Sample(c)).ToArray();
			return r;
			
		}

		static public IEnumerable< Sample_quotient> Realize(Prj proj, int times)
		{

			return System.Linq.Enumerable.Range(0, times).Select(c => Realize(proj));

		}
	}
}

using System.Collections.Generic;
using System.Linq;
using Rational = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.task.prj.sample
{
	public partial class Cpm_quotient
	{
		public class Stats
		{
			public List<Stat> stats;

			public Stats(IEnumerable<Duration> tasks)
			{
				stats = new List<Stat>(tasks.Count());

				foreach (var item in tasks)
				{
					var stat = new Stat();
					stat.task = item;
					stats.Add(stat);
				}
			}

			/// <summary>
			/// set es
			/// </summary>
			/// <param name="task"></param>
			/// <param name="es"></param>
			public void es(Duration task, Rational es)
			{
				var stat = stats.First(c => c.task == task);
				stat.es = es;

			}

			public void slack(Duration task, Rational slack)
			{
				stats.First(c => c.task == task).slack = slack;


			}

			public Rational slack(Duration task)
			{
				return stats.First(c => c.task == task).slack;
			}

			public Stat stat(Duration task)
			{
				return stats.First(c => c.task == task);
			}

			public Rational ef(Duration task)
			{

				return stat(task).ef;

			}

			public void ef(Duration task, Rational es)
			{
				var stat = stats.First(c => c.task == task);
				stat.ef = es;

			}

			public void lf(Duration task, Rational lf)
			{
				var stat = stats.First(c => c.task == task);
				stat.lf = lf;




			}

			public Rational lf(Duration task)
			{
				return stat(task).lf;




			}
			public void ls(Duration task, Rational time)
			{
				var stat = stats.First(c => c.task == task);
				stat.ls = time;


			}
			public Rational ls(Duration task)
			{
				return stat(task).ls;


			}

		}
	}
}

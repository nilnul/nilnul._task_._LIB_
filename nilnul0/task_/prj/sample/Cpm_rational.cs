using nilnul.num.rational;
using nilnul.order;
using nilnul.relation;
using nilnul.task.proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rational = nilnul.num.rational.Rational_InheritFraction;
using Realization = nilnul.task.proj.Realization_rational;

namespace nilnul.task
{
	public partial class Cpm_rational
	{



		public Realization realization;

		public Stats stats;

		public Cpm_rational()
		{
		}
					

		public void compute() {

			stats = new Stats(realization.tasks2);

			_computeEsEf();
			_computeLfLs();
			computeSlack();

			
		}

		public void _statsSet()
		{

			var remainedTasks = realization.tasks2.ToList();

			var stat = new Stat();

			var task = realization.project.precedences.start;

			remainedTasks.Remove(task);

			var duration = realization.duration(task);
			stat.task = task;
			stat.es = new Rational( 0);
			stat.ef = stat.es + duration;


			stats.es(task, ( 0));

			stats.ef(task, duration);

			var subsequensts = realization.project.precedences.subsequents(task);

			var computedTasks = new List<Task>();
			computedTasks.Add(task);

			foreach (var item in subsequensts)
			{
				var precedents = realization.project.precedences.precedents(item);

				var es = precedents.Select(c => stats.ef(c)).Max();

				stats.es(item, es);

				stats.ef(item, es + realization.duration(item));

				computedTasks.Add(item);
				remainedTasks.Remove(item);



			}

			while (remainedTasks.Count > 0)
			{
				foreach (var item in realization.project.precedences.maximal(remainedTasks))
				{
					var precedents = realization.project.precedences.precedents(item);

					var es = precedents.Select(c => stats.ef(c)).Max();

					stats.es(item, es);

					stats.ef(item, es + realization.duration(item));

					//computedTasks.Add(item);
					remainedTasks.Remove(item);

				}

			}




			stats.lf(
			realization.project.precedences.end, stats.ef(realization.project.precedences.end));





			///compute latest end.
			///








			///next find the maximal of the remaining points
			///





		}

		public void setLf(Task task, Rational lf)
		{

			stats.lf(task, lf);
			stats.ls(task, lf - realization.duration(task));

		}

		public Rational duration(Task task)
		{
			return realization.duration(task);
		}

		public void setEs(Task task, Rational es)
		{

			stats.es(task, es);
			stats.ef(task, es + realization.duration(task));

		}

		public void _computeEsEf()
		{


			IEnumerable<Task> minimals = new[] { realization.project.precedences.start };

			setEs(
				realization.project.precedences.start, new Rational(0)
			);

			IEnumerable<Pair<Task>> biggerGraph = realization.project.precedences;

			IEnumerable<Task> minimalNexts = IntransitiveX._MinimalNexts(
				biggerGraph
				,
				minimals
				//new[] { realization.project.precedences.start }
			);

			biggerGraph = IntransitiveX._RemainedArcs2(biggerGraph, minimals);



			while (minimalNexts.Count() > 0)
			{
				minimals = IntransitiveX._Minimals<Task>(biggerGraph as IEnumerable<Pair<Task>>, minimalNexts);

				foreach (var item in minimals)
				{
					setLf(
						item,
						realization.project.precedences.subsequents(item).Select(c => stats.ls(c)).Min()
					);


				}

				var remainedSeep = minimalNexts.Except(minimals);

				var addedSeep = IntransitiveX._MaximalNexts(biggerGraph, minimals);	//there might be some overlapping

				minimalNexts = remainedSeep.Union(addedSeep);	//there might be some overlapping

				biggerGraph = IntransitiveX._RemainedArcs2(biggerGraph, minimals);

			}

		}


		public void _computeLfLs()
		{

			IEnumerable<Task> maximal2 = new[] { realization.project.precedences.end };

			setLf(
				realization.project.precedences.end, stats.ef(realization.project.precedences.end)
			);

			IEnumerable<Pair<Task>> lowerGraph = realization.project.precedences;

			IEnumerable<Task> neximals = IntransitiveX._MaximalNexts(
				lowerGraph, maximal2
			);

			lowerGraph = IntransitiveX._RemainedArcs2(lowerGraph, maximal2);

			while (neximals.Count() > 0)
			{
				maximal2 = IntransitiveX._Minimals<Task>(lowerGraph as IEnumerable<Pair<Task>>, neximals);

				foreach (var item in maximal2)
				{
					setLf(
						item,
						realization.project.precedences.subsequents(item).Select(c => stats.ls(c)).Min()
					);


				}

				var remainedSeep = neximals.Except(maximal2);

				var addedSeep = IntransitiveX._MaximalNexts(lowerGraph, maximal2);	//there might be some overlapping

				neximals = remainedSeep.Union(addedSeep);	//there might be some overlapping

				lowerGraph = IntransitiveX._RemainedArcs2(lowerGraph, maximal2);

			}

		}

		private void setSlack(Task task, Rational slack)
		{

			stats.slack(task, slack);
		}

		public void computeSlack()
		{

			foreach (var item in realization.tasks2)
			{
				setSlack(item, stats.lf(item) - stats.ef(item));

			}


		}




		/// <summary>
		/// another directedIntransitive
		/// </summary>
		public IEnumerable<Pair<Task>> criticalGraph
		{
			get
			{
				return realization.project.precedences.Cast<Pair<Task>>().Where(c => stats.slack(c.first) == 0 && stats.slack(c.second) == 0);


			}
		}

		public IEnumerable<nilnul.relation.Path<Task>> paths() {

			return DirectedX.GetPaths(criticalGraph);
		
		}

		public Rational duration() {

			var firstPath = paths().First();


			return paths().First().nodes.Aggregate((Rational)(0), (a, c) => Rational.Add(a, duration(c)));
		
		}

		static public Rational Duration(Realization_rational realization) {
			var cpm = new Cpm_rational();
			cpm.realization = realization;
			return cpm.duration();
		
		}


		public class Stats
		{
			public List<Stat> stats;

			public Stats(IEnumerable<Task> tasks)
			{
				stats = new List<Stat>(tasks.Count());

				foreach (var item in tasks)
				{
					var stat = new Stat();
					stat.task = item;
				}
			}

			//set
			public void es(Task task, Rational es)
			{
				var stat = stats.First(c => c.task == task);
				stat.es = es;

			}

			public void slack(Task task, Rational slack)
			{
				stats.First(c => c.task == task).slack = slack;


			}

			public Rational slack(Task task)
			{
				return stats.First(c => c.task == task).slack;
			}

			public Stat stat(Task task)
			{
				return stats.First(c => c.task == task);
			}

			public Rational ef(Task task)
			{

				return stat(task).ef;

			}

			public void ef(Task task, Rational es)
			{
				var stat = stats.First(c => c.task == task);
				stat.ef = es;

			}

			public void lf(Task task, Rational lf)
			{
				var stat = stats.First(c => c.task == task);
				stat.lf = lf;




			}

			public Rational lf(Task task)
			{
				return stat(task).lf;




			}
			public void ls(Task task, Rational time)
			{
				var stat = stats.First(c => c.task == task);
				stat.lf = time;


			}
			public Rational ls(Task task)
			{
				return stat(task).ls;


			}

		}




		public class Stat
		{
			public Task task;

			public Rational es;
			public Rational ls;

			public Rational lf;


			public Rational ef;

			public Rational slack;


		}









	}
}

using nilnul.num.rational;
using nilnul.order;
using nilnul.relation;
using nilnul.task.co_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rational = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.task.prj.sample
{
	/// <summary>
	/// after sample, compute the timing of the proj. critical path method
	/// </summary>
	public  class Cpm_quotient
	{
		private Sample_quotient _realization;
		public Sample_quotient realization
		{
			get { return _realization; }
			private set { _realization = value; }
		}

		private Stats _stats;
		public Stats stats
		{
			get { return _stats; }
			private set { _stats = value; }
		}

		public Cpm_quotient(Sample_quotient realization)
		{
			this.realization = realization;
			stats = new Stats(realization.tasks);

			compute();
		}



		private void compute()
		{


			_computeEsEf();
			_computeLfLs();
			_computeSlack();


		}

		private void _statsSet()
		{

			var remainedTasks = realization.tasks.ToList();

			var stat = new Stat();

			var task = realization.project.precedences.start;

			remainedTasks.Remove(task);

			var duration = realization.duration(task);
			stat.task = task;
			stat.es = new Rational(0);
			stat.ef = stat.es + duration;


			stats.es(task, (0));

			stats.ef(task, duration);

			var subsequensts = realization.project.precedences.subsequents(task);

			var computedTasks = new List<Duration>();
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
		}

		private void setLfLs(Duration task, Rational lf)
		{
			stats.lf(task, lf);
			stats.ls(task, lf - realization.duration(task));
		}

		public Rational duration(Duration task)
		{
			return realization.duration(task);
		}

		private void setEsEf(Duration task, Rational es)
		{

			stats.es(task, es);
			stats.ef(task, es + realization.duration(task));

		}

		private void _computeEsEf()
		{
			IEnumerable<Duration> minimals = new[] { realization.project.precedences.start };
			setEsEf(
				realization.project.precedences.start, new Rational(0)
			);

			///all the graph
			IEnumerable<Pair2<Duration>> biggerGraph = realization.project.precedences;

			///minimal subsequents.
			HashSet<Duration> minimalNexts = IntransitiveX._MinimalSubsequents_hashset(
				biggerGraph
				,
				minimals
			//new[] { realization.project.precedences.start }
			);

			///except the start task.
			biggerGraph = IntransitiveX._RemainedArcs3(biggerGraph, minimals);

			while (minimalNexts.Count() > 0)
			{
				///
				minimals = IntransitiveX._Minimals<Duration>(biggerGraph.Select(a => new Pair<Duration>(a.first, a.second)), minimalNexts);

				var minimalsToArray = minimals.ToArray();
				foreach (var item in minimalsToArray)
				{
					setEsEf(
						item,
						realization.project.precedences.precedents(item).Select(c => stats.ef(c)).Max()
					);


				}

				minimalNexts.ExceptWith(minimalsToArray);

				var addedSeep = IntransitiveX._MinimalSubsequents_hashset(biggerGraph, minimalsToArray);    //there might be some overlapping

				minimalNexts.UnionWith(addedSeep);  //there might be some overlapping

				biggerGraph = IntransitiveX._RemainedArcs3(biggerGraph, minimalsToArray);

			}

		}


		private void _computeLfLs()
		{
			IEnumerable<Pair2<Duration>> graph = realization.project.precedences;

			IEnumerable<Duration> maximal2 = new[] { realization.project.precedences.end };


			setLfLs(
				realization.project.precedences.end, stats.ef(realization.project.precedences.end)
			);

			HashSet<Duration> maximalCandidates = IntransitiveX._MaximalNexts_hashset2(
				graph, maximal2
			);


			while (maximalCandidates.Count() > 0)
			{
				graph = IntransitiveX._RemainedArcs3(graph, maximal2);

				maximal2 = IntransitiveX._Maximal<Duration>(graph.Select(a => new Pair<Duration>(a.first, a.second)), maximalCandidates);

				var maximalArray = maximal2.ToArray();

				foreach (var item in maximalArray)
				{
					setLfLs(
						item,
						realization.project.precedences.subsequents(item).Select(c => stats.ls(c)).Min()
					);


				}

				maximalCandidates.ExceptWith(maximalArray);

				var addedSeep = IntransitiveX._MaximalNexts_hashset2(graph, maximalArray);  //there might be some overlapping

				maximalCandidates.UnionWith(addedSeep);
				//there might be some overlapping

				graph = IntransitiveX._RemainedArcs3(graph, maximalArray);

			}

		}

		private void _setSlack(Duration task, Rational slack)
		{

			stats.slack(task, slack);
		}

		private void _computeSlack()
		{

			foreach (var item in realization.tasks)
			{
				_setSlack(item, stats.lf(item) - stats.ef(item));

			}


		}


		/// <summary>
		/// another directedIntransitive
		/// </summary>
		public IEnumerable<Pair<Duration>> criticalGraph
		{
			get
			{
				return realization.project.precedences.Cast<Pair<Duration>>().Where(c => stats.slack(c.first) == 0 && stats.slack(c.second) == 0);


			}
		}

		public IEnumerable<Pair2<Duration>> criticalGraph2
		{
			get
			{
				return realization.project.precedences.Cast<Pair2<Duration>>().Where(c => stats.slack(c.first) == 0 && stats.slack(c.second) == 0);


			}
		}

		public IEnumerable<Path2<Duration>> paths()
		{
#if DEBUG
			return DirectedX.GetPaths(criticalGraph2).Select(c => new Path2<Duration>(
					c
					//,
					//new nilnul.FuncAsEqualityComparer2<Task2>(
					//	(x, y) => x.name == y.name
					//)
				)
			).ToArray();  //.Select(c=>new Path<Task2>(c));
#else
			return DirectedX.GetPaths(criticalGraph2).Select(c=>new Path2<Duration>(c));	//.Select(c=>new Path<Task2>(c));
#endif
		}

		public Rational duration()
		{

#if DEBUG
			var firstPath = paths().First();

#endif


			return paths().First().nodes.Aggregate((Rational)(0), (a, c) => Rational.Add(a, duration(c)));

		}

		static public Rational Duration(Sample_quotient realization)
		{
			var cpm = new Cpm_quotient(realization);
			//cpm.realization = realization;

			var stats = Cpm_quotient.Create(realization);

			return cpm.duration();

		}

		static public Cpm_quotient Create(Sample_quotient realization)
		{
			var cpm = new Cpm_quotient(realization);
			cpm.compute();
			return cpm;
		}



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

			//set
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
		public class Stat
		{
			public Duration task;

			public Rational es;
			public Rational ls;

			public Rational lf;


			public Rational ef;

			public Rational slack;


		}
	}
}

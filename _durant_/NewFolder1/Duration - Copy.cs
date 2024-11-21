using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.prob.dist.inst;

namespace nilnul.task
{
	/// <summary>
	/// for an action: do,
	///		we use "doing" to express the action "do" takes some time
	/// </summary>
	/// <remarks>
	/// This is a task. it doesn't care about the relation about tasks, such as whether two tasks are the same.
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.task.Durant))]
	public  class Duration
		:
		task.Durant
		,
		IEquatable<Duration>
		,
		task.IDurant

	{
		//public string name;

		//public nilnul.stat.dist_.borel_.Invertible4dblI  distribution;


		public nilnul.stat.dist_.borel_.Invertible4dblI distribution
		{
			get { return base.duration; }
			set { base.duration = value; }
		}


		public Duration():base()
		{
		}
					

		public Duration(string name):base(name)
		{
			//this.name = name;
		}


		public bool Equals(Duration other)
		{
			return this == other;
		}

		//public override string ToString()
		//{
		//	return this.name;
		//}

		//static public nilnul.stat.dist_.borel_.Invertible4dblI CreateDistribution(
		//	double min, double mod, double max
		//)
		//{
		//	return new nilnul.stat.dist_.borel_.pdfable_.beta_.Pert4dbl(min, mod, max);

		//}
		//static public nilnul.stat.dist_.borel_.Invertible4dblI CreateDistribution(
		//	double const_
		//)
		//{
		//	return new nilnul.stat.dist_.borel_.discrete_.finite_.Definite4dbl (const_);

		//}








	}
}

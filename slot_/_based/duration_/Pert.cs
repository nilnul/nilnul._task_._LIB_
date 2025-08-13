using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.prob.dist.inst;

namespace nilnul.task.duration_
{
	/// <summary>
	/// not only <see cref="IBound"/>, but we also have a modal duration;
	/// </summary>
	/// <remarks>
	/// This is a task. it doesn't care about the relation about tasks, such whether two taks are the same.
	/// </remarks>
    public  class Pert0
		:IEquatable<Pert0>
    {
		public string name;

		public Pert distribution;



		public bool Equals(Pert0 other)
		{
			return this==other;
		}

		
	}
}

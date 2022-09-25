using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = nilnul.task.Duration;

namespace nilnul.task.co_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		precedence
	///		dependence
	/// </remarks>
	public partial class Dep
		:Pair2<Duration>

	{
		

		public Dep(Duration a,Duration b)
			:base(a,b)
		{
			
		}
					

	}
}

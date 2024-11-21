using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = nilnul.task.Duration;

namespace nilnul.task._prj_
{
	/// <summary>
	/// the second task cannot begin until the first task has been finished;
	/// </summary>
	/// <remarks>
	/// alias:
	///		precedence
	///		dependence
	/// </remarks>
	/// 
	public  class Prior
		:Pair2<Duration>
		,
		nilnul.task.co_.IPrior

	{
		

		public Prior(Duration a,Duration b)
			:base(a,b)
		{
			
		}
					

	}
}

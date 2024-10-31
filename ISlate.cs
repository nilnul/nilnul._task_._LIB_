using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task
{
	/// <summary>
	/// associate task with <see cref="nilnul.time.ext.bounds"/> or <see cref="nilnul.time0nul.bounds"/>;
	/// the bounds can be 
	/// </summary>
	/// <remarks>
	/// for past tasks, this is the recorded reified actual time; for future ones, this is the planned time;
	/// </remarks>
	/// alias:
	///		slate
	///			, related to slack;
	///		schedule
	///		chart
	///		event
	///		chronometer
	///	the default is <see cref="slate_.slot.IRecur"/>
	/// 
	public interface ISlate
	{
	}

	/// <summary>
	/// the cardinality of slates is finite;
	/// but the <see cref="slate.ISlots"/> can be infinite.
	/// </summary>
	interface ISlates { }



	
}

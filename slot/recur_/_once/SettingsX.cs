using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slot.recur_._once
{

	/// <summary>
	/// we schedule the todo unscheduled as a deferrable once recurring task in a specific slot of the day: early in the morning.
	/// </summary>
	/// 
	/// vs:
	///		<see cref="task.slate.chron_._eg.Li_.Coupon"/>, the tasks of which are usually schedule as dayful.

	static public class SettingsX
	{
		/// <summary>
		/// begin time of the day
		/// </summary>
		/// value:
		///		2:00? such the tasks are not cramped
		///		3:00? clear from previous day leftover, but cramped between the available bound
		static public TimeSpan Begin { get { return Settings1.Default.basis; } }
		static public TimeSpan Until { get { return Settings1.Default.until; } }

	}
}

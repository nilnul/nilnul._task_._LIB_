using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate_.slot_.thence_
{
	/// <summary>
	/// per google calendar, we cannot define a task without state date or end date.
	/// but we can define a special slate with a special time period to imitate that:
	///		in google, start and end can be a date, not a datetime. and we can set the start date as a recent date (less than or equal to today), and the end date as null or maximum. For such slate, we can think it as task not scheduled yet, waiting to be scheduled.. and we can periodically, thru auto process, push the start date to tomorrow, avoiding clutter today's schedule.
	/// </summary>
	/// <remarks>
	/// always push to the day after tomorrow, or tomorrow, or weekends?
	///
	/// as sometimes we forgot to defer, the task's start day might be past. 
	/// </remarks>
	/// alias:
	///		unscheduled
	///		wait4schedule.
	///		wait
	///		
	///		
	internal class Deferable
	{
	}
}

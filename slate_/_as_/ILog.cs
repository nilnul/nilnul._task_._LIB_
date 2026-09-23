using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate_._as_
{
	/// <summary>
	/// task acts not only as todo, but also as a log of what has been done. 
	/// as a log of past events, it can:
	///		: index the tasks inherently by time, so that we can query the past events by time.
	///		: backup such that the data can be restored if the system is damaged.
	///		: buffer, such that events can be booked sequentialy thus fast, in .xec format, and then later on we can extract xElement in the .xec to update data.
	///		: insurance of transactional: the log acts as a plan, laying out what to do and what to reinstate, predrafting a retreat path, if something goes wrong. 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	internal class ILog
	{
	}
}

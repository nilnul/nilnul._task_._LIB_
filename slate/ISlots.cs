using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate
{
	/// <summary>
	/// in google calendar, this is called instances;To see all the instances of a given recurring event you can use the events.instances() request.
	/// </summary>
	/// <remarks>
	///Individual instances are similar to single events. Unlike their parent recurring events, instances do not have the recurrence field set.
	///The following event fields are specific to instances:
	///recurringEventId — the ID of the parent recurring event this instance belongs to
	///originalStartTime — the time this instance starts according to the recurrence data in the parent recurring event. This can be different from the actual start time if the instance was rescheduled. It uniquely identifies the instance within the recurring event series even if the instance was moved.
	/// </remarks>
	/// 
	/// 
	internal class ISlots
	{
	}
}

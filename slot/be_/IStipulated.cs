using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slot.be_
{
	/// <see cref="attr_.IScheduleStipulated"/>
	/// <summary>
	/// 
	/// stipulated to begin since some time, and end before some time.
	/// longer than or equal to actual duration. if the actual slot exceeds this, then it's considered an exception and calls for the attention from the task managing.
	/// </summary>
	/// <remarks>
	///  over time, the actual slot is more and more specific. In that case we can adjust the slot. The old stipulated slot can be kept in the note or extended attrs.
	///  
	/// because slot has to be adjusted dynamically, then the stipulated slot has to be stored in the extended note or attrs.
	/// </remarks>
	internal class IStipulated
	{
	}
}

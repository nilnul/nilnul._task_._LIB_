using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate_
{
	///
	/// <summary>
	/// the slate is a collection of slots;
	/// for <see cref="nilnul.task.svr_.Google"/>, the recurring task can be regarded as one taks with multiple slots. But the recurring must follow a preset pattern, not possible for arbitrary slots such as morning shift and afternoon shift.
	/// </summary>
	/// 
	/// <remarks>
	/// useful when a task needs a reminder (which might be a notice to others), which is also a task;
	/// </remarks>
	/// 
	/// vs:	<see cref="task.slate_.slot.seq_.IRecur"/>, where the slot follows a recurring pattern hence the duration each is the same, whileas here the period can be arbitrary;
	internal class ISlots
	{
	}
}

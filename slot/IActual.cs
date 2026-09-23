using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slot
{
	/// <summary>
	/// the slot is initially specified within a period of time. eg: for some policy/legal requirement.
	/// The actual is finished before the specified deadline.
	/// ;we have two ways to handle such situation:
	///		1) by two related slot: one is the specified, the other is the actual.
	///		2) by a slot where the specified interval is stored in note/somewhere, and the actual is the slot's start and end.
	///	; the two are equivalent in that they can be converted into each other without loss of information.
	///	; we prefer the 2nd way as it will remove completed task which shall not distract us.
	/// </summary>
	/// <remarks>
	/// after all, slot is for the actual time we use to see what's still to be done
	/// </remarks>
	internal class IActual
	{
	}
}

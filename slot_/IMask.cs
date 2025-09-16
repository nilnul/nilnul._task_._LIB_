using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slot_
{
	/// <see cref="slot.be_.IStipulated"/>
	/// <summary>
	/// for a task's <see cref="task.duration"/>, we gave enough period of time for it; that is a bigger period of time.
	/// the duration can be stored in the note, or in the attrs (eg: google task extended attrs)
	/// </summary>
	/// <remarks>
	/// the actual beginning time will be known later; and at that time, we can adjust the mask's start. Before we give the start a new value, maybe we can store the old value somewhere like in the attrs, or in the note; the old value might be stipulated by the demand from the management or from a decree.
	/// The actual ending time can also be adjusted. and old de jure time can also be stored somewhere like the note or the attrs (extended as a dict).
	/// 
	/// </remarks>
	internal class IMask
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate_
{
	/// <summary>
	/// takes no or infinitesimal time.
	/// as <see cref="nilnul.time.bound_.IClopen"/> allows no empty, we may need a boolean value attached to it.
	/// </summary>
	/// <remarks>
	/// used for, say, <see cref="task_.IEmpty"/>
	/// </remarks>
	/// alias:
	///		mark
	///		<see cref="task_.IEmpty"/>
	internal class IMilestone
		:ISlot
	{
	}
}

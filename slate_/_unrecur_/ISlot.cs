using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate_
{
	/// <summary>
	/// the slate is a single slot, a typical case, not many slots.
	/// </summary>
	/// <remarks>
	/// this is a time.ext.bound to allow for [start, infinite] syntax, or in other words, simply a start time and no end time;
	/// </remarks>
	/// <see cref="nilnul.task.ISlot"/>
	/// alias:
	///		unrecur
	///		
	[Obsolete(nameof(slate_.IUnrecur))]
	public interface ISlot:task.ISlot
	{
	}
}

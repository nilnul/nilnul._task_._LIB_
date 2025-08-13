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
	public interface ISlot:task.ISlot
	{
	}

	public class Slot
	{
		public string summary;
		public string description0nul;
		public DateTimeOffset start;
		public DateTimeOffset end;

		public Slot(
			string summary
			,string description0nul
			,DateTimeOffset start
			, DateTimeOffset end
		)
		{
			this.summary =/*global::*/summary;
			this.description0nul = description0nul;
			this.start = start;
			this.end = end;
		}
		public Slot(
			string summary
			,DateTimeOffset start
			, DateTimeOffset end
		):this(summary,null,start,end)
		{
			
		}

		public Slot(string s):this(s, DateTimeOffset.MinValue, DateTimeOffset.MaxValue)
		{
				
		}





	}
}

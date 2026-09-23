using System;

namespace nilnul.task.slate_
{
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

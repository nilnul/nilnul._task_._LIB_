using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task._remind.alarm.repeat
{
	/// <summary>
	/// Example:  A trigger set 15 minutes prior to the start of the event or      to-do.
	///		TRIGGER:-PT15M
	///		
	/// eg: A trigger set five minutes after the end of an event or the due	date of a to-do.
	/// TRIGGER;RELATED=END:PT5M
	/// 
	/// eg:      A trigger set to an absolute DATE-TIME.
	/// TRIGGER;VALUE=DATE-TIME:19980101T050000Z
	/// </summary>
	internal class ITrigger
	{
	}
}

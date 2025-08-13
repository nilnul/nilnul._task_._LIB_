using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate.attr_
{
	/// <summary>
	/// eg: for lunisor events such as birthday, once a slate is being past, next slate is generated with the same recurring rule that's going to generated subsequent ones.
	/// </summary>
	/// <remarks>
	/// the value is a function:
	///		(history of this event, including it's current event) => procedure to regenerate, such as:
	///		
	///		Calendar=Lunisolar; Freq=Yearly; Day=1; ByMonth=11
	///		
	///		, like an <see cref="nilnul.time.seq_.ical_._rfc.clauz_._RruleX"/>
	///		, which gives us the arguments that the renew method calls for;
	/// </remarks>
	internal class IRenew
	{
	}

	
}

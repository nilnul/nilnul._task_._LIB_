using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task_.intraday_
{
	/// <summary>
	///  a <see cref="task_.IMask"/> which marks all the previous tasks have been finished. 
	///  The title of this can be:
	///		### sealed ###
	///	;
	///	As time goes forward, we can move this task manually or automatically intra the day, possibly overtake more tasks that have been done on the move, to see whether it's consistent with the current time, in anticipation that as time passes, all previous task shall be done, or deferred.
	/// </summary>
	internal class ICarryForward
	{
	}
}

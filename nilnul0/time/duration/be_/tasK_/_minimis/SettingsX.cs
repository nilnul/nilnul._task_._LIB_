using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration.be_.tasK_._minimis
{
	static public class SettingsX
	{
		/// <summary>
		/// <see cref="TimeSpan.TicksPerMinute"/>
		/// ;
		/// can be 0
		/// ,or positive.
		/// 
		/// type int hints that the number or time cannot be too long. 	(less than 5minutes)
		/// </summary>
		/// <remarks>
		/// <see cref="System.Random"/> allows only int;
		/// </remarks>
		/// 
		static public int TicksMax {
			get{
				return nilnul.task.nilnul0.time.duration.be_.tasK_._minimis.Settings1.Default.ticks;
#if DEBUG
 				return 600000000;

#endif
			}
		}
	}
}

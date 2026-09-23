using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._time.clock_.tasK_
{
	static public class _DailyX
	{
		/// <summary>
		///  a dinner for family, when a talk and sync up is needed.
		/// </summary>
		/// alias:
		///		dine, like wine
		static public TimeSpan Dine = new TimeSpan( 19,10,0);

		/// <summary>
		/// this is the time to verify the job, filling gaps if any.
		/// </summary>
		/// this is not made readonly, as we may consider in the future to fetch value from configuration.
		/// alias:
		///		taper
		///		tonedown
		///		scaledown
		///		tidy
		///		vet
		///		review
		///		recap
		///		verify
		///		ramify
		///		reinforce
		///			,reinForce
		static public TimeSpan Reinforce = new TimeSpan( 21,0,0);

 		/// <summary>
		/// this is the time to end up all the commercial work, family chore, and to begin winding up personal duties like repaying loans.
		/// 21 clock is the final ending time for office or classroom.
		/// we allow a 30 minutes period on the commutes.
		/// </summary>
		/// alias:
		///		settle
		static public TimeSpan Clear = new TimeSpan( 21,30,0);

		/// <summary>
		/// this is the time for task that is not to be done personally, but to be left|delegated to scheduled automatic operation in some App, like the auto payback in financial apps for credit card bill.
		/// In other words, those are tasks for one to oversee/monitor/followup, verifying the result, rather than to do.
		/// </summary>
		/// <remarks>
		/// these tasks can be reviewed the next day. Thus, the <see cref="nilnul.task_.daily_"/>
		/// </remarks>
		/// alias:
		///		oversight
		///		seeoff
		///		seeThru
		///		
		///		

 		static public TimeSpan Leave = new TimeSpan( 
			23		/// or 22; but 23 would leave more gap from previous one.
			,0,0);

	}
}

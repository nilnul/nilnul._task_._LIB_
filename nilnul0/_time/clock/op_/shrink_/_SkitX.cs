using nilnul._time;
using System;

namespace nilnul._time.clock.op_.shrink_
{
	/// <summary>
	///  when the latter task is scheduled, it's deferred for a small margin, proportional to the former task within the day.
	///  This way, it keeps the track of the former task.
	///  If there is no former task, then the current clock (when the task is built in program now) is used
	/// </summary>
	/// <remarks>
	/// usually we take the END time of the preceding task, such that its duration is skittable. So, we apply the skit on the BEGIN time of the ending task. Afterall, it's an  endBeforeBegin relation.  the skit can be based on the current clock of the day.
	/// on top of this, the duration can be perturbed by an intrinsic property, such as the summary of the vent, so that it acts as a digital signature cross checkable by these two properties
	/// </remarks>
	/// alias:
	///		skit
	///		skid
	///		skitter
	///	
	/// vs:
	///		<see cref="time.elapse_.tasK_._AberrateX"/> is to randomzie a unique value for a former task.
	static public class _SkitX
	{
		/// <summary>
		/// shrink the clock of the prev task within a given a range, to skid the latter task, such that the latter will not be scheduled clutterly for former tasks that is a little apart
		/// </summary>
		/// <remarks>
		/// unrandomized to keep track of the previous time.
		/// </remarks>
		/// <param name="ticks">
		/// lt <see cref="TimeSpan.TicksPerDay"/>
		/// </param>
		/// <param name="rangeAsMinutes"></param>
		/// <returns></returns>
		static public long _Skitter_0clockTicks(
			long ticks /// the ticks per day is long
			,
			int rangeAsMinutes=5
		)
		{
#if DEBUG  
			//const int ticksPerDay=
			//	//TimeSpan.TicksPerDay
			//	864000000000; /// confirm that 
			const int ticksPerMin=  600000000; /// confirm that ticksPerMin is int;
 			//const int ticksPerMins=  30_00000000; /// confirm that like 5mins is int in ticks?
#endif

			return (


	 ticks        *rangeAsMinutes* TimeSpan.TicksPerMinute
	 / TimeSpan.TicksPerDay

 ) ;
		}

		/// <summary>
		///  shrink a clock of the day to a fraction of a range.
		/// </summary>
		/// <param name="clockPrev"></param>
		/// <param name="rangeAsMinutes">
		/// ticks per second is 10^7
		/// , ticks per minute is 60*10^7
		/// ,ticks per 5 minutes is 300*10^7 = 3000 * 10^6 = 3*10^9, near 4 billion.
		/// </param>
		/// <returns></returns>
 		static public TimeSpan Skitter(
			TimeSpan clockPrev
			,
			int rangeAsMinutes=5
		)
		{
			return TimeSpan.FromTicks(
							  _Skitter_0clockTicks(
								  clockPrev.Ticks,rangeAsMinutes
								  )

	

 ) ;
		}


 		static public TimeSpan Skitter(
			
			int rangeAsMinutes=5
		)
		{
			return  Skitter(DateTime.Now.TimeOfDay, rangeAsMinutes) ;
		}
	

	}
}

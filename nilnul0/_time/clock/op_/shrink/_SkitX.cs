using nilnul._time;
using System;
using System.Security.Cryptography;

namespace nilnul._time.clock.op_.shrink
{
	/// <summary>
	///  increment(or decremental?) a little on basis of the shrink
	/// </summary>
	/// alias:
	///		
	static public class _AberrateX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="clockPrev">
		/// 
		/// </param>
		/// <param name="rangeAsMinutes">
		///  the range in minutes proportional to a day
		/// </param>
		/// 
		/// <returns>
		///  can be also negative, if the <see cref="time.elapse_.tasK_._AberrateX"/> is generated as negative, and the former happens early in the day
		///   ; usually if we use shrink, we don't use <see cref="time.elapse_.tasK_._AberrateX"/>, which is for a former task, while shrink is used for a task that follows the former one.
		///   This is unfavored also cuz 5mintutes is not int but long in ticks
		/// </returns>
		/// 
  		static public long Aberrate(
			long clockPrev
			,
			int rangeAsMinutes=5
		)
		{
			var timeSpan = op_.shrink_._SkitX. _Skitter_0clockTicks(clockPrev, rangeAsMinutes);

			/// the ticks in day is not int.
			
			new Random().nextl
			
			return (  
				nilnul._stat._RndX.RANDOM.Next(	 
					
				timeSpan
			));


			//return timeSpan + nilnul.time.elapse_.tasK_._AberrateX.Randomize();
		}
		static public TimeSpan Aberrate(
			TimeSpan clockPrev
			,
			int rangeAsMinutes=3
		)
		{
			TimeSpan timeSpan = Skitter(clockPrev, rangeAsMinutes);
			var ticksMax = (int)	/// the ticks in day is not int.
				timeSpan.Ticks
			;
			return TimeSpan.FromTicks(  
				nilnul._stat._RndX.RANDOM.Next(	 
					-ticksMax
					,
				ticksMax
			));


			//return timeSpan + nilnul.time.elapse_.tasK_._AberrateX.Randomize();
		}


	}
}

using System;

namespace nilnul.time.elapse_.tasK_
{
	/// <summary>
	///  ; so here is the aberration that does not affect the order. hence it's very small
	/// </summary>
	/// <remarks>
	///  note: vs<see cref="_time.clock.op_.shrink_._SkitX"/>: a consequent task would only increase(not decrease) its specified start time, in order to keep the order of the precedent.
	/// 
	/// </remarks>
	/// alias:
	///		  deMinimis,<see cref="nilnul._time.clock.op_.shrink_."/>
	static public class _AberrateX
	{

		/// <summary>
		/// [-max, max).
		/// that is: negative(ge -max),0 or positive(lt max)
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <returns></returns>
		static public TimeSpan Randomize() {
			int ticksMax = nilnul.time.duration.be_.tasK_._minimis.SettingsX.TicksMax;
			return TimeSpan.FromTicks(  
				nilnul._stat._RndX.RANDOM.Next(	 
					-ticksMax
					,
				ticksMax
			));

		}

	}
}

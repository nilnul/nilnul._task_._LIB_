using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.time.duration.of_.tasK_
{
	/// <summary>
	/// given a duration as the input, 	taking it as the min, and add a random unnegtive finite vavlue, resulting a new duration that is no less than the given, and no more than the given upper limit.
	/// the distribution can be PERT, a Beta distribution.
	/// </summary>
	/// alias:
	///		perturb
	///			,used for a given duration
	///		Aberrate
	///		abberate
	///		aberrant
	///		Aberrationally 
	///		
	static public class _AberrateX
	{
		static byte[] _GetHash(string inputString)
		{
			using (HashAlgorithm algorithm = SHA256.Create())
			{
				return algorithm.ComputeHash(Encoding.UTF32.GetBytes(inputString));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="inputString">
		/// eg:
		///		the title of an event
		/// </param>
		/// <param name="ticks">
		/// the range of the distribution
		/// </param>
		/// <returns>
		/// [0, <paramref name="ticks"/>)
		/// </returns>
		/// alias:
		/// 

		static public TimeSpan Aberrant(string inputString, long ticks = TimeSpan.TicksPerMinute*5)
		{
			byte[] bs = _GetHash(inputString);

			var num = new BigInteger(bs);

			var mod = num% (ticks);

			return TimeSpan.FromTicks(
				(long)mod
			);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	static public class _TaskX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_memo"></param>
		/// <param name="titleCapacity">
		/// default:38, cuz two lines are displayed in google calendar.each line is 19
		/// </param>
		/// <returns></returns>
		///
		[Obsolete(nameof(nilnul.txt0nul.co_.txt9nulable.of_._DichX._Of_0note))]
		static public (string summary, string? description0nul) _Of_0memo(string _memo, int titleCapacity=38) {


			return nilnul.txt0nul.co_.txt9nulable.of_._DichX._Of_0note(_memo,titleCapacity);


			var split=_memo.TrimStart().Split(new[] { '\n', '\r' },2);

			// we need to remove some blank lines;

			var line1st = split[0];

			if (line1st.Length>titleCapacity)
			{

				return (line1st.Substring(0,titleCapacity-3) + "…", _memo);
			}
			if (split.Length ==1)
			{
				return (line1st, null );

			}
			return (line1st, split[1] );
		}
	}
	public class Task2do
		:TaskI
	{

		
		

		public string note
		{
			get
			;
			set
			;
		}

		public Task2do(string description)
		{
			this.note = description;

		}




		
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.job_.mark_
{
	/// <summary>
	/// used in a chronical to indicate that all the previouse tasks have been seald as the history.
	/// </summary>
	/// <remarks>
	/// span le 1minutes; titled like "###sealed###"
	/// </remarks>
	/// alias:
	///		review
	///		inventroy
	///		assess
	///		savepoint
	///		commit
	///		stocking
	///		carryover
	///		carry on
	///		epoch
	///		epic
	///		era
	///		legend
	///		seal
	///		forge
	///		close
	///		carry forward
	///		enclose
	///		shut
	///		mothball
	///		封存
	///		
	internal class ISeal
	{
	}

	static public class _SealX
	{
		public const string LEADING = "###";
		public const string LEADING_SPACED = LEADING + " ";


		static public string Title_0core(string core) {
			//return nilnul.txt.op_.unary_.
			return  $"{LEADING}{core}{LEADING}";
		}
	}
}

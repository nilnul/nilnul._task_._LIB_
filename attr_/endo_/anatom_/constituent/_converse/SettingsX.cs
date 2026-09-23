using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.attr_.endo_.anatom_.constituent._converse
{
	static public class SettingsX
	{
		/// <summary>
		///  from B.part =A, here goes A.federal = B
		///  A is part of B, B is federal of A
		/// </summary>
		/// <remarks>
		/// this can be used as the <see cref="nilnul.obj._prop_.ILabel"/> for all the subtasks like in eg:
		///		Federation: constituent1,,constituent,no 2
		///		,where "Federation" is capitalized
		///		, ",," the longest consecutive commas are taken as the separator 
		/// </remarks>
		/// alias:
		///		isPartOf
		///		hasFederalAs
		///			,just like <see cref="nilnul.obj.be_.IIs"/> deduces <see cref="nilnul.objs.be_.IHas"/> as the converse
		///		federal
		///		
		///		
		static public string Key { get { return Settings1.Default.key; } }

		static public string KeyCapitalized { get {
				return nilnul.txt.op_.scule_._CapitalX.Capital(Key);
			} }


	}
}

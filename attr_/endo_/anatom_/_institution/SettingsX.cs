using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.attr_.endo_.anatom_._institution
{
	static public class SettingsX
	{
		/// <summary>
		///		A.whole=B means A is component of B
		///		,and B is the whole, A is the component.
		/// </summary>
		/// <see cref="nilnul.task.slate.vs_._EncompassX.MEMBER_KEY"/>
		/// alternative:
		///		container
		///		central
		///		org
		///		system
		///		entity
		///		unit
		///		class
		///		whole
		///		
		///		
		static public string Key { get { return Settings1.Default.key; } }
	}
}

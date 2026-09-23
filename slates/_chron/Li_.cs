using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slates._chron
{
	public enum Li_
	{
		/// <summary>
		/// defaulted
		/// </summary>
		/// <remarks>
		/// to hold any task that is not categorized explicitly
		/// </remarks>
		Main
			,
		/// <summary>
		/// often relevant for a period of time, but ignorable once that time has passed.
		/// </summary>
		/// alias:
		///		contextual
		///		transient 
		///		present
		///		current
		///		
		Context
			,
		Family
			,
		Living
			,
		Biz
			,
		Finance
			,
		/// <summary>
		/// any discount when purchasing
		/// </summary>
		Coupon
			,
		Contact
			,
		/// <summary>
		/// for the kids; the owner of the chron is the chaperon of those kids
		/// </summary>
		/// alias:
		///		kid
		///		kids
		Kid
			,
		Kid_
			,
		Org_
			,
		/// <summary>
		/// for a particular project
		/// </summary>
		Prj_
			,
		/// <summary>
		/// for tasks that are cancelled before being started
		/// </summary>
		/// vs:
		///		done
		///		aborted
		Cancelled
			,
		/// <summary>
		/// deleted slates will be discarded here
		/// </summary>
		/// 
		Discarded

			,
		Log


	}
}

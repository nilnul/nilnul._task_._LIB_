using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task._resources
{
	internal enum Li_
	{
		Time
			,
		Human
			,
		/// <summary>
		/// the space to hold things
		/// </summary>
		/// <remarks>
		/// address on a map;
		/// </remarks>
		Venue
			,
		/// <summary>
		/// materials, raws, objects,things, documentations;
		/// </summary>
		/// including venue.
		Thing
			,
		/// <summary>
		/// finance
		/// </summary>
		Money
			,
		/// <summary>
		/// for eample to provide some passcodes;
		/// </summary>
		/// alias:
		///		info
		///			=data+prog=app=rsc+usr
		///		comm
		///		data
		/// 
		Data
	}
}

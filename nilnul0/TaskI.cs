using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.time;

namespace nilnul
{
	/// <summary>
	/// something to do.
	/// </summary>
	/// <remarks>
	/// alias:
	///		todo
	/// </remarks>
	public interface ITask {

	}
	public	interface TaskI:ITask
		//:IElement
	{
		//TimeI plannedStartTime
		//{
		//	get;
		//	set;
		//}

		string note
		{
			get;
			set;
		}


	}
}

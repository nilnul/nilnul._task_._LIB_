using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.be_.ended_.uncomplish_
{
	/// <summary>
	/// the task is cancelled before it's started .
	/// no efforts are made to start the task.
	/// </summary>
	/// <remarks>
	/// shall be discarded into the chron:cancelled; and we can use whether it's in <see cref="task.slate.chron_.ICancelled"/> to determine whether it's <see cref="task.be_.ended_.uncomplish_.ICancelled"/>
	/// </remarks>
	/// alias:
	///		unscheduled
	///		cancelled
	///		unattended
	///		disregard
	///	;
	///	vs:
	///		set noexec on
	///			,in tsql
	///;
	///vs:
	///	unbegun:<see cref="be_.IBegun"/>
	internal class ICancelled
	{
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task_
{
	/// <summary>
	/// an empty task; just a place holder, a nominal one; do nothing;
	/// </summary>
	/// <remarks>
	/// note this is an empty task, not empty slate. Hence it can be <see cref="task.ISlate"/> into a nontrivial duration.
	/// </remarks>
	/// alias:
	///		empty
	///		virtual
	///		transparent
	///			,as specified in <see cref="nilnul.task.slate_.slot_.Rfc5545"/>
	///		doodle
	///		void
	///		hollow
	///		devoid
	///		vacant
	///		blank
	///		vacuous
	///		
	public interface IEmpty:ITask
	{
	}
}

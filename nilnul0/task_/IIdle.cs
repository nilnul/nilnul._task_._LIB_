namespace nilnul.task_
{
	/// <summary>
	/// an empty task; just a place holder, a nominal one; do nothing;
	/// this is to denote some time (<see cref="task.slot_.IMask"/>). but it doesnot require other resources.
	/// </summary>
	/// <remarks>
	/// note this is an empty task, not empty slate. Hence it can be <see cref="task.ISlate"/> into a nontrivial duration.
	/// </remarks>
	/// this is not intended for a congregation, but for dependencies
	/// 
	/// alias:
	///		empty
	///		virtual
	///		transparent
	///			,as specified in <see cref="nilnul.task.slate_.slot_.Rfc5545"/>
	///		doodle
	///		do nothing
	///		void
	///		hollow
	///		devoid
	///		vacant
	///		blank
	///		vacuous
	///		dawdle
	///		dally
	///		numb
	///		dummy
	///		
	///		
	/// vs:
	///	<see cref="IMask"/>
	///		,the time of which is long
	///		

	public interface IIdle : ITask { }

}

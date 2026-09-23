namespace nilnul.task_
{
	/// <summary>
	/// the task has nothing done; but it contains a <see cref="task.attr_.IRegen"/> which means the job of this task is reschedule another task.
	/// eg:
	///		 having a box of mulitple ream of A4 papers, we need buy a new box when:
	///			1) the box is about to be empty
	///			2) we are still in office, not driven out by the landlord
	///		,then we can create a task, lest we forget, that is <see cref="task.slot.recur_.IOnce"/>
	///  ;
	///  we can change this very task to the new task. In that sense, the trigger is not to regen a task, but replace the task.
	/// </summary>
	/// alias:
	///		supplanter
	///		surrogate
	///		substitute
	///		renew
	///		placeholder
	///		replacer
	///		proxy
	///		stub
	///		dummy
	///		
	public interface ITrigger:IEmpty { }

}

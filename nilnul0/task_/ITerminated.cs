namespace nilnul.task_
{
	/// <summary>
	/// <see cref="ICancelled"/> or <see cref="IAborted"/> or <see cref="IFinished"/>
	/// </summary>
	/// alias:
	///		  exit
	///			,so the task is not considered.
	///			disown
	///		dead
	///		archived
	///		
	interface ITerminated :ITask{ }

}

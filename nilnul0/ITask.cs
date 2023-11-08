namespace nilnul
{
	/// as of May 2023, Google Assistant and Google Calendar reminders automatically migrate to Google Tasks
	/// that vindicates that <see cref="task.ISchedule"/> shall be part of this the task library;
	/// 
	/// <summary>
	/// something to do.
	/// </summary>
	/// <remarks>
	///  past tasks as diary;
	///  future task as todo|schedule
	///  
	///			, some have unspecified date.
	///			
	///  also we can incorporate some project management to allow:
	///		1) task inclusion, <see cref="nilnul.task.re_.Include"/>
	///		2) task precedence <see cref="nilnul.task.co_.Dep"/>
	///
	/// we can also group some tasks, and we can then apply prjMgt to that planner; <see cref="nilnul.task.slates.IChronicle"/> can be taken as a prj, and we have multiple prjs running parallelly;
	/// </remarks>
	/// alias:
	///		todo
	///		task
	///			"t"ime
	public interface ITask
		//:nilnul.time.ITodo
	{

	}


}

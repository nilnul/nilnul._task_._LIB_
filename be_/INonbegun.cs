namespace nilnul.task.be_
{
	/// <summary>
	/// some task might be slated in earlier time, but it's not carried out as scheduled in time.
	/// some task might be in future, and has not been begun;
	/// </summary>
	/// <remarks>
	/// in google iCalendar, the todo, not the event, is regarded as an unscheduled task. we have a due time, but the todo can be done early;
	/// </remarks>
	interface INonbegun { }
}

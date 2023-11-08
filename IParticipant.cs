namespace nilnul.task
{
	/// <summary>
	/// associate task with persons;
	/// </summary>
	/// <remarks>
	/// for example
	///		, a conference participated by a few persons;
	///		, for a <see cref="nilnul.task_.IProject"/>, assign, by a person himself sometimes, tasks to a person. per constraints, one person may or may not lead some tasks at the same time;
	/// 
	/// </remarks>
	/// alias:
	///		assign
	///		appoint
	interface IParticipant { }
}

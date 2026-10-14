namespace nilnul.task.bi_._merge_.by_
{
	/// <summary>
	///  append the newly created task to the old one
	/// </summary>
	/// <remarks>
	///   this is idempotent, when newly repetitive task won't alter the current tasks (the minor changes to the previous task are neglectable in terms of semantics.)
	/// </remarks>
	/// alias:
	///		absorb
	///		rollup
	interface IAppend :task.IBi
	{
	}


}

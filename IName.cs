namespace nilnul.task
{
	/// <summary>
	/// a text to express the task.
	/// the text can be any text, and can be changed on different occasion;
	/// </summary>
	/// <remarks>
	/// it can follow the URI  with preRegistered protocol, for example:
	///		fetch:
	///			,meaning to take back an incoming package
	///		buy:
	///			,to buy sth
	///	;
	///	vs:<see cref="task.INote"/> which cover everything including this, so this can act as an extract, to indicate the status of the progress, especially when the task is a slate of multiple slots;
	///		
	/// </remarks>
	/// alias:
	///		caption
	///		title
	///		subject
	///		theme
	///		topic
	///		summary, per google calendar
	///		uri:urn
	public interface IName
		:nilnul._task_.INote
	{ }

}

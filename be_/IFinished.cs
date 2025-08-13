namespace nilnul.task.be_
{
	/// <summary>
	/// the task has been done;
	/// note: a future task might be slated later, but done recently; and we need to adjust the slate to the actual time.
	/// </summary>
	/// <remarks>
	///    whether a task is done or desserted even in the past?
	///		we can tell by:
	///			, whether it's <see cref="nilnul.task.slate.chron_.IDone"/>
	///			, whether in <see cref="nilnul.task.note"/> as <see cref="nilnul.xml.IXec"/>, the value of the key done is 1.
	/// </remarks>
	public interface IFinished:begun_.stopped_.ISucced { }
}

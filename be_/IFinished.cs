namespace nilnul.task.be_
{
	/// <summary>
	/// the task has been done;
	/// note: a future task might be slated later, but done recently; and we need to adjust the slate to the actual time.
	/// </summary>
	public interface IFinished:begun_.stopped_.ISucced { }
}

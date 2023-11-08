namespace nilnul.task.be_.begun_.stopped_
{
	/// <summary>
	/// the task has been done;
	/// note: a future task might be slated later, but done recently; and we need to adjust the slate to the actual time.
	/// </summary>
	/// alias:
	///		Succed
	///		done
	///		finished
	///		nonfaulty
	///		triumph
	///		in iCalendar, this is also vJournal
	public interface ISucced:IStopped { }

}

namespace nilnul.task.be_
{
	/// <summary>
	/// the start time is ge Now.
	/// the task has been started;
	/// it might be finished or not.
	/// </summary>
	/// alias:
	///		started
	///		begun
	///		
	/// vs uncompleted
	/// 
	public interface IBegun: task.be_.IUnEnded { }

}

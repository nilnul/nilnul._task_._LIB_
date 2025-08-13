namespace nilnul.task.rel_
{
	/// <summary>
	/// a task is precedended by another task. that is, the other task must be finished before we start this task;
	/// </summary>
	public interface IPrecedent
		:IDac
	{
	}

}

namespace nilnul.task.slot.be_
{
	/// <summary>
	/// has no <see cref="task.attr_.IPrevious"/>, hence this task is not <see cref="slot_.ISubsequent"/>, but a task that is unprecedent.
	/// </summary>
	/// <remarks>
	/// precedent task is preferred to this, as often we might find it difficult to track the subsequent than when we keep track of its precedent which might be in the present time, and often it's more explicit and realistic per the user.
	/// </remarks>
	/// alias:
	///		unprecedent
	internal class IUnprecedent
	{
	}

}

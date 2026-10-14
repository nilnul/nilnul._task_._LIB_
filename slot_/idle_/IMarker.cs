namespace nilnul.task.slot_.idle_
{
	/// <summary>
	///  a slot for <see cref="task_.idle_.IMarker"/>
	/// </summary>
	/// <remarks>
	/// Google calendar doesnot allow zero duration. Hence, this is slotted to a session of trivia infinitesimal duration such as 1second
	/// </remarks>
	/// alias:
	///		milestone
	interface IMarker :task.ISlot,IMask { }
}

namespace nilnul.task
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		allot
	///			time
	///		slot
	///			"s"chedule
	///		span
	///		period
	///		slate
	///		
	///		
	public interface ISlot:task.slate_.IUnrecur
	,
		nilnul.time.bound_.IClopen /// implies that the duration is nonnil.
	{ }


}

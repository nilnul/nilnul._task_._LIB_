namespace nilnul.task.slate.re_
{
	/// <summary>
	/// A is recursively, reflexively, the parent of B.
	/// That is:
	///		A is B
	///		,A is the parent of the sup of B
	///	; 
	///	A's end time is later than the end time of any sub task.
	/// </summary>
	internal class ISup	:slate.IRe
	{
	}


}

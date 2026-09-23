namespace nilnul.task.slate.re_
{
	/// <summary>
	/// Slate A is earlier than Slate B.
	/// hence, the two are disjoint:<see cref="time.bound.re_.IDisjoint"/>
	/// </summary>
	/// alias:
	///		before
	///		IPrevious
	public interface IBefore
		:
		task.slate.IRe
		,
		
		nilnul.rel.node.re_.IParent
	{
	}




}

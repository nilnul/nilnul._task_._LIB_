namespace nilnul.task.slate.re_
{
	/// <summary>
	/// Slate A is after Slate B.
	/// hence, the two are disjoint:<see cref="time.bound.re_.IDisjoint"/>
	/// </summary>
	/// alias:
	///		consequent, reserved for <see cref="rel.node.re_.con"/>
	///		
	public interface IAfter
		:
		task.slate.IRe
		,
		
		nilnul.rel.node.re_.IChild
		,
		nilnul.obj.re_.IIrreflexive
		,nilnul.obj.re_.irreflex_.ITransitive
		,nilnul.obj.re_.IDominance
		,
		nilnul.rel_.irreflex_.asym_.IAcyclic
	{
	}




}

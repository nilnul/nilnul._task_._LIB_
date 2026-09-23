namespace nilnul.task.slate.re_
{
	/// <summary>
	/// A is recursively, not reflexively, the parent of B.
	/// That is:
	///		A is the precedent of B
	///		,A is the precedent of the antecedent of B
	///	; 
	/// </summary>
	/// alias:
	///		
	public interface IAntecedent:slate.IRe
		,
		rel.node.re_.IAncestrial
	{
	}




}

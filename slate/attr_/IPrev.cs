namespace nilnul.task.slate.attr_
{
	/// <summary>
	/// A's previous means a task immediatly before A;
	/// a task begins after the previous task ends
	/// <see cref="task.rel_.IPrecedent"/>
	/// </summary>
	/// <remarks>
	/// this as an attribute is within the data of the task. For it's computed recursively value, <see cref="task.IAntecedence"/>
	/// </remarks>
	/// alias:
	///		previous
	///			,prev, vs next
	///		precedent
	///			,prec, vs subsequent/posterior
	///		pre
	///		prior, vs posterior
	///		premise
	///		progenitor
	///		upto
	///		past, as the recursive definition of prev.
	///		
	///		<see cref="nilnul.rel.node.IPredecessor"/>
	///		
	///	vs:
	///		hence
	///		thence
	///		henceforth
	///		<see cref="re_.IPrior"/> or precede which is a verb.
	///		
	///
	///		
	///		
	internal class IPrev:task.IAttribute
		,
		nilnul.rel.node.re_.IParent
	{
	}


}

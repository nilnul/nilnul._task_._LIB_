namespace nilnul.task.slate.attr_
{
	/// <summary>
	/// any slate x for this task a, such that:
	///		a <see cref="slate.re_.ISup"/>
	///  <see cref="task.attr_.IPrevious"/> recursively, excluding the task itself. 
	/// </summary>
	/// 
	/// vs:
	///		<see cref="IProgenitor"/>
	internal class IAntecedence
		:
			nilnul.rel.node.re_.IAntecedent
	{
	}

}

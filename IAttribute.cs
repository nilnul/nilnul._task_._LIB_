namespace nilnul.task
{
	/// <summary>
	/// <see cref="nilnul.obj._attr_.IKey0val"/> stored within (not tagged or appended outside) the task, say, in the task's <see cref="_task_.INote"/>, which is parsed as <see cref="nilnul.xml.IXec"/>
	/// </summary>
	/// vs:
	///		<see cref="task.rel_"/> which is stored outside task, able to represent cyclic relation, while this is suitable for acyclic attributes, which in rel terms is called <see cref="nilnul.rel_.IDac"/>
	/// 
	public interface IAttribute: nilnul.obj.IAttr
	{
	}


}

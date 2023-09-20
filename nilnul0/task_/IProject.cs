namespace nilnul.task_
{
	/// <summary>
	/// project is a way to decompose task, and meanwhile keeping the associations betweeen subtasks such as to make the project an equivalence to the original whole task ;
	/// </summary>
	/// <remarks>
	///  1) a well-defined clear-scoped target;
	///  2) a constraint of limited resources such as time, cost, etc;
	///  also, complex enough such that we need to decompose it;
	/// </remarks>
	public interface IProject:IRequest4decompose
		//,IDecomposable or single
	{ }
}

namespace nilnul.task_
{
	/// 
	/// <summary>
	/// project is a way to decompose task, and meanwhile keeping the associations betweeen subtasks such as to make the project an equivalence to the original whole task ;
	/// </summary>
	/// <remarks>
    /// project hence is an optimization problem in that:
	///  1) a well-defined clear-scoped target;
	///  2) a constraint of limited resources such as time, cost, etc;
	///  also, complex enough such that we need to decompose it;
	///, and it can be solved using OperationResearch knowledge;
	///	this makes task composible and decomposible;
	/// </remarks>
	/// vs:
	///		<see cref="task.IPrj"/> that might be taken as a project concerning tasking, this is more explicit to regard prj as task;
	///	alias:
	///		project
	///		,abbr:prj
	public interface IProject
		:
		//,IDecomposable or single
		IRequest4decompose
		/// so task_.Proj is recursively defined:
		 /// 1) basis: proj is task_.Proj; <see cref="task_.IProject"/>
		 /// 2) extension: proj as a task can form a bigger proj by <see cref="task.IProject"/> which means the extension here.
	{ }
}

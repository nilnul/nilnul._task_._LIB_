namespace nilnul.task
{
	/// <summary>
	/// the <see cref="task.rel_.IPrecedent"/> forms a <see cref="rel_.IDac"/>.
	/// </summary>
	/// <remarks>
	/// On the rel, the properties (such as labor, materials, data)  of each task, or some tasks can be calculated;
	/// in history, this is recorded as:
	///		:deed
	///		:episode
	///		:event
	///		:story
	///		
	/// </remarks>
	/// alias:
	///		prj
	///			,<see cref="nilnul.dev.prj"/> is also such a project.
	///			,projective, predictive
	///		proj
	///			,might confuse with <see cref="nilnul.geometry.planar.map_.IProjection"/>
	///		plan:
	///		
	/// vs:
	///		projection|projective, which is <see cref="nilnul._rel.map_."/>
	///			
	/// vs:
	///		<see cref="nilnul.task_.IProject"/>, which is one char longer, emphasize that here it is a collection of tasks, among which their are relations such as precedence.
	///		, this emphasizes that project is a rel on task, whileas that emphasizes that project is also task; the two can be converted back and forth: a task.Project can be regarded as a deed, and embedded into another project as a subproject; a task_.project can, per a perspective of its internal structure, be regarded as a structure of tasks;
	///			:, when it's typed as task.Project, we see, into its internal, its nonlinear structure. when it's typed as task_.Project, we see, from outside,  it as a linear sequence, or part of a linear sequence.
	///		, so task_.Proj is recursively defined:
	///				1) proj is task_.Proj;
	///				2) proj as a task can form a bigger proj.
	///								 ///			
	///	vs:
	///		<see cref="nilnul.task"/>, a prj can be tagged and regarded as a task, and a task can be decomposed, and reconstructed as a prj
	///		
	///		
	public interface IPrj
		:

		task.rel_.IDac
		,
		 //ITask
		 task_.IProject /// extension clause in recursion definition. <see cref="nilnul.task_.IProject"/> for the recursion definition. 

	{

	}
}

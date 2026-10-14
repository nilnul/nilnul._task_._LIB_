using System;

namespace nilnul.task.rel_
{
	/// <summary>
	/// a task is precedended by another task. that is, the other task must be finished before we start this task;
	/// </summary>
	/// alias:
	///		previous
	///		prev
	///		progressive
	///		evolve
	///		
	///	;
	///	not <see cref="nilnul.rel.node.attr_.IPrecedent"/>
	/// 
	/// 
	[Obsolete(nameof(task.slate.attr_.IPrev)+ ", being acyclic, is demoted into attr")]
	public interface IPrecedent
		:IDac
	{
	}

}

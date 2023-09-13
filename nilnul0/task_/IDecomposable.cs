using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task_
{
	/// <summary>
	/// some task can be decomposed into many subtasks, with the associations among them being kept;
	/// </summary>
	/// <remarks>
	/// some task, even decomposable, is not decomposed, as it's not big enough and we can still treat it as a single task;
	/// </remarks>
	/// vs:
	///		<see cref="IRequest4decompose"/>
	///			, which might split the task into one, resulting the same task, whileas for this, the task can be split to at least two nontrivia(<see cref="IDoodle"/>) tasks;

	internal interface IDecomposable
	{
	}
}

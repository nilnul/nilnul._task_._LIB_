using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task_
{
	/// <summary>
	/// eg:
	///		a task can be decomposed as a reminder and the reminded; the reminder would be regarded as a task, and it might be scheduled earlier;
	///	The two subtasks are now taken as whole as <see cref="task_.IComposite"/>
	///
	/// </summary>
	///  and <see cref="nilnul.task.re_.Include"/>
	///  vs:
	///		complex, which is not only a composite of multiple tasks, but also comprises some associations between tasks (<see cref="nilnul.task.co_"/> ). complex task is represented as <see cref="nilnul.task_.prj"/>
	///	vs: compound, which involvs more than this|composite in that it virtually entails an umbrealla term, the container to hold wholely the composite.
	///	vs: combined, of two.
	///
	/// <see cref="nilnul.task.re_.ISibling"/>
	/// <see cref="nilnul.task.re_.IAffiliate"/>
	internal class IComposite
	{
	}
}

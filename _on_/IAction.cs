using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task._on_
{
	/// <see cref="" href="event graph"/>
	/// ,where the trigger is standardized:
	///		:the condition which will trigger an action
	///		:a guard constraint, inside the action, determining whether the next event will be generated.
	/// 	:the action can be wrapped in a task that would be later executed again.
	/// ; the gist is:
	///		on condition (like <see cref="task.on_.IOnEnd"/>), trigger an action.
	/// <summary>
	/// the action taken on a condition.
	/// </summary>
	internal class IAction
	{
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task_
{
	/// by defining a virtual notion for <see cref="nilnul.ITask"/>, we can thus embrace a variety of tasks such as alarm clock;
	/// a task can be anything to do at some time later.
	/// <summary>
	/// the reminder|alamr to tip that a task is going to begin, can also be regarded as a task. and it can repeat, or rescheduled to a later time.
	/// </summary>
	/// <remarks>
	/// the reminder can be:
	///		play sound
	///		display a notice
	///		email
	///		,...
	/// </remarks>
	/// 
	internal class IReminder
	{
	}
}

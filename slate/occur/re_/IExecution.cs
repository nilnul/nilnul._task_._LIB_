using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate.occur.re_
{
	/// <summary>
	/// eg:
	///		for a periodic(monthly) settle for credit card bills, we may still receive a bill for a specific month stating the concrete amount, via mail or msg; and for simplicity, we can keep the occur for the current month, but also put the msg abreast(share the same period of time:<see cref="time.IBound"/>, share the same end, but the start is one moment later such that the execution is a follower) with the occur
	/// </summary>
	/// <remarks>
	/// this will leave the original periodic slate unchanged, thus this is an incremental change to revise an occur by keeping the original one, but applying a patchy slot onto it.
	/// </remarks>
	/// alias:
	///		enforce
	///		reify
	///		implement
	///		
	/// <see cref="task.re_."/>
	///		
	internal class IExecution
	{
	}
}

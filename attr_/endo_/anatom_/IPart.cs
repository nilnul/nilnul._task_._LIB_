using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.attr_.endo_.anatom_
{
	/// <summary>
	/// like a federated, the task that contains constituent doesnot control each item; each item reschedules independently, then the task, dubbed federation, reschedules accordingly subsequently.
	/// </summary>
	/// <remarks>
	/// when A.constituent= [B,...]
	///     ,then   A's start is the min of all constituents, A's end is the max of all constituents
	/// ;
	/// 
	/// alias:
	///		holistic8alter
	///		constituent
	///			, the whole is the federal

	public interface IPart
	{
	}

}

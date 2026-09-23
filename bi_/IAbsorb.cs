using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.bi_
{
	/// <summary>
	/// for task x!= y
	///		,embed|combine y into x
	///		,, while removing repetitive information.
	/// </summary>
	/// <remarks>
	/// used in <see cref="task.re_.IRepetitive"/>
	/// </remarks>
	/// alias:
	///		absorb
	///		merge, which means earlier taking late one
	///		;;;;;;;;
	///		embed, which means x embedds into y
	public interface IAbsorb:task.IBi
	{
	}
}

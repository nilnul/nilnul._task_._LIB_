using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.attr_.endo_.timing_.next
{
	/// <summary>
	/// A.ante = B|C ...
	/// , means B C ... is earlier;
	///  
	///  ; this acts as a directive to alter prior task: B C ...
	/// </summary>
	/// alias:
	///		precedent:<see cref="nilnul.rel.node.attr_.IPrecedent"/>
	///		
	///		isPosteriorOf
	///		
	///		ante
	///		pro
	///		anterior
	///		prior
	///		prioritize
	///		premise
	///		prepare
	///		preliminary
	///		prologue
	///		epilogue
	///		
	///		
	public interface IIsNextOf:ITiming
	{
	}


}

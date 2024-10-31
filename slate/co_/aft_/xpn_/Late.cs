using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slate.co_.aft_.xpn_
{
	/// <summary>
	/// the precedent task finished late so the subsequent task starts before the precedent finishes;
	/// </summary>
	

	[Serializable]
	public class Late : Exception
	{
		public Late() { }
		public Late(string message) : base(message) { }
		public Late(string message, Exception inner) : base(message, inner) { }
		protected Late(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}

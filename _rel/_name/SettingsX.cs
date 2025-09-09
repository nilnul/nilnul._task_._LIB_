using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task._rel._name
{
	internal class SettingsX
	{

		/// <summary>
		/// A.mask = B
		/// ,means
		/// B is a time slot, and A must be inside that time slot.
		/// </summary>
		static public string Mask { get {
				return Settings1.Default.mask;
			}
			set { 
				Settings1.Default.mask = value;
			}
		}
	}
}

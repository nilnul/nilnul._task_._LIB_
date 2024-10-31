using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task._remind._alarm
{
	///datatracker.ietf.org/doc/html/rfc5545#section-3.8.6
	///
	/// <summary>
	/// defines the number of times an alarm      should be repeated after its initial trigger.  If the alarm      triggers more than once, then this property MUST be specified      along with the "DURATION" property.
	/// </summary>
	/// <remarks>
	/// eg:repeats 4 additional times with a 5-minute delay after the      initial triggering of the alarm:
	///		REPEAT:4
	///		DURATION:PT5M
	/// </remarks>
	internal enum Li_
	{
		/// <summary>
		/// email is sent to participants
		/// </summary>
		Email
			,
		/// <summary>
		/// popup window  or notice is popped out on desktop or mobile phone;
		/// </summary>
		/// alias:
		///		display
		Popup
			,
		/// <summary>
		/// sound is played, in a soundbox. if this is computer, it can be combied with a popup window.
		/// </summary>
		/// alias:
		///		audio
		Sound
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.on_.triG_.os_
{
	/// <summary>
	/// Task Scheduler is a built-in GUI tool and command-line utility used to automate scripts, programs, and system tasks at specified times or intervals;
	///  Press Win + R, type taskschd.msc, and hit Enter for  Task Scheduler (GUI)
	///  ;
	///  Schtasks (Command Line)
	///		to View tasks: 
	///			schtasks /query
	///		Create task: 
	///			schtasks /create /tn "MyTask" /tr "C:\script.bat" /sc hourly 
	///		Delete task: 
	///			schtasks /delete /tn "MyTask"
	///		;
	///	for missed executions, 
	///		they can run immediately upon restart	
	/// </summary>
	/// <remarks>
	///  The most robust and common approach is using the TaskService (Microsoft.Win32.TaskScheduler) NuGet package, which wraps the native Windows Task Scheduler V2 API.
	///  

	/// </remarks>
	internal class IWindows
	{
	}
}

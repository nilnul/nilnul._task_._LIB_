using System;

namespace nilnul.task.rel_
{
	/// <summary>
	/// <see cref="task.attr_."/>
	/// </summary>
	public class _PrededentX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternatives:
		///		previous
		///		prev
		///		precedent

		[Obsolete(nameof(Key),true)]
		public const string KEY = "precedent";

		public static string Key  {
			get{ return _rel._name.Settings1.Default.precedent; }
			set { _rel._name.Settings1.Default.precedent = value; }
		}

	}

}

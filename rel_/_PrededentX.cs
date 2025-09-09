using System;

namespace nilnul.task.rel_
{
	public class _PrededentX
	{

		[Obsolete(nameof(Key),true)]
		public const string KEY = "precedent";

		public static string Key  {
			get{ return _rel._name.Settings1.Default.precedent; }
			set { _rel._name.Settings1.Default.precedent = value; }
		}

	}

}

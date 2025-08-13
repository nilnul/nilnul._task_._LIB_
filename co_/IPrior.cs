namespace nilnul.task.co_
{
	static public class _PriorX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alternatives:
		///		precedent
		///		antecedent
		///		prior
		///		dependent
		public const string KEY = "prior";
	}
	/// <summary>
	/// the task must be done before the other task is started;
	/// </summary>
    /// alias:
    ///		priority
    ///		precedent
    ///		dependent
	///		then
    ///	vs:
    ///	    subsequent
	public interface IPrior { }
}

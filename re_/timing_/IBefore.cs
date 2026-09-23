namespace nilnul.task.re_
{
	/// Thunder often precedes rain.
	/// <summary>
	/// A precedes B:
	/// the task must be done before the other task is finished;
	/// 
	/// </summary>
	/// <remarks>
	/// this can form a project by:
	///		, set a goal
	///		, regenerate next tasks each of which takes a prior as <see cref="re_.IPrecedent"/>
	/// </remarks>
	/// alias:
	///		antecede
	///			,verb
	///			,vs:preposition,predicative 
	///		precede, which shall be avoided due to confliction with <see cref="attr_.IPrevious"/>, note:we use different words for the attr of the posterior
	///		
	/// 
	interface IBefore{ }

}

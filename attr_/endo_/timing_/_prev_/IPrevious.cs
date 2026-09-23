namespace nilnul.task.attr_.endo_.timing_.prev
{
	/// <summary>
	/// A.prev=B C ...
	/// , means A is immediately, directly,  before X
	///		,,where X = B C ...;
	/// ;
	/// acting as a directive, this alters A's start to be after X's start
	/// ;
	/// </summary>
	/// alias:
	///		previous
	///		premise
	public interface IPrevious :task.attr_.endo_.timing_.INext8alter { }


}

namespace nilnul.task.attr_.endo_.timing_.prev
{
	/// <see cref="task.attr_.INext"/>
	/// <summary>
	///  A.next = B C ...
	///		,means X's start shall be changed to be later than A's 
	///			,where X = B C ...
	///	;
	///	This is the converse of <see cref="IPrevious"/>
	/// </summary>
	/// 
	/// 
	/// alias:
	///		isPreviousOf
	///			, "is" means this is a relation:<see cref="obj.re_.IIs"/>,not an alterable attribution, in an assertive tone, so this is the unchangeable basis, and the val after "of" is to be altered, to maintain this relation
	///			, like "isPrototypeOf" in javascript, where "prototype" is not to be changed, but the instance will be changed.
	///	
	
	public interface  	IIsPrevOf

#if !DEBUG
		//INext
#else

#endif
		:task.attr_.endo_.ITiming { }





}

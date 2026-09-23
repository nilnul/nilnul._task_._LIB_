namespace nilnul.task.attr_.endo_.timing_
{
	/// <summary>
	/// this is 
	///		:prev -> next relation
	///		,for which we always alter the next
	///	; the unchanged is "previous"	
	///	
	/// </summary>
	/// 
	/// the concerned relation:
	///		prev -(  next
	///			,this is called "prev" relation per <see cref="nilnul.obj.re.of_.attr_.IPrincipalAsTgt"/>
	///			
	///		next -(- prev
	///			, this is called "next" relation.
	///			,where prev is the principal|base.
	///		 , so:
	///		 the changed is the tendril of the "next" relation, and the principal of the "prev" relation.
	/// 
	/// alias:
	///		prev8base
	///		prev8basis
	///		pre
	///			,the tgt of this rel: isPreOf, being next, will be changed.
	///			, the previous is kept unchanged.
	///		
	///		nex8mov
	///		next8mov
	///		
	///

	public interface IPrev:
		attr_.endo_.ITiming
	{
	}





}

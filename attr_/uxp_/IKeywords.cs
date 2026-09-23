namespace nilnul.task.attr_.uxp_
{
	/// <summary>
	/// keywords can help when being searched;
	/// </summary>
	/// keywords = abc eft, def
	///		,where '=' implies this is attr, and the ',' ends the keywords, so "def" is another attr or introduction|declaration|decl
	///		, in other words, when ',' is used as delimiter, then this shall be regarded as not attr, but as prop shown below;
	///	;
	///	keywords: abc 	eft, def;
	///		,where ':' implies this is prop, and ',' is part of the clauze, meanwhile ';' ends the clauze.
	///	
	///	keywords: abc = aaa, eft, def;
	///		,where abc and "aaa" means the same thing..
	///		
	/// 
	internal class IKeywords
	{
	}

}

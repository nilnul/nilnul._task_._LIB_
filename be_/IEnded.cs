namespace nilnul.task.be_
{
	/// <summary>
	/// the task's end 
	/// <![CDATA[
	///		<= now
	///			,where we use '<=' rather than "<" in that <see cref="task.end"/> is exclusive.
	/// ]]>
	/// </summary>
	/// it's either success, or cancelled before it's started. <see cref="System.Task"/>
	/// alias:
	///		complete
	///		exit
	///		
	/// vs:
	///		<see cref="IDone"/>
	///		
	public interface IEnded
		//:
		//begun_.stopped_.ISucced 
	{ }

}

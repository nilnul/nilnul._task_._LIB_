namespace nilnul.task
{
	/// <summary>
	/// concrete svr depends on outside uncontrollable servers; so they are moved to a separate library : nilnul.task._hub_, or nilnul._task_.svr|hub
	/// </summary>
	/// <remarks>
	/// svr_ is like a dialect, which is not universal or perpetual enough. dialects eventual confluent, but in development, they better be kept as separate project before stablize into the main project.
	/// the common best practice will be merged into this prject.
	/// </remarks>
	interface ISvr_ { }
}

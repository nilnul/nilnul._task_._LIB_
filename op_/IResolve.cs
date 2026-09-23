namespace nilnul.task.op_
{
    /// <summary>
    /// the task can be ended by:
    ///     cancel, when the task is scheduled, but later unscheduled.
    ///     abort, the task is started, then discarded
    ///     finish, the task is started, and completed successfully or faulty(as exception is always subtype of the result); like a program which has been run.
    ///         ,fail |faulty
    ///         ,success |finish
    /// </summary>
    /// alias:
    ///     past
    ///     processed
    ///       resulted
    ///       resolved
    ///       complete
    ///       accomplish
    ///       achieve
    ///       
    ///      expired
    ///      out of agenda
    ///      dead
    ///      sealed
    ///      freezed   |frozen
    ///      resolve
    ///      
    /// vs:
    ///      done, excluding cancellation
    ///         
    interface IResolve { }
}

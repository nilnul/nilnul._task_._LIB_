namespace nilnul.task.slot.re_.timing_
{
    /// <summary>
    /// A begins after the begin of B.
    /// </summary>
    /// <remarks>
    /// 
    /// this association can be normalized by having:
    ///     B decomposed as B_begin, B_torso
    ///   ,then the association is decomposed in 2 <see cref="re_.timing_.IBeginAftEnd"/>:
    ///      B_torso begins after B_begin ends
    ///      A begins after B_begin ends
    ///     
    /// </remarks>
    internal class IBeginAftBegin
    {
    }


}

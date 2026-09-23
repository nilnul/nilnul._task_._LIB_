namespace nilnul.task.slot.re_.timing_
{
    /// <summary>
    /// A ends after the begin of B.
    /// </summary>
    /// <remarks>
    /// B can be decomposed as B_begin, B_torso;
    /// 
    /// then the relation is:
    ///      B_torso begins after B_begin ends
    ///      A ends after the ends of B_begin, which can be further decomposed as <see cref="IEndAftEnd"/>
    ///         , A_end begins after A_trunk
    ///         , A_end begins after B_begin
    /// 
    /// 
    /// this association can be normalized by having:
    ///     A decomposed as A_trunk, A_end
    ///     B decomposed as B_begin, B_torso
    ///   ,then the association is decomposed in three <see cref="re_.timing_.IBeginAftEnd"/>:
    ///      A_end begins after A_trunk ends
    ///      B_torso begins after B_begin ends
    ///      A_end begins after B_begin ends
    ///     
    /// </remarks>
    internal class IEndAftBegin
    {
    }


}

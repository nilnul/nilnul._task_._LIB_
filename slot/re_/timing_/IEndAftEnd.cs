using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.task.slot.re_.timing_
{
    /// <summary>
    /// A ends after the end of B.
    /// eg:
    ///     when A includes B, then A can only end after each component ends.
    /// </summary>
    /// <remarks>
    /// this association can be normalized by having:
    ///     A decomposed as A1, A2=(end ceremony of A)
    ///   ,then the association is decomposed in two <see cref="re_.timing_.IBeginAftEnd"/>:
    ///      A2 begins after A1 ends
    ///      A2 begins after B ends
    ///     
    /// </remarks>
    internal class IEndAftEnd
    {
    }


}

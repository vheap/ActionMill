using ActionMill.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Options
{
    public readonly record struct TimeoutOptions(
        TimeSpan Duration,
        TimeoutBehaviour Behaviour,
        int MaxTimeoutReruns // Number of times to rerun the action/mill if it times out.
    )

    {
        public static TimeoutOptions None => new(Timeout.InfiniteTimeSpan, TimeoutBehaviour.Cancel, 0);
    }
}

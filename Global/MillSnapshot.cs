using ActionMill.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Global
{
    public sealed record MillSnapshot(

        Guid Id,
        MillStatus Status,
        int MaxParallel,
        int QueuedCount,
        int RunningCount,
        TimeSpan Elapsed,
        double Progress
    );
}

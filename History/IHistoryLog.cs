using ActionMill.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.History
{
    public interface IHistoryLog
    {
        // ValueTask to allow for a perfmornant async implementation when compared to Task.
        ValueTask WriteAsync(in LogEvent entry, CancellationToken token);
    }
}

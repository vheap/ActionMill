using ActionMill.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.History
{
    public sealed class NullHistoryLog : IHistoryLog
    {
        public static readonly NullHistoryLog Instance = new();
        private NullHistoryLog() { }
        public ValueTask WriteAsync(in LogEvent entry, CancellationToken token) => ValueTask.CompletedTask;
    }
}

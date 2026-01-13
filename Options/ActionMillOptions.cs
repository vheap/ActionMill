using ActionMill.Enums;
using ActionMill.History;
using ActionMill.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Options
{
    public sealed class ActionMillOptions
    {
        public int MaxParallel { get; init; } = 4;
        public HistoryLevel HistoryLevel { get; init; } = HistoryLevel.All;
        public RetryOptions DefaultRetryPolicy { get; init; } = RetryOptions.None;
        public TimeoutOptions DefaultTimeoutPolicy { get; init; } = TimeoutOptions.None;
        public IActionMillLogger Logger { get; init; } = Logging.NullActionMillLogger.Instance;
        public IHistoryLog HistoryLog { get; init; } = History.NullHistoryLog.Instance;
    }
}

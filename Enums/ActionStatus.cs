using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Enums
{
    public enum ActionStatus
    {
        Idle,
        Queued,
        Running,
        Paused,
        Completed,
        Failed,
        Cancelled,
        TimedOut,
        Removed,
        UndoQueued,
        UndoRunning,
        UndoCompleted,
        UndoFailed
    }
}

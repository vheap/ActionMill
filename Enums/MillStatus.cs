using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Enums
{
    public enum MillStatus
    {
        Idle,
        Running,
        PausingWait,
        Paused,
        Cancelled,
        Completed,
        Disposed
    }
}

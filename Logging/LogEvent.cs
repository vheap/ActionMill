using ActionMill.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Logging
{
    public readonly record struct LogEvent(
        // Since I am just representing data, I will be using immutable record structs. Might be changed later.

        DateTimeOffset TimeUtc,
        LogEventKind Kind,
        Guid MillId,
        Guid ActionId,
        ActionStatus Status,
        MillStatus MillStatus,
        Exception? Exception
    );
}

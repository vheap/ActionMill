using ActionMill.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Global
{
    public sealed record ActionSnapshot(

        Guid Id,
        Guid MillId,
        string Description,
        string? Tag,
        int Priority,
        ActionStatus Status,
        int Attempt,
        bool HasUndo,
        TimeSpan Elapsed,
        Exception? Exception,
        double Progress

    );
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Global
{
    public sealed class ActionHandle
    {
        internal ActionHandle(Guid id, Task completion) { Id = id; Completion = completion; }
        private Guid Id { get; }
        private Task Completion { get; }
    }
}

using ActionMill.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActionMill.History
{
    public sealed class ActionHistory
    {
        private readonly object _actionGate = new();
        private readonly List<LogEvent> _entries = new(32);

        public IReadOnlyList<LogEvent> Entries
        {
            get { lock (_actionGate) return _entries.ToArray(); }
        }

        internal void Add(in LogEvent entry)
        {
            lock (_actionGate) _entries.Add(entry);
        }
    }
}

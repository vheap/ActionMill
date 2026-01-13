using ActionMill.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.History
{
    public sealed class MillHistory
    {
        private readonly object _Millgate = new();
        private readonly List<LogEvent> _entries = new(128);

        public IReadOnlyList<LogEvent> Entries
        {
            get { lock (_Millgate) return _entries.ToArray(); }
        }

        internal void Add(in LogEvent entry)
        {
            lock (_Millgate) _entries.Add(entry);
        }
    }
}

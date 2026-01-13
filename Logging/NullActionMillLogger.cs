using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Logging
{
    /// <summary>
    /// Sealed class because it is not intended for inheritence. And it's optional, hence the null prefix to the class name.
    public sealed class NullActionMillLogger : IActionMillLogger
    {
        public static readonly NullActionMillLogger Instance = new();
        private NullActionMillLogger() { }
        public void Log(in LogEvent e) { }
    }
}

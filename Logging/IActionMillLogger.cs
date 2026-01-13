using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Logging
{
    public interface IActionMillLogger
    {
        // Using in to pass the struct by reference for performance, in case the LogEvent becomes larger.
        void Log(in LogEvent e);
    }
}

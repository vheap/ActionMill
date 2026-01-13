using ActionMill.Enums;
using ActionMill.History;
using ActionMill.Logging;
using ActionMill.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ActionMill
{
    public sealed class ActionMill
    {
        private int _maxParallel;
        private bool _disposeAfterCompletion;

        private readonly SemaphoreSlim _parallelActions;
        private readonly object _gate = new();
        private readonly HashSet<Guid> _runningActions = new();
        private readonly CancellationTokenSource _cts = new();
        private readonly Stopwatch _stopwatch = new();
        private readonly TaskCompletionSource _completed = new(TaskCreationOptions.RunContinuationsAsynchronously);

        public MillHistory History { get; } = new();
        public ActionMillOptions Options { get; }
        public IActionMillLogger Logger => Options.Logger;
        public IHistoryLog HistoryLog => Options.HistoryLog;
        public MillStatus Status { get; private set; } = MillStatus.Idle;


        public ActionMill(ActionMillOptions Options) { 
            Options = Options ?? new ActionMillOptions();

            // Stand in variables.
            _maxParallel = Options.MaxParallel;
            _parallelActions = new SemaphoreSlim(_maxParallel, _maxParallel);


        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ActionMill.Options
{
    public readonly record struct RetryOptions(
        // Basic retry options for actions and mills. Will be expanded later.
        // TODO: Add position in queue when retrying.
        // Retry based on other actions within the same mill. E.g. retry only if another action succeeded.

        int MaxAttempts,
        TimeSpan? Delay, // Delay between attemps.
        bool ExponentialBackoff, // Multiply the delay by 2.n
        bool ImmediateRetry, // Retry immediately in the same worker slot without requeieing, otherwise the worker will be disposed of and the task requeued.
        Predicate<Exception>? ShouldRetryException // Based on the exception,
                                                   // decide whether to retry or not. E.g. retrying only on HttpTimeoutException, but not on ArgumentException. 
    )

    {
        public static RetryOptions None => new(1, null, false, false, null);
    }
}

﻿using System;

namespace JWT
{
    /// <summary>
    /// Provider for UTC DateTime.
    /// </summary>
    public sealed class UtcDateTimeProvider : IDateTimeProvider
    {
        /// <summary>
        /// Retuns the current time (UTC).
        /// </summary>
        /// <returns></returns>
        public DateTime GetNow()
        {
            return DateTime.UtcNow;
        }
    }
}
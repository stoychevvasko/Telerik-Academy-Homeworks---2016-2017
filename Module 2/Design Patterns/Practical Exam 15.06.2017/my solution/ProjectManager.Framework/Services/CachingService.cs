﻿namespace ProjectManager.Framework.Services
{
    using System;
    using System.Collections.Generic;
    using Bytes2you.Validation;

    public class CachingService : ICachingService
    {
        private readonly TimeSpan duration;
        private DateTime timeExpiring;

        private IDictionary<string, object> cache;

        public CachingService(TimeSpan duration)
        {
            Guard.WhenArgument(duration, "duration").IsLessThan(TimeSpan.Zero).Throw();

            this.duration = duration;
            this.timeExpiring = DateTime.Now;
            this.cache = new Dictionary<string, object>();
        }

        public bool IsExpired
        {
            get
            {
                if (DateTime.Now.Ticks - this.timeExpiring.Ticks <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void ResetCache()
        {
            this.cache = new Dictionary<string, object>();
            this.timeExpiring = DateTime.Now.Add(this.duration);
        }

        public object GetCacheValue(string className, string methodName)
        {
            return this.cache[$"{className}.{methodName}"];
        }

        public void AddCacheValue(string className, string methodName, object value)
        {
            this.cache.Add($"{className}.{methodName}", value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvanced
{
    internal class CacheItem<T>
    {
        public T Value { get; set; }

        public DateTime ExpirationTime { get; set; }


        public CacheItem(T value, TimeSpan expirationDuration)

        {

            Value = value;

            ExpirationTime = DateTime.Now.Add(expirationDuration);

        }


        public bool IsExpired()

        {

            return DateTime.Now > ExpirationTime;

        }
    }
}

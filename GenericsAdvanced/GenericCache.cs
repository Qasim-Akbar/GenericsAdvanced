using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAdvanced
{
    internal class GenericCache<T>
    {

        private Dictionary<string, CacheItem<T>> cache = new Dictionary<string, CacheItem<T>>();


        public void AddItem(string key, T value, TimeSpan expirationDuration)

        {

            CacheItem<T> cacheItem = new CacheItem<T>(value, expirationDuration);

            cache[key] = cacheItem;

        }


        public T GetItem(string key)

        {

            if (cache.TryGetValue(key, out CacheItem<T> cacheItem))

            {

                if (cacheItem.IsExpired())

                {

                    // Remove expired item from the cache

                    cache.Remove(key);

                    throw new InvalidOperationException("Attempted to retrieve an expired item from the cache.");

                }


                return cacheItem.Value;

            }


            throw new KeyNotFoundException($"Item with key '{key}' not found in the cache.");

        }


        public void Display()

        {

            Console.WriteLine("Current items in the cache:");

            foreach (var kvp in cache)

            {

                Console.WriteLine($"Key: {kvp.Key}, Expiration Time: {kvp.Value.ExpirationTime}, Value: {kvp.Value.Value}");

            }

        }
    }
}

using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _cacheDb;

        public RedisCacheService(IConfiguration configuration)
        {
            var redisConfig = configuration.GetSection("Redis");
            string connectionString = $"{redisConfig["Host"]}:{redisConfig["Port"]}";

            Console.WriteLine($"Redis Connection String: {connectionString}"); // Debugging purpose

            _redis = ConnectionMultiplexer.Connect(connectionString);
            _cacheDb = _redis.GetDatabase();
        }

        public void Set<T>(string key, T value, TimeSpan expiration)
        {
            var jsonData = JsonSerializer.Serialize(value);
            _cacheDb.StringSet(key, jsonData, expiration);
        }

        public T Get<T>(string key)
        {
            var jsonData = _cacheDb.StringGet(key);
            return jsonData.HasValue ? JsonSerializer.Deserialize<T>(jsonData!) : default;
        }

        public void Remove(string key)
        {
            _cacheDb.KeyDelete(key);
        }
    }
}

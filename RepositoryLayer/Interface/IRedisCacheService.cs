using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IRedisCacheService
    {
        void Set<T>(string key, T value, TimeSpan expiration);
        T Get<T>(string key);
        void Remove(string key);
    }
}

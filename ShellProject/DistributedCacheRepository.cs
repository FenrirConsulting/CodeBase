using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories
{
    public class DistributedCacheRepository : IDistributedCacheRepository
    {
        private readonly AppDbContext _context;

        public DistributedCacheRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<byte[]?> GetAsync(string key, CancellationToken token = default)
        {
            var entry = await _context.DistributedCache.FindAsync(new object[] { key }, token);
            if (entry != null && entry.ExpiresAtTime > DateTimeOffset.UtcNow)
            {
                return entry.Value;
            }
            return null;
        }

        public async Task SetAsync(string key, byte[] value, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null, CancellationToken token = default)
        {
            var entry = await _context.DistributedCache.FindAsync(new object[] { key }, token);
            if (entry == null)
            {
                entry = new DistributedCacheEntry { Id = key };
                _context.DistributedCache.Add(entry);
            }

            entry.Value = value;
            entry.ExpiresAtTime = DateTimeOffset.UtcNow.Add(absoluteExpireTime ?? TimeSpan.FromMinutes(30));
            entry.SlidingExpirationInSeconds = (long?)unusedExpireTime?.TotalSeconds;
            entry.AbsoluteExpiration = absoluteExpireTime.HasValue ? DateTimeOffset.UtcNow.Add(absoluteExpireTime.Value) : null;

            await _context.SaveChangesAsync(token);
        }

        public async Task RemoveAsync(string key, CancellationToken token = default)
        {
            var entry = await _context.DistributedCache.FindAsync(new object[] { key }, token);
            if (entry != null)
            {
                _context.DistributedCache.Remove(entry);
                await _context.SaveChangesAsync(token);
            }
        }
    }
}

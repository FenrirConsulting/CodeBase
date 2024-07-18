using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities
{
    public class DistributedCacheEntry
    {
        [Key]
        [StringLength(449)]
        public string? Id { get; set; }
        [Required]
        public byte[]? Value { get; set; }
        [Required]
        public DateTimeOffset ExpiresAtTime { get; set; }
        public long? SlidingExpirationInSeconds { get; set; }
        public DateTimeOffset? AbsoluteExpiration { get; set; }
    }
}

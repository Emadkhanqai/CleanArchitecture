using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Pipeline.Contracts
{
    public interface ICacheable
    {
        public string CachingKey { get; set; }
        public bool BypassCache { get; set; }
        public TimeSpan SlidingExpiration { get; set; }
    }
}

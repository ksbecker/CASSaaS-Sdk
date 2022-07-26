using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASSaaS.Sdk
{ 
    public class InjectBatchRequest
    {
        public List<InjectRequest> Addresses { get; set; } = default!;
    }
}

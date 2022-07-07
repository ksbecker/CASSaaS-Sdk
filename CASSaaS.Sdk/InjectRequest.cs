using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASSaaS.Sdk
{
    public class InjectRequest : AddressRequest
    { 
        public string CassAddress1 { get; set; } = default!;
        public string? CassAddress2 { get; set; }
        public string CassCity { get; set; } = default!;
        public string CassState { get; set; } = default!;
        public string CassZip5 { get; set; } = default!;
        public string? CassZip4 { get; set; }
    }
}

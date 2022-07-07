using System.Runtime.Serialization;

namespace CASSaaS.Sdk
{
    public class Response
    {
        public bool Status { get; set; } = true;
        public string? Message { get; set; }
    }
}

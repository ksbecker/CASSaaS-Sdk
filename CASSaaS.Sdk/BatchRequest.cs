namespace CASSaaS.Sdk;

public class BatchRequest
{
    public int RecassOlderThanInDays { get; set; }
    public List<AddressRequest> Addresses { get; set; } = default!;
}

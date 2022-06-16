namespace CASSaaS.Sdk;

public class BatchRequest
{
    public int RecassOlderThanInDays { get; set; } = 90;
    public List<AddressRequest> Addresses { get; set; } = default!;
}

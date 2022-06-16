namespace CASSaaS.Sdk;

public class BatchResponse
{
    public int BatchId { get; set; }
    public int TotalRequested { get; set; }
    public int TotalFound { get; set; }
    public int TotalFirstCassed { get; set; }
    public int TotalRecassed { get; set; }
    public int TotalInvalid { get; set; }
    public int TotalError { get; set; }
    public List<CassedAddressResponse>? Addresses { get; set; }
}

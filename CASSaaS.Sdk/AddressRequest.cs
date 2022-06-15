namespace CASSaaS.Api.Models;

public class AddressRequest
{
    public int AddressId { get; set; }
    public string Address1 { get; set; } = default!;
    public string? Address2 { get; set; }
    public string City { get; set; } = default!;
    public string State { get; set; } = default!;
    public string Zip { get; set; } = default!;
}
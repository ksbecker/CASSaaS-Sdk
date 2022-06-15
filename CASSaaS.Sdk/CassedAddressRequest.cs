namespace CASSaaS.Sdk
{
    public class CassedAddressResponse
    {
        public int AddressId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Zip4 { get; set; }
        public int BatchId { get; set; }
        public bool Invalid { get; set; }
    }
}
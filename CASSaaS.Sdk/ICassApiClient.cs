using Refit;

namespace CASSaaS.Sdk;

public interface ICassApiClient
{
    [Post("/")]
    Task<BatchResponse> BatchAsync(BatchRequest request, CancellationToken cancellationToken = default);
}

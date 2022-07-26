using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace CASSaaS.Sdk;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddCassApiClient(this IServiceCollection services, Action<HttpClient> configureClient) =>
        services.AddRefitClient<ICassApiClient>()
            .ConfigureHttpClient((httpClient) => configureClient(httpClient));
}

using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core;

public static class DependencyInjection
{

    // <summary>
    // Extension method to add Core services to the IServiceCollection.
    // </summary>
    public static IServiceCollection AddCore(this IServiceCollection service)
    {
        return service;
    }
}


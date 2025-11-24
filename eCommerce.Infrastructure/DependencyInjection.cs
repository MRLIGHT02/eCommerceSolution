using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{

    // <summary>
    // Extension method to add infrastructure services to the IServiceCollection.
    // </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection service)
    {
        return service;
    }
}


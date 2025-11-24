using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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


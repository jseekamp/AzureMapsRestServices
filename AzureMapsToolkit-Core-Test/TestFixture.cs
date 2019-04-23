using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AzureMapsToolkit_Core_Test
{
    public class TestFixture
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public TestFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}

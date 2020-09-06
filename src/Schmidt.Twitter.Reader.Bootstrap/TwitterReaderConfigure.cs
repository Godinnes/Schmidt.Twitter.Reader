using Amazon.Util.Internal.PlatformServices;
using Microsoft.Extensions.DependencyInjection;
using Schmidt.Twitter.Reader.Remote.Abstraction;
using Schmidt.Twitter.Reader.Remote.Services;

namespace Schmidt.Twitter.Reader.Bootstrap
{
    public class TwitterReaderConfigure
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly IApplicationSettings _settings;
        public TwitterReaderConfigure(IServiceCollection serviceCollection,
                                      IApplicationSettings settings)
        {
            _serviceCollection = serviceCollection;
            _settings = settings;
        }

        public void ConfigureServices()
        {
            _serviceCollection.AddScoped<ITwitterReaderService, TwitterReaderService>();
        }
    }
}

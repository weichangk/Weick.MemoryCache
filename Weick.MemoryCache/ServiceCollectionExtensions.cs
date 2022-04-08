using Microsoft.Extensions.DependencyInjection;

namespace Weick.MemoryCache
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加Cache缓存
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddCache(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheHandler, MemoryCacheHandler>();
            return services;
        }
    }
}

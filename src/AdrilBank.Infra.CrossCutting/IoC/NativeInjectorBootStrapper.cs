using AdrilBank.Domain.Base.Bus;
using AdrilBank.Domain.Interfaces;
using AdrilBank.Infra.CrossCutting.Bus;
using AdrilBank.Infra.Data.Context;
using AdrilBank.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace AdrilBank.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Bus
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Application

            //Domain

            //Infra
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<AdrilBankContext>();
        }
    }
}

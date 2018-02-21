using ApplicationServices;
using ApplicationServices.Interfaces;
using ApplicationServices.Mappers;
using DataAccess;
using DataAccess.Interfaces;
using Microsoft.Practices.Unity;
using System.Data.Entity;

namespace UnityBootstrapper
{
    public static class AppUnityInitializer
    {
        private static bool _initialised;
        public static void Initialize()
        {
            if (!_initialised)
            {
                AppContainer.Current.RegisterInstance<string>("DbConnectionString", "SakeDB");

                Database.SetInitializer<ArtistDbContext>(new CreateDatabaseIfNotExists<ArtistDbContext>());

                AppContainer.Current
                    .RegisterType<ArtistDbContext>(new PerResolveLifetimeManager())
                    .RegisterType<IArtistRepository, ArtistRepository>()
                    .RegisterType<IArtistService, ArtistService>();

                ArtistAutoMapper.Initialize();

            }
            _initialised = true;
        }
    }
}

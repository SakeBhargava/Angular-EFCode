using Microsoft.Practices.Unity;

namespace UnityBootstrapper
{
    public static class AppContainer
    {
        static AppContainer()
        {
            Current = new UnityContainer();
        }

        public static IUnityContainer Current { get; private set; }
    }
}

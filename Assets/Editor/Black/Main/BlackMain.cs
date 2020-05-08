using Black.Entity;

namespace Black.Main
{
    [UnityEditor.InitializeOnLoad]
    public class BlackMain
    {
        static BlackMain()
        {
            Initialize();
        }

        private static void Initialize()
        {
            EntityModuleSetup.Setup();
        }
    }
}
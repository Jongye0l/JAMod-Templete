using JALib.Bootstrap;
using UnityModManagerNet;

namespace MyMod {
    public class Bootstrap {
        public static void Setup(UnityModManager.ModEntry modEntry) => JABootstrap.Load(modEntry);
    }
}
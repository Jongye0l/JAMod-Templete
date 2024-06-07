using JALib.Bootstrap;
using UnityModManagerNet;

namespace JAMod_Templete {
    public class Bootstrap {
        public static void Setup(UnityModManager.ModEntry modEntry) => JABootstrap.Load(modEntry);
    }
}
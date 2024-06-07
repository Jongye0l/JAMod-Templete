using JALib.Core;
using UnityModManagerNet;

namespace JAMod_Templete {
    public class Main : JAMod {
        public Main(UnityModManager.ModEntry modEntry) : base(modEntry, false, null, typeof(Main)) {
            
        }

        protected override void OnEnable() {
            base.OnEnable();
        }
        protected override void OnDisable() {
            base.OnDisable();
        }
    }
}
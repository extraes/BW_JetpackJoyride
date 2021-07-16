using MelonLoader;
using ModThatIsNotMod;
using ModThatIsNotMod.BoneMenu;
using StressLevelZero.Props.Weapons;
using StressLevelZero.Rig;
using StressLevelZero.VFX;
using StressLevelZero.VRMK;
using System;
using UnityEngine;

namespace JetpackJoyride
{
    public static class BuildInfo
    {
        public const string Name = "Jetpack Joyride"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "extraes"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class JetpackJoyride : MelonMod
    {
        public override void OnApplicationStart()
        {
            var menu = MenuManager.CreateCategory("Jetpack Joyride", Color.grey);
            menu.CreateBoolElement("Enabled/disabled", Color.yellow, false, new Action<bool>((bool b) =>
            {
                if (b)
                {
                    Hooking.OnPostFireGun += Hooking_OnPostFireGun;
                }
                else Hooking.OnPostFireGun -= Hooking_OnPostFireGun;
            }));
            menu.CreateBoolElement("Move only with guns", Color.yellow, false, new Action<bool>((bool b) =>
            {
                var rig = GameObject.FindObjectOfType<RigManager>();
                if (rig != null)
                {
                    if (b) rig.ControllerRig.maxVelocity = 0;
                    else rig.ControllerRig.maxVelocity = 2;
                }
            }));
        }

        private void Hooking_OnPostFireGun(Gun gun)
        {
            bool isPlayer = gun.transform.parent.gameObject.GetComponent<DespawnMeshVFX>() == null;
            if (isPlayer)
            {
                GameObject.FindObjectOfType<PhysBody>()?.AddVelocityChange(-gun.transform.forward * 5);
            }
        }
    }
}

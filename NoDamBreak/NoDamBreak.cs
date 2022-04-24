using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PilotableStranger
{
    public class PilotableStranger : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"No Dam Break Mod Loaded!");

            ModHelper.HarmonyHelper.AddPrefix<RingWorldController>("BreakDam", typeof(PilotableStranger), nameof(PilotableStranger.NoDamBreak));
            ModHelper.HarmonyHelper.AddPrefix<RingWorldController>("DamageDam", typeof(PilotableStranger), nameof(PilotableStranger.NoDamDamage));

        }

        private static bool NoDamBreak()
        {
            return false;
        }

        private static bool NoDamDamage()
        {
            return false;
        }
    }
}

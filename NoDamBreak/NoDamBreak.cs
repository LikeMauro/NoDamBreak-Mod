using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NoDamBreakMod
{
    public class NoDamBreakMod : ModBehaviour
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

            ModHelper.HarmonyHelper.AddPrefix<RingWorldController>("BreakDam", typeof(NoDamBreakMod), nameof(NoDamBreakMod.NoDamBreak));
            ModHelper.HarmonyHelper.AddPrefix<RingWorldController>("DamageDam", typeof(NoDamBreakMod), nameof(NoDamBreakMod.NoDamDamage));

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

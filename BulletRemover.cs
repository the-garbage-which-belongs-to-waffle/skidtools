using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using BulletRemoverMod;
using Harmony;
using UnityEngine;
using NodeCanvas.Tasks.Actions;

[assembly: MelonInfo(typeof(BulletRemover), "Bullet Remover", "1.0.0", "Waffle (but actually mostly october)")]
[assembly: MelonGame("SUPERHOT_Team", "SUPERHOT_VR")]

namespace BulletRemoverMod
{
    class BulletRemover : MelonMod
    {
        [HarmonyPatch(typeof(Bullet), "Update", MethodType.Normal)]
        private static class destroyBullets {
            private static void Postfix(Bullet  __instance) {
                UnityEngine.Object.Destroy(__instance);
            }
        }
    }
}

using BepInEx;
using HarmonyLib;
using UnityEngine;
using System;
using System.Reflection;
using HarmonyLib.Tools;
using BepInEx.Harmony;

namespace sittsm_unbreakable_environment
{
    [BepInProcess("Stick It To The (Stick) Man.exe")]
    [BepInPlugin("uniquename.sittsm.unbreakable-environment", "unbreakable-environment", "0.0.0.0")]
    public class enable : BaseUnityPlugin
    {

        public void Awake()
        {
            var harmony = new Harmony("uniquename.sittsm.unbreakable-environment");
            harmony.PatchAll();
        }

        public const string modID = "uniquename.sittsm.unbreakable-environment";
        public const string modName = "unbreakable-environment";
    }

    [HarmonyPatch(typeof(BrickBreaker), "Start")]
    public class patch0 : MonoBehaviour
    {
        
        public static bool Prefix(BrickBreaker __instance)
        {
            Destroy(__instance.GetComponent<Rigidbody>());
            return false;
        }
    }


    [HarmonyPatch(typeof(BrickBreaker), "BreakBrick")]
    public class patch1 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(BrickBreaker), "LateUpdate")]
    public class patch2 : MonoBehaviour
    {
        public static bool BreakbrickupdatePatch()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(BrickBreaker), "BreakBricks")]
    public class patch3 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Brick), "Smash")]
    public class patch4 : MonoBehaviour
    {
        public static bool Prefix(Brick __instance)
        {
            Destroy(__instance.GetComponent<Rigidbody>());
            return false;
        }
    }

    [HarmonyPatch(typeof(BreakableProp), "FixedUpdate")]
    public class patch5 : MonoBehaviour
    {
        public static bool CDPatch()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(CollisionDamager), "Awake")]
    public class patch6 : MonoBehaviour
    {
        public static bool CD2Patch()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(CollisionDamager), "Start")]
    public class patch7 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    

    [HarmonyPatch(typeof(BreakableProp), "OnCollisionEnter")]
    public class patch9 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(BreakableProp), "BreakApart")]
    public class patch10 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(BreakableProp), "FixedUpdate")]
    public class patch11 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(BreakableProp), "Awake")]
    public class patch12 : MonoBehaviour
    {
        public static bool Prefix(BreakableProp __instance, ref GameObject ___piecesHolder)
        {
            if (___piecesHolder != null)
            {
                ___piecesHolder.SetActive(false);
            }

            Destroy(__instance.GetComponent<Rigidbody>());
            return false;
        }
    }

    [HarmonyPatch(typeof(ObjectCollisionDamager), "OnCollisionEnter")]
    public class patch13 : MonoBehaviour
    {
        public static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(ObjectCollisionDamager), "Awake")]
    public class patch14 : MonoBehaviour
    {

        public static bool Prefix(ObjectCollisionDamager __instance)
        {
            Destroy(__instance.GetComponent<Rigidbody>());
            return false;
        }
    }
}
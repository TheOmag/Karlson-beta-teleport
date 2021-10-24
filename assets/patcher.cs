using HarmonyLib;
using BepInEx;
using BepInEx.Logging;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Reflection;

namespace TPkarlson
{

    [BepInPlugin("org.Crafterbot.karlson.TPkarlson", "TP karlson", "5.4.17.0")]
    public class MyPatcher : BaseUnityPlugin
    {
        public void Awake()
        {
            var harmony = new Harmony("com.Crafterbot.karlsonMod.TPkarlson");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
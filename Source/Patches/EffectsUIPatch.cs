using HarmonyLib;
using Reptile;
using System.Reflection;
using UnityEngine;

namespace BRC_OLED;

[HarmonyPatch(typeof(EffectsUI))]
public class EffectsUIPatch
{
    [HarmonyPrefix]
    [HarmonyPatch("Init")]
    public static void Init_Prefix()
    {
        var niceBlack = typeof(EffectsUI).GetField("niceBlack", BindingFlags.Public | BindingFlags.Static);
        niceBlack?.SetValue(EffectsUI.niceBlack, new Color(1f, 0f, 0f, 1f));

        var niceClear = typeof(EffectsUI).GetField("niceClear", BindingFlags.Public | BindingFlags.Static);
        niceClear?.SetValue(EffectsUI.niceClear, new Color(1f, 0f, 0f, 0f));
    }
}

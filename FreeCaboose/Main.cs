using DV;
using HarmonyLib;
using System.Reflection;
using UnityModManagerNet;

namespace FreeCaboose
{
    public class Main
    {
        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            return true;
        }
        
        [HarmonyPatch(typeof(CommsRadioCrewVehicle), "SummonPrice", MethodType.Getter)]
        static class FreeCaboose_Patch
        {            
            static float Postfix(float f)
            {
                return 0.0f;
            }
        }
    }
}

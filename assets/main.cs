using HarmonyLib;
using UnityEngine;

namespace TPkarlson
{
    [HarmonyPatch(typeof(PlayerMovement))]
    [HarmonyPatch("Update", MethodType.Normal)]

    public class code
    {
        private static bool hitOneOff = false;

        private static void Postfix(PlayerMovement __instance)
        {
            if (Input.GetKey(KeyCode.T) && !hitOneOff)
            {
                Ray mainRay = new Ray(__instance.rb.position + new Vector3(0f, 0.6f, 0f), __instance.playerCam.transform.forward);
                Physics.Raycast(mainRay, 10000);
                RaycastHit hit;
                if (Physics.Raycast(mainRay, out hit))
                {
                    __instance.rb.transform.position = hit.point + new Vector3(0f, 0.4f, 0f);
                }
                hitOneOff = true;
            }
            if(!Input.GetKey(KeyCode.T))
            {
                hitOneOff = false;
            }
        }
    }
}
/*
 resouces

tp code
__instance.rb.position = new Vector3(0f, 0f, 0f);

 
 */
using EmotesAPI;
using GaleShockTrooper.Survivors.GaleShockTrooperSurvivor;
using RoR2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace GaleShockTrooper.Modules
{
    internal static class ModCompat
    {
        internal static void Init()
        {
            EmoteAPI.Init();
        }

        internal static class EmoteAPI
        {
            internal static bool pluginLoaded;
            internal static void Init()
            {
                pluginLoaded = BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.weliveinasociety.CustomEmotesAPI");
                if (pluginLoaded)
                {
                    SetupEmoteSkeleton();
                }
            }

            [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
            private static void SetupEmoteSkeleton()
            {
                On.RoR2.SurvivorCatalog.Init += (orig) =>
                {
                    orig();
                    if (GaleShockTrooperSurvivor.instance != null)
                    {
                        foreach (var item in SurvivorCatalog.allSurvivorDefs)
                        {
                            if (item.bodyPrefab.name == "GaleShockTrooperBody")
                            {
                                var skele = GaleShockTrooperSurvivor.instance.assetBundle.LoadAsset<UnityEngine.GameObject>("mdlGaleShockTrooperEmote.prefab");
                                EmotesAPI.CustomEmotesAPI.ImportArmature(item.bodyPrefab, skele);
                                skele.GetComponentInChildren<BoneMapper>().scale = 1.5f;

                                CustomEmotesAPI.animChanged += CustomEmotesAPI_animChanged;
                                break;
                            }
                        }
                    }
                };
            }

            private static void CustomEmotesAPI_animChanged(string newAnimation, BoneMapper mapper)
            {
                if (mapper.transform.name == "mdlGaleShockTrooperEmote")
                {
                    Transform gun = mapper.transform.parent.Find("trooper_gun");
                    if (gun)
                    {
                        if (newAnimation == "none")
                        {
                            gun.gameObject.SetActive(true);
                        }
                        else
                        {
                            gun.gameObject.SetActive(false);
                        }
                    }
                }
            }
        }
    }
}

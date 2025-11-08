using GaleShockTrooper.Modules;
using GaleShockTrooper.Modules.Characters;
using RoR2;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

/* for custom copy format in keb's helper
{childName},
                    {localPos}, 
                    {localAngles},
                    {localScale})
*/

namespace GaleShockTrooper.Characters.Drones.GaleShockTrooperDrone
{
    public class CharacterItemDisplaySetup : ItemDisplaysBase
    {
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(Addressables.LoadAssetAsync<ItemDef>("RoR2/DLC1/DroneWeapons/DroneWeaponsBoost.asset").WaitForCompletion(),
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC1/DroneWeapons/DisplayDroneWeaponLauncher.prefab").WaitForCompletion(),
"Body",
new Vector3(0F, 0.04F, -0.32F),
new Vector3(0F, 180F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    ),
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC1/DroneWeapons/DisplayDroneWeaponMinigun.prefab").WaitForCompletion(),
"Body",
new Vector3(0F, -0.07F, 0F),
new Vector3(0F, 270F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)
                    ),
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC1/DroneWeapons/DisplayDroneWeaponRobotArm.prefab").WaitForCompletion(),
"Body",
new Vector3(-0.37497F, 0.08954F, 0.00708F),
new Vector3(0F, 0F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));
        }
    }
}
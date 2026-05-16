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

namespace GaleShockTrooper.Survivors.GaleShockTrooperSurvivor.Content
{
    public class CharacterItemDisplaySetup : ItemDisplaysBase
    {
        public static GameObject CustomShatDisplay;
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DronesDropDynamite"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DronesDropDynamiteDisplay"),
                    "Backpack",
                    new Vector3(-0.00337F, -0.12093F, 0.02046F),
                    new Vector3(32.5382F, 353.06F, 176.9222F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Parry"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("ParryDisplay"),
                    "Backpack",
                    new Vector3(-0.00474F, -0.16635F, -0.09402F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));

            /*itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MasterCore"],
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC3/Items/MasterCore/DisplayPowerOrbSphereFollower.prefab").WaitForCompletion(),
                    "Tail2",
                    new Vector3(0f, 0f, 0f),
                    new Vector3(0f, 0f, 0f),
                    new Vector3(1f, 1f, 1f)
                    )
                ));*/

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MasterBattery"],
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC3/Items/MasterBattery/DisplayPowerOrbSphereFollower.prefab").WaitForCompletion(),
                    "Base",
                    new Vector3(-0.41902F, 0.01955F, 0.55403F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PowerCube"],
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC3/Items/PowerCube/DisplayPowerCubeFollower.prefab").WaitForCompletion(),
                    "Base",
                    new Vector3(-0.75877F, 0.02561F, 0.47629F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PowerPyramid"],
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC3/Items/PowerPyramid/DisplayPowerPyramidFollower.prefab").WaitForCompletion(),
                    "Base",
                    new Vector3(-1.28883F, 0.03926F, 0.58036F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CookedSteak"],
                ItemDisplays.CreateDisplayRule(Addressables.LoadAssetAsync<GameObject>("RoR2/DLC3/Items/CookedSteak/DisplayCookedSteakCurved.prefab").WaitForCompletion(),
                    "Head",
                    new Vector3(-0.10975F, 0.20281F, -0.12022F),
                    new Vector3(297.1067F, 162.2858F, 109.9649F),
                    new Vector3(-0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayExtraEquipment"),
                        "ThighL",
                        new Vector3(-0.07819F, 0.07083F, 0.09924F),
                        new Vector3(350.7468F, 312.019F, 171.3385F),
                        new Vector3(0.1F, 0.1F, 0.1F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BonusHealthBoost"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayQuickFix"),
                    "ShoulderL",
                    new Vector3(-0.0119F, 0.25304F, 0.04544F),
                    new Vector3(0.62284F, 29.23043F, 35.40512F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Stew"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("StewDisplay"),
                    "ShoulderR",
                    new Vector3(0.00387F, 0.25927F, 0.00653F),
                    new Vector3(37.49449F, 99.81663F, 14.64683F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["UltimateMeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("UltimateMealDisplay"),
                        "Head",
                        new Vector3(0F, 0.3F, 0F),
                        new Vector3(0F, 0F, 0F),
                        new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WyrmOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWyrmOnHit"),
                    "Backpack",
                    new Vector3(0.06495F, 0.0237F, 0.00476F),
                    new Vector3(359.3283F, 276.7793F, 11.97136F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShockDamageAura"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("ShockDamageAuraDisplay"),
                    "Head",
                    new Vector3(0F, 0.21809F, -0.00173F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShieldBooster"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBooster"),
                    "UpperarmR",
                    new Vector3(0.01774F, 0.21391F, -0.01381F),
                    new Vector3(341.8083F, 52.07731F, 285.3918F),
                    new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SpeedOnPickup"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("SpeedOnPickupDisplay"),
                    "Backpack",
                    new Vector3(0F, -0.10403F, -0.06643F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PhysicsProjectile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("PhysicsProjectileDisplay"),
                    "Backpack",
                    new Vector3(-0.01552F, 0.07434F, -0.12045F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Duplicator"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDuplicator"),
                    "Tail1",
                    new Vector3(-0.05611F, 0.02966F, 0.16155F),
                    new Vector3(0F, 180F, 90F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SharedSuffering"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("SharedSufferingDisplay"),
                    "Backpack",
                    new Vector3(0F, -0.05341F, -0.06371F),
                    new Vector3(270F, 0F, 0F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["JumpDamageStrike"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJumpDamageStrike"),
                    "FootR",
                    new Vector3(-0.05381F, -0.03769F, 0.05384F),
                    new Vector3(315.8147F, 334.9754F, 165.2825F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJumpDamageStrike"),
                    "FootL",
                    new Vector3(0.04455F, -0.04463F, 0.05855F),
                    new Vector3(315.2382F, 31.96171F, 179.5F),
                    new Vector3(0.4F, 0.4F, 0.4F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnCooldown"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBarrierOnCooldown"),
                    "ThighL",
                    new Vector3(-0.13641F, 0.23834F, 0.04211F),
                    new Vector3(-0.00001F, 180F, 180F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritAtLowerElevation"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("CritAtLowerElevationDisplay"),
                    "Tail3",
                    new Vector3(0.02014F, 0.09681F, -0.00757F),
                    new Vector3(284.6751F, 90.55054F, 36.18997F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Thorns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRazorwireLeft"),
                    "Tail2",
                    new Vector3(-0.00236F, -0.0297F, -0.01209F),
                    new Vector3(278.8168F, 314.9167F, 48.38494F),
                    new Vector3(0.5F, 0.5F, 0.35F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTip"),
                    "Gun",
                    new Vector3(0F, -0.03F, 0.3F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.4F, 0.4F, 0.4F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Pearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPearl"),
                    "Gun",
                    new Vector3(0F, 0F, 0.2F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.08F, 0.08F, 0.08F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShinyPearl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                    "Gun",
                    new Vector3(0F, 0F, 0.1F),
                    new Vector3(0F, 180F, 0F),
                    new Vector3(0.08F, 0.08F, 0.08F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Clover"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayClover"),
                    "Backpack",
                    new Vector3(0.01152F, 0.15839F, -0.09838F),
                    new Vector3(304.5544F, 256.8649F, 99.09082F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["UtilitySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Backpack",
                    new Vector3(-0.0815F, -0.01835F, 0.02435F),
                    new Vector3(5.56315F, 355.6273F, 336.9797F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Backpack",
                    new Vector3(0.0815F, -0.01835F, 0.02435F),
                    new Vector3(5.56315F, 355.6273F, 23.0203F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoreMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateL",
                    new Vector3(0.03f, -0.01539116f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateR",
                    new Vector3(-0.03f, -0.01539116f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateL",
                    new Vector3(0.03f, 0.03329227f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateR",
                    new Vector3(-0.03f, 0.03329227f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateL",
                    new Vector3(0.03f, -0.06f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayICBM"),
                    "GunplateR",
                    new Vector3(-0.03f, -0.06f, 0.05F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.028F, 0.028F, 0.028F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RegeneratingScrap"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRegeneratingScrap"),
                    "Backpack",
                    new Vector3(0.12694F, 0.17655F, -0.01814F),
                    new Vector3(34.96067F, 300.9774F, 35.1359F),
                    new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StunChanceOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStunGrenade"),
                        "Pelvis",
                        new Vector3(-0.19498F, -0.03776F, 0.01055F),
                        new Vector3(68.0901F, 91.3905F, 1.4843F),
                        new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SecondarySkillMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                    "Pelvis",
                    new Vector3(-0.17498F, -0.04273F, -0.0868F),
                    new Vector3(24.23658F, 125.6099F, 333.7793F),
                    new Vector3(0.04F, 0.04F, 0.04F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBattery"),
                    "Pelvis",
                    new Vector3(0.20315F, -0.02821F, 0.01147F),
                    new Vector3(64.35213F, 260.4114F, 168.8678F),
                    new Vector3(0.08F, 0.08F, 0.08F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Hoof"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHoof"),
                    "ShinR",
                    new Vector3(0.05773F, 0.09391F, -0.0936F),
                    new Vector3(58.82795F, 349.0701F, 42.69231F),
                    new Vector3(0.07F, 0.07F, 0.07F)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHoof"),
                    "ShinL",
                    new Vector3(-0.10191F, 0.0957F, -0.07128F),
                    new Vector3(64.52972F, 29.94946F, 336.29F),
                    new Vector3(0.07F, 0.07F, 0.07F)
                    ),
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.RightCalf) //intentional jank
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireRing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireRing"),
                    "Tail3",
                    new Vector3(0.02329F, 0.03094F, -0.01047F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IceRing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIceRing"),
                    "Tail3",
                    new Vector3(0.02675F, 0.14566F, -0.00201F),
                    new Vector3(90F, 0F, 0F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlasses"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(0F, 0.155F, 0.121F),
                    new Vector3(315F, 0F, 0F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LightningStrikeOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayChargedPerforator"),
                    "Head",
                    new Vector3(0F, 0.2F, 0.01F),
                    new Vector3(0F, 0F, 180F),
                    new Vector3(0.7F, 0.7F, 0.7F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireballsOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFireballsOnHit"),
                    "Head",
                    new Vector3(0F, 0.21098F, 0.16896F),
                    new Vector3(300F, 0F, 180F),
                    new Vector3(0.04F, 0.04F, 0.04F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraStatsOnLevelUp"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPrayerBeads"),
                    "Chest",
                    new Vector3(0.03239F, 0.22821F, 0.02458F),
                    new Vector3(340.2114F, 299.9401F, 339.7234F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreaseDamageOnMultiKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIncreaseDamageOnMultiKill"),
                    "Tail0",
                    new Vector3(0.00383F, 0.20779F, -0.00417F),
                    new Vector3(44.89295F, 4.37085F, 185.917F),
                    new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreasePrimaryDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayIncreasePrimaryDamage"),
                    "Pelvis",
                    new Vector3(0.10958F, -0.04417F, 0.13705F),
                    new Vector3(20.27158F, 345.3782F, 330.0971F),
                    new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SpeedBoostPickup"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElusiveAntlersLeft"),
                    "Head",
                    new Vector3(-0.07199F, 0.11884F, -0.01768F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.45F, 0.45F, 0.45F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElusiveAntlersRight"),
                    "Head",
                    new Vector3(0.06589F, 0.11341F, -0.00862F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.45F, 0.45F, 0.45F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AlienHead"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAlienHead"),
                    "Chest",
                    new Vector3(0.12706F, 0.03448F, 0.06134F),
                    new Vector3(9.50851F, 2.61665F, 153.445F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedPerNearbyAllyOrEnemy"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRageCrystal"),
                    "Tail4",
                    new Vector3(0, 0, 0),
                    new Vector3(67.88409F, 267.2958F, 311.0219F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TeleportOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeleportOnLowHealth"),
                    "GunplateL",
                    new Vector3(-0.0179F, -0.05322F, 0.00311F),
                    new Vector3(0F, 270F, 0F),
                    new Vector3(0.6F, 0.6F, 0.6F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DelayedDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDelayedDamage"),
                    "ShinL",
                    new Vector3(-0.00186F, 0.02287F, 0.0892F),
                    new Vector3(354.158F, 8.06312F, 56.36167F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["KnockBackHitEnemies"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKnockbackFin"),
                    "Tail0",
                    new Vector3(-0.01649F, 0.10845F, 0.09542F),
                    new Vector3(47.10278F, 177.8373F, 180.9326F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraShrineItem"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayChanceDoll"),
                    "Backpack",
                    new Vector3(0.05785F, 0.1272F, -0.08404F),
                    new Vector3(357.5297F, 181.0144F, 100.3895F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TriggerEnemyDebuffs"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayNoxiousThorn"),
                    "Head",
                    new Vector3(0.00903F, 0.1291F, 0.05541F),
                    new Vector3(2.53308F, 94.8412F, 345.8926F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LowerPricedChests"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLowerPricedChests"),
                    "Base",
                    new Vector3(-0.72933F, -0.64158F, 0.5645F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StunAndPierce"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElectricBoomerang"),
                    "Tail0",
                    new Vector3(-0.00235F, 0.03442F, 0.13F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BoostAllStats"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGrowthNectar"),
                    "Head",
                    new Vector3(-0.00305F, 0.06742F, 0.03835F),
                    new Vector3(82.49606F, 128.1022F, 145.4886F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MeteorAttackOnHighDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMeteorAttackOnHighDamage"),
                    "Head",
                    new Vector3(-0.01431F, 0.16259F, 0.13687F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.35F, 0.35F, 0.35F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorPlate"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                    "Pelvis",
                    new Vector3(-0.00035F, 0.09872F, -0.08725F),
                    new Vector3(77.34415F, 189.7604F, 189.3929F),
                    new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedAndMoveSpeed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCoffee"),
                    "ThighL",
                    new Vector3(-0.10864F, 0.11365F, -0.07078F),
                    new Vector3(1.26355F, 236.5369F, 207.309F),
                    new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AttackSpeedOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                    "Head",
                    new Vector3(-0.00535F, 0.12612F, -0.03284F),
                    new Vector3(342.3606F, 359.1009F, 358.9628F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AutoCastEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFossil"),
                    "ThighL",
                    new Vector3(-0.03732F, 0.03897F, 0.11801F),
                    new Vector3(346.4093F, 52.5954F, 359.8542F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bandolier"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBandolier"),
                    "Chest",
                    new Vector3(-0.05929F, -0.01077F, 0.01516F),
                    new Vector3(311.9094F, 251.8104F, 261.5825F),
                    new Vector3(0.5F, 0.6F, 0.6F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrooch"),
"Chest",
new Vector3(-0.15225F, 0.03519F, 0.01904F),
new Vector3(72.33425F, 182.1625F, 242.4731F),
new Vector3(0.3F, 0.3F, 0.3F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrierOnOverHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAegis"),
                    "ForearmL",
                    new Vector3(0.07507F, 0.07327F, -0.01933F),
                    new Vector3(72.60795F, 36.08724F, 125.3977F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Bear"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBear"),
                    "Stomach",
                    new Vector3(-0.03077F, -0.03934F, 0.14533F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BearVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBearVoid"),
                    "Stomach",
                    new Vector3(-0.03077F, -0.03934F, 0.14533F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BeetleGland"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                    "ThighR1",
                    new Vector3(-0.18792F, 0.11263F, 0.03898F),
                    new Vector3(24.44444F, 264.7158F, 89.32608F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Behemoth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBehemoth"),
                    "ThighR",
                    new Vector3(0.00428F, 0.07545F, 0.13836F),
                    new Vector3(17.71981F, 98.18526F, 176.4893F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitAndExplode"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
                    "Pelvis",
                    new Vector3(-0.10703F, -0.06018F, -0.11876F),
                    new Vector3(40.45087F, 249.1818F, 158.3023F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BleedOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTriTipVoid"),
                    "Gun",
                    new Vector3(0F, -0.03F, 0.3F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.4F, 0.4F, 0.4F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BonusGoldPackOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTome"),
"ThighR",
new Vector3(0.11364F, 0.09144F, 0.06294F),
new Vector3(1.01091F, 56.63474F, 355.9843F),
new Vector3(0.05F, 0.05F, 0.05F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAPRound"),
"GunplateR",
new Vector3(0.01088F, -0.00082F, -0.0115F),
 new Vector3(90F, 90F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BounceNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHook"),
                    "ShoulderR",
                    new Vector3(-0.08133F, 0.17466F, 0.06842F),
                    new Vector3(353.5309F, 352.1945F, 335.7864F),
                    new Vector3(0.35F, 0.35F, 0.35F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkulele"),
                    "Backpack",
                    new Vector3(0.00199F, -0.04756F, -0.10077F),
                    new Vector3(1.566F, 164.3452F, 54.49899F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ChainLightningVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayUkuleleVoid"),
                    "Backpack",
                    new Vector3(0.00199F, -0.04756F, -0.10077F),
                    new Vector3(1.566F, 164.3452F, 54.49899F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CloverVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCloverVoid"),
                    "Backpack",
                    new Vector3(0.01152F, 0.15839F, -0.09838F),
                    new Vector3(304.5544F, 256.8649F, 99.09082F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CooldownOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkull"),
                    "HandL",
                    new Vector3(-0.14655F, 0.16971F, 0.00332F),
                    new Vector3(13.39876F, 286.6394F, 222.3838F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritDamage"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserSight"),
                    "Head",
                    new Vector3(0.06957F, 0.0579F, 0.08963F),
                    new Vector3(81.76341F, 49.66093F, 332.8359F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritGlassesVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlassesVoid"),
                    "Head",
                    new Vector3(0F, 0.155F, 0.121F),
                    new Vector3(315F, 0F, 0F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Crowbar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCrowbar"),
                    "Backpack",
                    new Vector3(-0.15425F, 0.05144F, 0.03124F),
                    new Vector3(3.73689F, 341.4923F, 354.9942F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Dagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDagger"),
                    "ShoulderR",
                    new Vector3(0, 0, 0),
                    new Vector3(26.09869F, 24.30682F, 146.2289F),
                    new Vector3(0.75F, 0.75F, 0.75F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathMark"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathMark"),
                    "Tail0",
                    new Vector3(-0.11412F, 0.08469F, 0.04677F),
                    new Vector3(359.3568F, 357.1338F, 234.5591F),
                    new Vector3(0.025F, 0.025F, 0.025F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElementalRingVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVoidRing"),
                    "Tail3",
                    new Vector3(0.00928F, 0.10906F, -0.0023F),
                    new Vector3(88.07655F, 353.4808F, 78.72786F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EmpowerAlways"],
                ItemDisplays.CreateLimbMaskDisplayRule(LimbFlags.Head),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHeadNeck"),
                    "Head",
                    new Vector3(0.00032F, -0.06201F, 0.0138F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHead"),
                    "Head",
                    new Vector3(-0.00166F, 0.10606F, 0.00093F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.75F, 0.75F, 0.75F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EnergizedOnEquipmentUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarHorn"),
                    "Head",
                    new Vector3(-0.06755F, 0.01318F, 0.25228F),
                    new Vector3(18.31362F, 259.6912F, 11.94619F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EquipmentMagazineVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFuelCellVoid"),
                    "Pelvis",
                    new Vector3(0.20315F, -0.02821F, 0.01147F),
                    new Vector3(64.35213F, 260.4114F, 168.8678F),
                    new Vector3(0.08F, 0.08F, 0.08F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExecuteLowHealthElite"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGuillotine"),
                    "ForearmR",
                    new Vector3(-0.11195F, 0.22944F, 0.02109F),
                    new Vector3(5.90683F, 352.5358F, 282.1368F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeath"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                    "ThighR",
                    new Vector3(0.16231F, 0.05996F, -0.06133F),
                    new Vector3(353.7531F, 289.5826F, 200.8483F),
                    new Vector3(0.04F, 0.04F, 0.04F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExplodeOnDeathVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWillowWispVoid"),
                    "ThighR",
                    new Vector3(0.16231F, 0.05996F, -0.06133F),
                    new Vector3(353.7531F, 289.5826F, 200.8483F),
                    new Vector3(0.04F, 0.04F, 0.04F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLife"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippo"),
                    "ShinR",
                    new Vector3(0.09416F, -0.00197F, 0.05577F),
                    new Vector3(339.9112F, 94.61781F, 138.758F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ExtraLifeVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHippoVoid"),
                    "ShinR",
                    new Vector3(0.09416F, -0.00197F, 0.05577F),
                    new Vector3(339.9112F, 94.61781F, 138.758F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FocusConvergence"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
"Base",
new Vector3(-0.78881F, 0.16863F, 0.73955F),
new Vector3(0F, 0F, 0F),
new Vector3(0.11F, 0.11F, 0.11F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FallBoots"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "ShinL",
                    new Vector3(0, 0, 0),
                    new Vector3(0, 0, 0),
                    new Vector3(0.25F, 0.25F, 0.25F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "ShinR",
                    new Vector3(0, 0, 0),
                    new Vector3(0, 0, 0),
                    new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FragileDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDelicateWatch"),
                    "ShinL",
                    new Vector3(0.01345F, 0.08105F, -0.0094F),
                    new Vector3(282.4221F, 98.83555F, 329.0534F),
                    new Vector3(0.7F, 1F, 0.7F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GhostOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMask"),
                    "Head",
                    new Vector3(0.00088F, 0.05039F, 0.12008F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.47863F, 0.44695F, 0.4F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GhostOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMask"),
                    "Head",
                    new Vector3(0.00088F, 0.05039F, 0.12008F),
                    new Vector3(0, 0, 0),
                    new Vector3(0.47863F, 0.44695F, 0.4F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBoneCrown"),
                    "Head",
                    new Vector3(-0.00117F, 0.05804F, 0.02664F),
                    new Vector3(0, 0, 0),
                    new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldOnHurt"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRollOfPennies"),
                    "ThighL1",
                    new Vector3(0.19605F, -0.09771F, 0.07283F),
                    new Vector3(74.37505F, 23.61701F, 300.5408F),
                    new Vector3(0.7F, 0.7F, 0.7F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfAttackSpeedHalfCooldowns"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderNature"),
                "ShoulderR",
                new Vector3(-0.01271F, 0.27127F, 0.00468F),
                new Vector3(342.1932F, 320.592F, 304.5729F),
                new Vector3(0.6F, 0.6F, 0.6F)
                )
            ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HalfSpeedDoubleHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarShoulderStone"),
                    "ShoulderL",
                    new Vector3(-0.02646F, 0.27698F, 0.05546F),
                    new Vector3(20.30007F, 240.1114F, 271.8848F),
                    new Vector3(0.6F, 0.6F, 0.6F)
                )
            ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HeadHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySkullcrown"),
                    "Stomach",
                    new Vector3(0.00005F, 0.04429F, 0.00725F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.45F, 0.12F, 0.12F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WarCryOnMultiKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPauldron"),
                    "ShoulderR",
                    new Vector3(0.02279F, 0.26913F, 0.03572F),
                    new Vector3(3.55631F, 30.37143F, 343.4723F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealOnCrit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScythe"),
                    "Backpack",
                    new Vector3(-0.01327F, 0.04504F, -0.09264F),
                    new Vector3(301.0731F, 257.3573F, 109.6931F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Icicle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                    "Base",
                    new Vector3(0.78954F, -0.24892F, 0.62346F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealingPotion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayHealingPotion"),
                    "Pelvis",
                    new Vector3(0.18141F, -0.05561F, 0.05472F),
                    new Vector3(338.4952F, 184.8903F, 207.9614F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["HealWhileSafe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySnail"),
                    "Backpack",
                    new Vector3(-0.10822F, 0.16983F, 0.00847F),
                    new Vector3(11.94675F, 337.4264F, 49.71028F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IgniteOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasoline"),
                    "ThighL",
                    new Vector3(-0.03813F, 0.20756F, 0.15193F),
                    new Vector3(84.31649F, 195.6799F, 152.0393F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ImmuneToDebuff"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRainCoatBelt"),
                    "Pelvis",
                    new Vector3(-0.00018F, 0.00014F, -0.06183F),
                    new Vector3(2.28F, 0F, 180F),
                    new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["IncreaseHealing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                "Head",
                new Vector3(0.06104F, 0.1151F, 0.04013F),
                new Vector3(0F, 90F, 0F),
                new Vector3(0.3F, 0.3F, 0.3F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                "Head",
                new Vector3(-0.06104F, 0.1151F, 0.04013F),
                new Vector3(0F, 270F, 0F),
                new Vector3(-0.3F, 0.3F, 0.3F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Infusion"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInfusion"),
"Backpack",
new Vector3(0.16487F, -0.01588F, 0.00038F),
new Vector3(0F, 90F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Meteor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMeteor"),
                    "Base",
                    new Vector3(1.02137F, 0.49722F, 0.74879F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Blackhole"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravCube"),
"Base",
new Vector3(0.79248F, -0.83562F, 0.46792F),
new Vector3(0F, 0F, 0F),
new Vector3(1F, 1F, 1F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunter"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornGhost"),
                    "Head",
                    new Vector3(0F, 0.18162F, 0F),
                    new Vector3(16F, 0F, 0F),
                    new Vector3(0.7F, 0.7F, 0.7F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBlunderbuss"),
"Base",
new Vector3(0.80132F, -0.24434F, 0.67245F),
new Vector3(0F, 180F, 180F),
new Vector3(1F, 1F, 1F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BossHunterConsumed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTricornUsed"),
                    "Head",
                    new Vector3(0F, 0.18162F, 0F),
                    new Vector3(16F, 0F, 0F),
                    new Vector3(0.7F, 0.7F, 0.7F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["JumpBoost"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaxBird"),
"Head",
new Vector3(0.00904F, -0.15044F, -0.064F),
new Vector3(0F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["KillEliteFrenzy"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                   "Head",
                    new Vector3(-0.00077F, 0.08343F, 0.03225F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Knurl"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKnurl"),
"ThighR",
new Vector3(0.12945F, 0.11616F, 0.0622F),
new Vector3(61.87022F, 105.1874F, 91.73286F),
new Vector3(0.05F, 0.05F, 0.05F)
    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LaserTurbine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
    "UpperarmR",
    new Vector3(0.03627F, 0.14396F, -0.053F),
    new Vector3(0F, 0F, 90F),
    new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarDagger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLunarDagger"),
"Backpack",
new Vector3(0.03507F, 0.02842F, -0.09407F),
new Vector3(90F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarPrimaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdEye"),
                    "Head",
                    new Vector3(0.00446F, 0.05152F, 0.12269F),
                    new Vector3(278.5197F, 166.9909F, 187.7403F),
                    new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarTrinket"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBeads"),
                    "Gun",
                    new Vector3(0.01215F, 0.0969F, -0.2234F),
                    new Vector3(86.41624F, 251.3178F, 194.7648F),
                    new Vector3(0.5F, 0.5F, 0.5F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSpecialReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdHeart"),
                    "Base",
                         new Vector3(0.91155F, -0.48007F, 1.04426F),
                        new Vector3(0F, 90F, 0F),
                        new Vector3(0.34F, 0.34F, 0.34F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSecondaryReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdClaw"),
"Chest",
new Vector3(-0.09376F, 0.16942F, -0.03693F),
new Vector3(2.58124F, 335.2195F, 344.0981F),
new Vector3(0.5F, 0.5F, 0.5F)

                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarUtilityReplacement"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBirdFoot"),
"Head",
new Vector3(0.00516F, 0.15316F, -0.16246F),
new Vector3(0F, 270F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Medkit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMedkit"),
                    "ThighR",
                    new Vector3(0.09496F, 0.15103F, 0.08727F),
                    new Vector3(82.9267F, 120.5083F, 254.2673F),
                    new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MinorConstructOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDefenseNucleus"),
"Base",
new Vector3(1.25146F, -0.09873F, 0.62833F),
new Vector3(90F, 180F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Missile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
"Chest",
new Vector3(0.27813F, 0.46478F, -0.03653F),
new Vector3(0F, 0F, 330F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MissileVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileLauncherVoid"),
"Chest",
new Vector3(0.27813F, 0.46478F, -0.03653F),
new Vector3(0F, 0F, 330F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MonstersOnShrineUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
"UpperArmL",
new Vector3(-0.06516F, 0.14685F, -0.04184F),
new Vector3(11.48984F, 294.3984F, 354.2286F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MoveSpeedOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGrappleHook"),
                "Pelvis",
                new Vector3(-0.11461F, 0.02113F, 0.10497F),
                new Vector3(355.5677F, 182.1791F, 181.4899F),
                new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Mushroom"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroom"),
"Backpack",
new Vector3(0.07586F, 0.18254F, -0.03578F),
new Vector3(330.7975F, 297.729F, 4.61037F),
new Vector3(0.03F, 0.03F, 0.03F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MushroomVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMushroomVoid"),
"Backpack",
new Vector3(0.07586F, 0.18254F, -0.03578F),
new Vector3(330.7975F, 297.729F, 4.61037F),
new Vector3(0.03F, 0.03F, 0.03F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NearbyDamageBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDiamond"),
                    "Chest",
                    new Vector3(-0.07145F, -0.00574F, 0.10456F),
                    new Vector3(14.96445F, 286.0561F, 333.0149F),
                    new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
"Head",
new Vector3(0.03955F, 0.0301F, 0.06149F),
new Vector3(0F, 0F, 0F),
new Vector3(0.4F, 0.4F, 0.4F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
"Head",
new Vector3(-0.03955F, 0.0301F, 0.06149F),
new Vector3(0F, 0F, 0F),
new Vector3(-0.4F, 0.4F, 0.4F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["NovaOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayJellyGuts"),
"Head",
new Vector3(-0.07719F, 0.20959F, -0.00093F),
new Vector3(53.9618F, 171.8431F, 174.183F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PermanentDebuffOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScorpion"),
"Tail0",
new Vector3(0.00257F, 0.20258F, 0.03327F),
new Vector3(90F, 0F, 0F),
new Vector3(0.75F, 0.75F, 0.6075F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Plant"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayInterstellarDeskPlant"),
"ThighL",
new Vector3(-0.15288F, 0.2235F, -0.01718F),
new Vector3(69.98083F, 265.5492F, 267.2938F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PersonalShield"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
                    "Pelvis",
                    new Vector3(0.01404F, -0.06519F, -0.10136F),
                    new Vector3(87.08893F, 320.2425F, 319.9176F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["OutOfCombatArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayOddlyShapedOpal"),
                    "Chest",
                    new Vector3(-0.1281F, 0.01391F, 0.05286F),
                    new Vector3(24.14572F, 312.0463F, 4.72856F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Phasing"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStealthkit"),
                    "ShinR",
                    new Vector3(0.00946F, 0.07403F, -0.07466F),
                    new Vector3(78.96772F, 319.7506F, 343.3442F),
                    new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShockNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
"Backpack",
new Vector3(0.00209F, 0.1739F, -0.06446F),
new Vector3(315F, 0F, 0F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ParentEgg"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayParentEgg"),
"Stomach",
new Vector3(-0.03553F, 0.06649F, 0.2087F),
new Vector3(0F, 0F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["PrimarySkillShuriken"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShuriken"),
"ShoulderL",
new Vector3(-0.04035F, 0.31098F, 0.0356F),
new Vector3(335.644F, 36.25471F, 334.9283F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomDamageZone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
"HandL",
new Vector3(0.03357F, 0.13583F, 0.00996F),
new Vector3(34.18036F, 281.6178F, 261.1802F),
new Vector3(0.03F, 0.03F, 0.03F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomEquipmentTrigger"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBottledChaos"),
"ThighL",
new Vector3(-0.11193F, 0.26046F, 0.07866F),
new Vector3(0.82431F, 113.1291F, 193.2905F),
new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RandomlyLunar"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDomino"),
"Base",
new Vector3(-0.72436F, 0.07925F, 1.10277F),
new Vector3(0F, 0F, 0F),
new Vector3(1F, 1F, 1F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Seed"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySeed"),
"ThighR",
new Vector3(0.11894F, 0.28257F, 0.05254F),
new Vector3(323.6363F, 359.3173F, 32.12323F),
new Vector3(0.03F, 0.03F, 0.03F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["RepeatHeal"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayCorpseflower"),
"Gun",
new Vector3(-0.00325F, 0.13829F, 0.22515F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ShieldOnly"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
"Head",
new Vector3(0.09274F, 0.14397F, -0.03176F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShieldBug"),
"Head",
new Vector3(-0.09274F, 0.14397F, -0.03176F),
new Vector3(0F, 0F, 0F),
new Vector3(-0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBuckler"),
"ForearmR",
new Vector3(-0.04127F, -0.01818F, -0.00979F),
new Vector3(30.18107F, 267.8398F, 185.1548F),
new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StickyBomb"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayStickyBomb"),
                    "Chest",
                    new Vector3(-0.12163F, 0.0342F, 0.09221F),
                    new Vector3(25.72779F, 18.70861F, 24.38773F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Syringe"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                    "UpperArmL",
                    new Vector3(-0.0318F, -0.06045F, -0.00425F),
                    new Vector3(48.47333F, 253.2913F, 116.6436F),
                    new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SiphonOnLowHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySiphonOnLowHealth"),
"ThighR",
new Vector3(0.0652F, 0.13239F, -0.05987F),
new Vector3(7.61332F, 325.1557F, 7.00517F),
new Vector3(0.07F, 0.07F, 0.07F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBauble"),
"ThighL",
new Vector3(-0.13375F, 0.67717F, -0.12754F),
 new Vector3(353.8639F, 325.514F, 156.9096F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SlowOnHitVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBaubleVoid"),
                    "ThighL",
new Vector3(-0.13375F, 0.67717F, -0.12754F),
 new Vector3(353.8639F, 325.514F, 156.9096F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintBonus"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySoda"),
"Backpack",
new Vector3(-0.14686F, 0.12111F, -0.02623F),
new Vector3(270F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TPHealingNova"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlowFlower"),
                    "ShoulderL",
                    new Vector3(-0.00932F, 0.23104F, 0.09131F),
                    new Vector3(290.3646F, 318.6625F, 356.6708F),
                    new Vector3(0.35F, 0.35F, 0.35F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["StrengthenBurn"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGasTank"),
"Backpack",
new Vector3(-0.16723F, 0.10048F, -0.00014F),
new Vector3(0F, 0F, 0F),
new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintOutOfCombat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWhip"),
"ThighR",
new Vector3(0.11072F, 0.13678F, 0.08052F),
new Vector3(25.96364F, 321.262F, 13.95342F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["SprintWisp"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBrokenMask"),
"ShoulderL",
new Vector3(-0.00059F, 0.23863F, 0.04765F),
new Vector3(329.9178F, 307.3566F, 37.13911F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Talisman"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTalisman"),
"Base",
new Vector3(0.91065F, -0.59127F, 0.64566F),
new Vector3(90F, 0F, 0F),
new Vector3(0.75F, 0.75F, 0.75F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TitanGoldDuringTP"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldHeart"),
"Chest",
new Vector3(-0.00238F, -0.02948F, 0.12886F),
new Vector3(350.1398F, 325.495F, 4.29539F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCache"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKey"),
"ThighR",
new Vector3(0.0045F, 0.09265F, 0.12203F),
new Vector3(355.0135F, 290.1322F, 265.0303F),
new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TreasureCacheVoid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayKeyVoid"),
                    "ThighR",
new Vector3(0.0045F, 0.09265F, 0.12203F),
new Vector3(355.0135F, 290.1322F, 265.0303F),
new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Squid"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySquidTurret"),
"ThighL",
new Vector3(-0.01673F, 0.16279F, 0.131F),
new Vector3(40.37907F, 212.9704F, 250.9433F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VoidMegaCrabItem"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMegaCrabItem"),
"Pelvis",
new Vector3(-0.00086F, 0.09409F, -0.11031F),
new Vector3(346.1268F, 179.772F, 180.2999F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["WardOnLevel"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWarbanner"),
"Backpack",
new Vector3(0.01696F, -0.13253F, 0.01578F),
new Vector3(89.56389F, 115.9927F, 210.5583F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BFG"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBFG"),
"Backpack",
new Vector3(0F, 0.16F, -0.07057F),
new Vector3(315F, 0F, 0F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tooth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
"Chest",
new Vector3(0F, 0.15799F, 0.21731F),
new Vector3(0F, 0F, 0F),
new Vector3(1.5F, 1.5F, 1.5F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
"Chest",
new Vector3(0.04F, 0.158F, 0.21F),
new Vector3(0F, 0F, 0F),
new Vector3(1F, 1F, 1F)
                    ), ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
"Chest",
new Vector3(-0.04F, 0.158F, 0.21F),
new Vector3(0F, 0F, 0F),
new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Cleanse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayWaterPack"),
"Backpack",
new Vector3(0F, 0F, -0.08F),
new Vector3(0F, 180F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CommandMissile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMissileRack"),
"Backpack",
new Vector3(0F, 0.18F, -0.07F),
new Vector3(90F, 180F, 0F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CritOnUse"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayNeuralImplant"),
"Head",
new Vector3(0F, 0.04F, 0.2F),
new Vector3(0F, 0F, 0F),
new Vector3(0.15F, 0.15F, 0.15F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BurnNearby"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayPotion"),
"Backpack",
new Vector3(0.02737F, 0.03826F, -0.1533F),
new Vector3(0F, 0F, 0F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["CrippleWard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEffigy"),
"Backpack",
new Vector3(0F, -0.05525F, -0.11094F),
new Vector3(0F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FreeChest"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayShippingRequestForm"),
"Backpack",
new Vector3(-0.0526F, -0.06739F, -0.06877F),
new Vector3(90F, 180F, 0F),
new Vector3(0.25F, 0.25F, 0.25F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["BarrageOnBoss"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTreasuryDividends"),
"Backpack",
new Vector3(0.15599F, 0.03939F, 0.02332F),
new Vector3(0F, 90F, 0F),
new Vector3(1F, 1F, 1F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ItemDropChanceOnKill"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySonorousEcho"),
"UpperarmR",
new Vector3(0.03434F, 0.17242F, -0.08821F),
new Vector3(16.22399F, 304.0447F, 314.0632F),
new Vector3(1F, 1F, 1F)
)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["AlienHead"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAlienHead"),
"Gun",
new Vector3(0F, -0.08386F, 0.25426F),
new Vector3(270F, 0F, 0F),
new Vector3(1F, 1F, 1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Feather"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFeather"),
"ShoulderL",
new Vector3(-0.02135F, 0.23701F, 0.06098F),
new Vector3(64.11668F, 315.4507F, 319.5201F),
new Vector3(0.02F, 0.02F, 0.02F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FlatHealth"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySteakCurved"),
"Head",
new Vector3(0.08135F, 0.18742F, -0.11756F),
new Vector3(294.2767F, 249.8174F, 227.0657F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Firework"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFirework"),
"ShinL",
new Vector3(-0.06894F, 0.02273F, 0.127F),
new Vector3(69.66143F, 331.6913F, 335.1557F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DeathProjectile"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDeathProjectile"),
"Backpack",
new Vector3(0F, 0F, -0.19F),
new Vector3(0F, 180F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["DroneBackup"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRadio"),
"Backpack",
new Vector3(0.13771F, 0.16919F, 0.0037F),
new Vector3(0F, 90F, 0F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["FireBallDash"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEgg"),
"Backpack",
new Vector3(0F, 0F, -0.16F),
new Vector3(270F, 0F, 0F),
new Vector3(0.3F, 0.3F, 0.3F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteEarthEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteMendingAntlers"),
"Head",
new Vector3(0F, 0.14F, 0F),
new Vector3(0F, 0F, 0F),
new Vector3(0.7F, 0.7F, 0.7F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteFireEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
"Head",
new Vector3(0.05749F, 0.12871F, 0.01334F),
new Vector3(0F, 330F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteHorn"),
"Head",
new Vector3(-0.05749F, 0.12871F, 0.01334F),
new Vector3(0F, 30F, 0F),
new Vector3(-0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteHauntedEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
"Head",
new Vector3(0F, 0.2F, 0.02F),
new Vector3(270F, 0F, 0F),
new Vector3(0.04F, 0.04F, 0.04F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteIceEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
"Head",
new Vector3(0F, 0.21295F, 0.0483F),
new Vector3(270F, 0F, 0F),
new Vector3(0.02F, 0.02F, 0.02F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLunarEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteLunar,Eye"),
"Head",
new Vector3(0F, 0.22165F, 0.02728F),
new Vector3(270F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ElitePoisonEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteUrchinCrown"),
"Head",
new Vector3(0F, 0.125F, 0.025F),
new Vector3(270F, 0F, 0F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteLightningEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
"Head",
new Vector3(0F, 0.1202F, 0.05F),
new Vector3(300F, 0F, 0F),
new Vector3(0.15F, 0.15F, 0.15F)

                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
 "Head",
 new Vector3(-0.01559F, 0.11404F, 0.11539F),
new Vector3(330F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["EliteVoidEquipment"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAffixVoid"),
"Head",
new Vector3(0F, 0.03F, 0.1F),
new Vector3(90F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Fruit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayFruit"),
"Backpack",
new Vector3(-0.01047F, -0.10851F, -0.09094F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GainArmor"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayElephantFigure"),
"Head",
new Vector3(0F, 0.22F, 0.05F),
new Vector3(0F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Gateway"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVase"),
"Backpack",
new Vector3(0F, 0.06F, -0.15F),
new Vector3(270F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GoldGat"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGoldGat"),
"Backpack",
new Vector3(-0.19594F, 0.14766F, -0.23208F),
new Vector3(293.566F, 134.2467F, 253.752F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LifestealOnHit"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
"Head",
new Vector3(-0.02227F, 0.28026F, 0.10237F),
new Vector3(90F, 0F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Jetpack"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBugWings"),
"Backpack",
new Vector3(0F, 0.07F, -0.08F),
new Vector3(0F, 0F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Lightning"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayLightningArmRight"),
"ShoulderR",
new Vector3(0.03218F, 0.1949F, 0.26412F),
new Vector3(0F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["GummyClone"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGummyClone"),
"Backpack",
new Vector3(-0.02121F, 0.10038F, -0.08999F),
new Vector3(356.4817F, 347.4506F, 5.45843F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["QuestVolatileBattery"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayBatteryArray"),
"Backpack",
new Vector3(0F, 0.05F, -0.16F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Recycle"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayRecycler"),
"Backpack",
new Vector3(0F, 0.05F, -0.12F),
new Vector3(0F, 90F, 0F),
new Vector3(0.05F, 0.05F, 0.05F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Saw"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
"Base",
new Vector3(0.98834F, 0.43524F, 0.84853F),
new Vector3(0F, 0F, 0F),
new Vector3(0.15F, 0.15F, 0.15F)
)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Molotov"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayMolotov"),
"Backpack",
new Vector3(0.17667F, -0.01687F, 0.00046F),
new Vector3(0F, 300F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));


            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["MultiShopCard"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayExecutiveCard"),
"Backpack",
new Vector3(0F, 0.2F, 0F),
new Vector3(270F, 0F, 0F),
new Vector3(0.5F, 0.5F, 0.5F)
                    )
                ));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["TeamWarCry"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
"Backpack",
new Vector3(0F, 0.05F, -0.15F),
new Vector3(0F, 180F, 0F),
new Vector3(0.05F, 0.05F, 0.05F)
)
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Scanner"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayScanner"),
"Backpack",
new Vector3(0.03212F, 0.1301F, -0.02931F),
new Vector3(300F, 180F, 180F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["Tonic"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayTonic"),
"Backpack",
new Vector3(0F, 0.05F, -0.12F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["VendingMachine"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayVendingMachine"),
"Backpack",
new Vector3(0.15611F, 0.16769F, -0.0344F),
new Vector3(0F, 0F, 0F),
new Vector3(0.1F, 0.1F, 0.1F)

                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["ArmorReductionOnHit"],
                ItemDisplays.CreateDisplayRule(CustomShatDisplay,
"Tail4",
new Vector3(0F, 0.05F, -0.04F),
new Vector3(0F, 0F, 0F),
new Vector3(0.2F, 0.2F, 0.2F)
                    )
                ));

            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(ItemDisplays.KeyAssets["LunarSun"],
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHead"),
"Head",
new Vector3(0F, 0.05F, 0F),
new Vector3(0F, 0F, 0F),
new Vector3(0.7F, 0.7F, 0.7F)
                    ),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplaySunHeadNeck"),
"Chest",
new Vector3(0F, 0.14777F, 0F),
new Vector3(13.08644F, 358.052F, 5.57808F),
new Vector3(1F, 1F, 1F)

                    )
                ));
        }
    }
}
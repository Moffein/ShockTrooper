using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace GaleShockTrooper.Characters.Drones.GaleShockTrooperDrone.Components
{
    public class DroneMasterFixSkin : MonoBehaviour
    {
        public void Start()
        {
            CharacterMaster droneMaster = GetComponent<CharacterMaster>();
            if (!droneMaster || !droneMaster.minionOwnership || !droneMaster.minionOwnership.ownerMaster) return;

            droneMaster.loadout.bodyLoadoutManager.SetSkinIndex(BodyCatalog.FindBodyIndex("GaleShockTrooperDroneBody"), droneMaster.minionOwnership.ownerMaster.loadout.bodyLoadoutManager.GetSkinIndex(BodyCatalog.FindBodyIndex("GaleShockTrooperBody")));
            if (NetworkServer.active) droneMaster.SetLoadoutServer(droneMaster.loadout);
        }
    }
}

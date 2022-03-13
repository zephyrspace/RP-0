﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KerbalConstructionTime
{
    public class PadConstructionStorageItem
    {
        [Persistent]
        public int launchpadID = 0;

        [Persistent]
        public string name;

        [Persistent]
        public double progress = 0, BP = 0, cost = 0;

        [Persistent]
        public bool upgradeProcessed = false;

        public PadConstruction ToPadConstruction()
        {
            return new PadConstruction
            {
                LaunchpadIndex = launchpadID,
                Name = name,
                Progress = progress,
                BP = BP,
                Cost = cost,
                UpgradeProcessed = upgradeProcessed
            };
        }

        public PadConstructionStorageItem FromPadConstruction(PadConstruction pc)
        {
            launchpadID = pc.LaunchpadIndex;
            name = pc.Name;
            progress = pc.Progress;
            BP = pc.BP;
            cost = pc.Cost;
            upgradeProcessed = pc.UpgradeProcessed;
            return this;
        }
    }
}

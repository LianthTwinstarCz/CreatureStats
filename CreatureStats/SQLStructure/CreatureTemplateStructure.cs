using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureStats.SQLStructure
{
    public struct CreatureTemplate
    {
        public uint Entry;
        public uint[] ModelId;
        public uint GossipMenuId;
        public uint MinLevel;
        public uint MaxLevel;
        public uint FactionA;
        public uint FactionH;
        public uint MinDamage;
        public uint MaxDamage;
        public uint Multiplier;
        public uint AttackPower;
        public uint UnitClass;
        public uint Type;
        public uint Rank;
        public uint Family;
        public uint TypeFlags;
        public uint NPCFlag;
        public uint UnitFlags;
        public uint UnitFlags2;
        public uint DynamicFlags;
        public uint ExtraFlags;
        public uint LootId;
        public uint PickpocketId;
        public uint SkinningLoot;
        public uint MinGold;
        public uint MaxGold;
        public uint[] Spells;
        public uint ReactState;
        public uint MechanicImmuneMask;
        public uint InhabitType;
        public uint VehicleId;
        public uint WDBVerified;
        public float SpeedWalk;
        public float SpeedRun;
        public string Name;
        public string Subname;
        public string AIName;
        public string ScriptName;
    }

    public struct Creature
    {
        // Creature
        public uint GUID;
        public uint Id;
        public uint MapId;
        public uint Health;
        public uint Mana;
        public uint Count;
    }
}

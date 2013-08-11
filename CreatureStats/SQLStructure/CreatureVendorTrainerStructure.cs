using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureStats.SQLStructure
{
    public struct CreatureTrainer
    {
        public uint Entry;
        public uint SpellCost;
        public uint RequiredSkill;
        public uint RequiredSkillValue;
        public uint RequiredLevel;
        public int Spell;
    }

    public struct CreatureVendor
    {
        public uint Entry;
        public uint MaxCount;
        public uint IncrTime;
        public uint ExtendedCost;
        public uint Type;
        public int Slot;
        public int Item;
    }
}

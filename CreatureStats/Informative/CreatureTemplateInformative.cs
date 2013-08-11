using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CreatureStats.SQLStructure;
using CreatureStats.SQLStores;
using CreatureStats.Extensions;
using CreatureStats.Informative;

namespace CreatureStats.Informative
{
    public class CreatureTemplateInformative
    {
        uint WDBVerified = 15595;
        private readonly RichTextBox richTextBox;
        private CreatureTemplate creatureTemplate;
        private const string line = "=================================";
        //private const string none = "-----";
        bool foundFlag;

        public CreatureTemplateInformative(RichTextBox rtb, CreatureTemplate ct)
        {
            richTextBox = rtb;
            creatureTemplate = ct;
            foundFlag = false;

            ViewCreatureTemplateInfo();
        }

        public void ViewCreatureTemplateInfo()
        {
            richTextBox.Clear();
            richTextBox.SetStyle(Color.RoyalBlue, FontStyle.Bold);
            richTextBox.AppendText("Entry: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0} & {1}", creatureTemplate.Entry, creatureTemplate.Name);
            
            if (creatureTemplate.Subname != "")
            {
                richTextBox.SetStyle(Color.Brown, FontStyle.Bold);
                richTextBox.AppendText("Subname: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("<{0}>", creatureTemplate.Subname);
            }

            richTextBox.AppendFormatLine(line);
            richTextBox.SetBold();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendLine("ModelIds: ");
            for (uint n = 0; n < 4; n++)
            {
                if (creatureTemplate.ModelId[n] != 0)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormatLine("{0} - [ {1} ]", n, creatureTemplate.ModelId[n]);
                }
            }

            richTextBox.AppendLine();

            if (creatureTemplate.MinLevel == creatureTemplate.MaxLevel)
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Level: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}", creatureTemplate.MaxLevel);
            }
            else
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Levels: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0} - {1}", creatureTemplate.MinLevel, creatureTemplate.MaxLevel);
            }

            if (creatureTemplate.FactionA == creatureTemplate.FactionH)
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Faction: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}", creatureTemplate.FactionA);
            }
            else
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Faction (A): ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}", creatureTemplate.FactionA);

                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Faction (H): ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}", creatureTemplate.FactionH);
            }
            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Speed: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}  &  {1}", creatureTemplate.SpeedWalk.ToString(), creatureTemplate.SpeedRun.ToString());
            richTextBox.SetStyle(Color.Red, FontStyle.Bold);
            richTextBox.AppendLine(" - NYI - Not yet implemented!");

            if ((creatureTemplate.FactionA == 14
                || creatureTemplate.FactionA == 16
                || creatureTemplate.FactionH == 14
                || creatureTemplate.FactionH == 16) &&
                (creatureTemplate.MinDamage == 0
                || creatureTemplate.MinDamage == 1
                || creatureTemplate.MaxDamage == 0
                || creatureTemplate.MaxDamage == 1))
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Damage: ");
                richTextBox.SetStyle(Color.Blue, FontStyle.Bold);
                richTextBox.AppendFormat("{0}  -  {1}", creatureTemplate.MinDamage, creatureTemplate.MaxDamage);
                richTextBox.SetStyle(Color.Red, FontStyle.Bold);
                richTextBox.AppendFormatLine(" - Check damage! Creature is enemy to players, but min damage is {0} and max damage is {1}... shouldn't it be revised?", creatureTemplate.MinDamage, creatureTemplate.MaxDamage);
            }
            else
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Damage: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}  -  {1}", creatureTemplate.MinDamage, creatureTemplate.MaxDamage);
            }

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Damage Multiplier: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.Multiplier);

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Attack Power: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.AttackPower);
            richTextBox.AppendLine();

            if (creatureTemplate.Family != (int)Family.CREATURE_FAMILY_NOT_BEAST)
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Family: ");
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormatLine("{0}  ({1})", creatureTemplate.Family, (Family)creatureTemplate.Family);
            }
            else
            {
                richTextBox.SetStyle(Color.Green, FontStyle.Bold);
                richTextBox.AppendText("Family: ");
                richTextBox.SetStyle(Color.Blue, FontStyle.Bold);
                richTextBox.AppendLine("Creature is not a beast and thus it doesn't have Family!");
            }

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Rank: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}  ", creatureTemplate.Rank);
            richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
            richTextBox.AppendFormatLine("({0})", (Rank)creatureTemplate.Rank);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Unit Class: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}  ", creatureTemplate.UnitClass);
            richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
            richTextBox.AppendFormatLine("({0})", (UnitClass)creatureTemplate.UnitClass);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Creature Type: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}  ", creatureTemplate.Type);
            richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
            richTextBox.AppendFormatLine("({0})", (CreatureType)creatureTemplate.Type);
            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("LootId: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.LootId);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Pickpocket LootId: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.PickpocketId);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Skinning LootId: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.SkinningLoot);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Gold: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0} - {1}", creatureTemplate.MinGold, creatureTemplate.MaxGold);
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendLine(" (in copper)");
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Vehicle Id: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.VehicleId);
            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("InhabitType: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}", creatureTemplate.InhabitType);
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("  ({0})", creatureTemplate.InhabitType.ToHex());
            if (creatureTemplate.InhabitType == (int)InhabitType.INHABIT_ANYWHERE)
            {
                richTextBox.SetBoldWithDefault();
                richTextBox.AppendFormat("{0}", (InhabitType)creatureTemplate.InhabitType);
                richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                richTextBox.AppendFormatLine("  ({0})", creatureTemplate.InhabitType.ToHex());
            }
            else
            {
                for (var n = 0; n < 3; ++n)
                {
                    if ((creatureTemplate.InhabitType & (1 << n)) != 0L)
                    {
                        richTextBox.SetBoldWithDefault();
                        richTextBox.AppendFormat("{0}  ", (InhabitType)(1 << n));
                        richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                        richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    }
                }
            }
            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("ReactState: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormat("{0}  ", creatureTemplate.ReactState);
            richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
            richTextBox.AppendFormatLine("({0})", (ReactStates)creatureTemplate.ReactState);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Gossip Menu Id: ");
            richTextBox.SetBoldWithDefault();
            if (creatureTemplate.GossipMenuId == 0 && (creatureTemplate.NPCFlag & (int)NPCFlags.UNIT_NPC_FLAG_GOSSIP) != 0)
            {
                richTextBox.SetStyle(Color.Blue, FontStyle.Bold);
                richTextBox.AppendFormat("{0}", creatureTemplate.GossipMenuId);
                richTextBox.SetStyle(Color.Red, FontStyle.Bold);
                richTextBox.AppendFormatLine(" - Check Gossip! Creature has {0}, but Gossip Menu Id is {1}!", NPCFlags.UNIT_NPC_FLAG_GOSSIP, creatureTemplate.GossipMenuId);
            }
            else
                richTextBox.AppendFormatLine("{0}", creatureTemplate.GossipMenuId);
            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendLine("Spells:");
            bool hasSpells = false;
            for (uint n = 0; n < 7; n++)
            {
                if (creatureTemplate.Spells[n] != 0)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormatLine("{0} - [ {1} ]", n, creatureTemplate.Spells[n]);
                    hasSpells = true;
                }
            }

            if (!hasSpells)
            {
                richTextBox.SetStyle(Color.Blue, FontStyle.Bold);
                richTextBox.AppendLine("No spells defined");
                richTextBox.SetBold();
            }

            richTextBox.AppendLine();

            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("AIName: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("\"{0}\"", creatureTemplate.AIName);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("ScriptName: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("\"{0}\"", creatureTemplate.ScriptName);
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("WDB verified: ");
            richTextBox.SetBoldWithDefault();
            richTextBox.AppendFormatLine("{0}", creatureTemplate.WDBVerified);

            // Missing Sniff
            if (creatureTemplate.WDBVerified != WDBVerified)
            {
                richTextBox.AppendLine();
                richTextBox.SetStyle(Color.Blue, FontStyle.Bold);
                richTextBox.AppendFormatLine("This NPC is not verified from 4.3.4.  ({0})  version! Maybe missing sniff?", WDBVerified);
            }

            richTextBox.AppendFormatLine(line);

            // Mechanic Immune Mask
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Mechanic Immune Mask: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.MechanicImmuneMask.ToHex());
            for (var n = 0; n < 32; ++n)
            {
                if ((creatureTemplate.MechanicImmuneMask & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (MechanicImmuneMask)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // Dynamic Flags
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Dynamic Flags: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.DynamicFlags.ToHex());
            for (var n = 0; n < 8; ++n)
            {
                if ((creatureTemplate.DynamicFlags & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (DynamicFlags)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // NPC Flags
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("NPCFlags: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.NPCFlag.ToHex());
            for (var n = 0; n < 26; ++n)
            {
                if ((creatureTemplate.NPCFlag & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (NPCFlags)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // Unit Flags
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Unit Flags: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.UnitFlags.ToHex());
            for (var n = 0; n < 32; ++n)
            {
                if ((creatureTemplate.UnitFlags & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (UnitFlags)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // Unit Flags2
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Unit Flags 2: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.UnitFlags2.ToHex());
            for (var n = 0; n < 32; ++n)
            {
                if ((creatureTemplate.UnitFlags2 & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (UnitFlags)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // Type Flags
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Type Flags: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.TypeFlags.ToHex());
            for (var n = 0; n < 24; ++n)
            {
                if ((creatureTemplate.TypeFlags & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (TypeFlags)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }

            // Extra Flags
            richTextBox.AppendLine();
            foundFlag = false;
            richTextBox.SetStyle(Color.Green, FontStyle.Bold);
            richTextBox.AppendText("Flags Extra: ");
            richTextBox.SetStyle(Color.DarkViolet, FontStyle.Bold);
            richTextBox.AppendFormatLine("{0}", creatureTemplate.ExtraFlags.ToHex());
            for (var n = 0; n < 16; ++n)
            {
                if ((creatureTemplate.ExtraFlags & (1 << n)) != 0L)
                {
                    richTextBox.SetBoldWithDefault();
                    richTextBox.AppendFormat("{0}     ", (FlagsExtra)(1 << n));
                    richTextBox.SetStyle(Color.Orange, FontStyle.Bold);
                    richTextBox.AppendFormatLine("({0})", (1 << n).ToHex());
                    foundFlag = true;
                }
            }

            if (!foundFlag)
            {
                richTextBox.SetBold();
                richTextBox.AppendLine("0".ToHex());
            }
        }

        public void ViewCreatureVendorOrTrainerInfo()
        {
            richTextBox.Clear();
            richTextBox.AppendText("TROLL");
        }

        public static uint GetCount(CreatureTemplate creatureTemplate)
        {
            return SQL.CreatureTemplate.Count(x => x.Value.Entry == creatureTemplate.Entry).ToUInt32();
        }
    }
}

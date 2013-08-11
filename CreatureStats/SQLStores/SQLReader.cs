using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using CreatureStats.Extensions;
using CreatureStats.SQLStructure;
using CreatureStats.Properties;
using MySql.Data.MySqlClient;

namespace CreatureStats.SQLStores
{
    public class SQLReader
    {
        private ProgressBar progressBar = new ProgressBar();
        private MainForm mainForm;
        public MySqlConnection connection;
        public bool Connected { get; set; }
        public bool FirstTime { get; set; }
        private MySqlCommand command;
        private string query;

        public SQLReader(MainForm form)
        {
            mainForm = form;
            TestConnection();
            SQL.CreatureTemplate = LoadCreatureTemplates();
        }

        public static String ConnectionString
        {
            get
            {
                return String.Format("Server={0}; Port={1}; Uid={2}; Pwd={3}; Database={4}; character set=utf8; Connection Timeout=10",
                    Settings.Default.Host,
                    Settings.Default.Port,
                    Settings.Default.User,
                    Settings.Default.Pass,
                    Settings.Default.WorldDB);
            }
        }

        public void ExecuteCommand(string comm)
        {
            query = comm;
            using (connection = new MySqlConnection(ConnectionString))
            {
                command = new MySqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Dictionary<uint, CreatureTemplate> LoadCreatureTemplates()
        {
            var dictionary = new Dictionary<uint, CreatureTemplate>();
            query = String.Format(
                    @"SELECT entry,
                             name,
                             subname,
                             gossip_menu_id,
                             minlevel,
                             maxlevel,
                             speed_walk,
                             speed_run,
                             faction_A,
                             faction_H,
                             mindmg,
                             maxdmg,
                             attackpower,
                             dmg_multiplier,
                             unit_class,
                             type,
                             rank,
                             family,
                             npcflag,
                             unit_flags,
                             unit_flags2,
                             type_flags,
                             dynamicflags,
                             lootid,
                             pickpocketloot,
                             skinloot,
                             mingold,
                             maxgold,
                             VehicleId,
                             ReactState,
                             InhabitType,
                             AIName,
                             ScriptName,
                             mechanic_immune_mask,
                             flags_extra,
                             WDBVerified,
                             modelId1,
                             modelId2,
                             modelId3,
                             modelId4,
                             spell1,
                             spell2,
                             spell3,
                             spell4,
                             spell5,
                             spell6,
                             spell7
                    FROM
                        creature_template
                    WHERE
                        entry <> 0;");

            using (connection = new MySqlConnection(ConnectionString))
            {
                command = new MySqlCommand(query, connection);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int index = 0;
                        var creatureTemplate = new CreatureTemplate
                        {
                            Entry               = reader[index++].ToUInt32(),
                            Name                = reader[index++].ToString(),
                            Subname             = reader[index++].ToString(),
                            GossipMenuId        = reader[index++].ToUInt32(),
                            MinLevel            = reader[index++].ToUInt32(),
                            MaxLevel            = reader[index++].ToUInt32(),
                            SpeedWalk           = reader[index++].ToFloat(),
                            SpeedRun            = reader[index++].ToFloat(),
                            FactionA            = reader[index++].ToUInt32(),
                            FactionH            = reader[index++].ToUInt32(),
                            MinDamage           = reader[index++].ToUInt32(),
                            MaxDamage           = reader[index++].ToUInt32(),
                            AttackPower         = reader[index++].ToUInt32(),
                            Multiplier          = reader[index++].ToUInt32(),
                            UnitClass           = reader[index++].ToUInt32(),
                            Type                = reader[index++].ToUInt32(),
                            Rank                = reader[index++].ToUInt32(),
                            Family              = reader[index++].ToUInt32(),
                            NPCFlag             = reader[index++].ToUInt32(),
                            UnitFlags           = reader[index++].ToUInt32(),
                            UnitFlags2          = reader[index++].ToUInt32(),
                            TypeFlags           = reader[index++].ToUInt32(),
                            DynamicFlags        = reader[index++].ToUInt32(),
                            LootId              = reader[index++].ToUInt32(),
                            PickpocketId        = reader[index++].ToUInt32(),
                            SkinningLoot        = reader[index++].ToUInt32(),
                            MinGold             = reader[index++].ToUInt32(),
                            MaxGold             = reader[index++].ToUInt32(),
                            VehicleId           = reader[index++].ToUInt32(),
                            ReactState          = reader[index++].ToUInt32(),
                            InhabitType         = reader[index++].ToUInt32(),
                            AIName              = reader[index++].ToString(),
                            ScriptName          = reader[index++].ToString(),
                            MechanicImmuneMask  = reader[index++].ToUInt32(),
                            ExtraFlags          = reader[index++].ToUInt32(),
                            WDBVerified         = reader[index++].ToUInt32()
                        };

                        // Models
                        creatureTemplate.ModelId = new uint[4];
                        for (uint n = 0; n < 4; ++n)
                            creatureTemplate.ModelId[n] = reader[index++].ToUInt32();

                        // Spells
                        creatureTemplate.Spells = new uint[7];
                        for (uint n = 0; n < 7; ++n)
                            creatureTemplate.Spells[n] = reader[index++].ToUInt32();

                        dictionary[creatureTemplate.Entry.ToUInt32()] = creatureTemplate;
                    }
                }
            }

            return dictionary;
        }

        public Dictionary<uint, CreatureTrainer> LoadCreatureTrainers()
        {
            var dictionary = new Dictionary<uint, CreatureTrainer>();
            query = String.Format(
                    @"SELECT entry,
                             spell,
                             spellcost,
                             reqskill,
                             reqskillvalue,
                             reqlevel
                    FROM
                        creature_trainer
                    WHERE
                        entry <> 0;");

            using (connection = new MySqlConnection(ConnectionString))
            {
                command = new MySqlCommand(query, connection);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int index = 0;
                        var creatureTrainer = new CreatureTrainer
                        {
                            Entry = reader[index++].ToUInt32(),
                            Spell = reader[index++].ToInt32(),
                            SpellCost = reader[index++].ToUInt32(),
                            RequiredSkill = reader[index++].ToUInt32(),
                            RequiredSkillValue = reader[index++].ToUInt32(),
                            RequiredLevel = reader[index++].ToUInt32(),
                        };

                        dictionary[creatureTrainer.Entry.ToUInt32()] = creatureTrainer;
                    }
                }
            }

            return dictionary;
        }

        public Dictionary<uint, CreatureTemplate> LoadListView()
        {
            var dictionary = new Dictionary<uint, CreatureTemplate>();
            query = @"SELECT entry, name FROM creature_template WHERE entry <> 0;";

            using (connection = new MySqlConnection(ConnectionString))
            {
                command = new MySqlCommand(query, connection);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var creatureTemplate = new CreatureTemplate
                        {
                            Entry   = reader[0].ToUInt32(),
                            Name    = reader[1].ToString(),
                        };

                        dictionary[creatureTemplate.Entry.ToUInt32()] = creatureTemplate;
                    }
                }
            }

            return dictionary;
        }

        public uint GetRowsCount()
        {
            uint count = 0;
            query = @"SELECT COUNT(*) FROM creature_template WHERE entry <> 0;";

            using (connection = new MySqlConnection(ConnectionString))
            {
                command = new MySqlCommand(query, connection);

                connection.Open();

                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        count = reader[0].ToUInt32();
            }

            return count;
        }

        public void TestConnection()
        {
            try
            {
                connection = new MySqlConnection(ConnectionString);
                connection.Open();
                connection.Close();
                Connected = true;
            }
            catch
            {
                Connected = false;
            }
        }
    }
}

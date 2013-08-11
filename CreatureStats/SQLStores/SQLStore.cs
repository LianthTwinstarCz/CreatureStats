using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CreatureStats.SQLStructure;

namespace CreatureStats.SQLStores
{
    public static class SQL
    {
        public static Dictionary<uint, CreatureTemplate> CreatureTemplate;
        public static Dictionary<uint, CreatureTrainer> CreatureTrainer;
        public static Dictionary<uint, CreatureVendor> CreatureVendor;
    }
}

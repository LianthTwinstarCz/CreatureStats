using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CreatureStats;
using CreatureStats.SQLStructure;
using MySql.Data.MySqlClient;
using CreatureStats.SQLStores;

/// <summary>
/// # TODO: #
/// # Speed is somehow not working #
/// # Correct Icon #
/// # More Filters and possible search criterias #
/// # Optimalize starting and search time (start time is around 15 seconds now)#
/// # Window for setting DB manually #
/// # Add group box fir list and row count #
/// </summary>

namespace CreatureStats
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //MainForm mainForm = new MainForm();

                /*// Then test connection and load progress bar and structure
                SQLReader sqlReader = new SQLReader(mainForm);
                sqlReader.TestConnection();

                mainForm.sqlReader = sqlReader;
                SQL.CreatureTemplate = sqlReader.LoadCreatureTemplates();*/
                //Application.Run(mainForm);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

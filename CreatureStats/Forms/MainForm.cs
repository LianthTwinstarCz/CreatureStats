using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using CreatureStats.Extensions;
using CreatureStats.Forms;
using CreatureStats.SQLStores;
using CreatureStats.SQLStructure;
using CreatureStats.Informative;
using MySql.Data.MySqlClient;

namespace CreatureStats
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NameOrIdComboBox.SelectedIndex       = 0;
            AdvancedFilterComboBox.SelectedIndex = 0;
            FlagsEnumComboBox.SelectedIndex      = 0;
            creatureTemplateResults.Clear();

            // Load Creature Templates
            SQLReader sqlReader = new SQLReader(this);
        }

        private List<CreatureTemplate> creatureTemplateResults = new List<CreatureTemplate>();
        private CreatureTemplateInformative creatureTemplateInformative;
        public SQLReader sqlReader;

        private void SearchCreatureEntry()
        {
            //sqlReader.LoadListView();
            var Name = NameOrIdTextBox.Text;
            var NameFilter = (NameOrIdComboBox.SelectedIndex == 1 && Name != String.Empty);

            var Id = NameOrIdTextBox.Text.ToUInt32();
            var IdFilter = (NameOrIdComboBox.SelectedIndex == 0 && Id != 0);

            creatureTemplateResults = (from creatureTemplate in SQL.CreatureTemplate.Values
                                       where
                                           ((!IdFilter || creatureTemplate.Entry == Id)) &&
                                           ((!NameFilter || creatureTemplate.Name.ContainsText(Name)))
                                       select creatureTemplate).ToList();

            var count = creatureTemplateResults.Count();
            SearchResultListView.VirtualListSize = count;
            SearchListViewRowCount.Clear();
            SearchListViewRowCount.AppendFormatLine("Number of rows: {0}", count);

            if (SearchResultListView.SelectedIndices.Count > 0)
                SearchResultListView.Items[SearchResultListView.SelectedIndices[0]].Selected = false;
        }

        private void SearchResultsListViewRetrieveVItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            Contract.Requires(e.ItemIndex >= 0);
            Contract.Requires(e.ItemIndex < this.creatureTemplateResults.Count);

            var creatureTemplate = creatureTemplateResults[e.ItemIndex];
            e.Item = new ListViewItem(new[] { creatureTemplate.Entry.ToString(), creatureTemplate.Name.ToString(), CreatureTemplateInformative.GetCount(creatureTemplate).ToString() });
        }

        private void SearchMouseClickEvent(object sender, MouseEventArgs e)
        {
            sqlReader.Connected = false;
            SearchCreatureEntry();
        }

        private void NameOrIdOrGUIDKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            SearchCreatureEntry();
        }

        private void AdvancedFilterTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            AdvancedFilter();
        }

        private void AdvancedFilter()
        {
            if (AdvancedFilterComboBox.SelectedIndex == 0)
                return;

            sqlReader.LoadListView();
            var value = AdvancedFilterTextBox.Text.ToUInt32();
            
            //var mapIdFilter = AdvancedFilterComboBox.SelectedIndex == 1;
            var modelIdFilter = AdvancedFilterComboBox.SelectedIndex == 2;
            var minLevelFilter = AdvancedFilterComboBox.SelectedIndex == 3;
            var maxLevelFilter = AdvancedFilterComboBox.SelectedIndex == 4;
            var factionAFilter = AdvancedFilterComboBox.SelectedIndex == 5;
            var factionHFilter = AdvancedFilterComboBox.SelectedIndex == 6;
            var vehicleIdFilter = AdvancedFilterComboBox.SelectedIndex == 7;

            creatureTemplateResults = (from creatureTemplate in SQL.CreatureTemplate.Values
                                       where
                                           //(!mapIdFilter || value == creatureTemplate.MapId) &&
                                           (!modelIdFilter || (value == creatureTemplate.ModelId[0]
                                           || value == creatureTemplate.ModelId[1]
                                           || value == creatureTemplate.ModelId[2]
                                           || value == creatureTemplate.ModelId[3])) &&
                                           (!minLevelFilter || value == creatureTemplate.MinLevel) &&
                                           (!maxLevelFilter || value == creatureTemplate.MaxLevel) &&
                                           (!factionAFilter || value == creatureTemplate.FactionA) &&
                                           (!factionHFilter || value == creatureTemplate.FactionH) &&
                                           (!vehicleIdFilter || value == creatureTemplate.VehicleId)
                                       select creatureTemplate).ToList();

            var count = creatureTemplateResults.Count();
            SearchResultListView.VirtualListSize = count;
            SearchListViewRowCount.Clear();
            SearchListViewRowCount.AppendFormatLine("Number of rows: {0}", count);

            if (SearchResultListView.SelectedIndices.Count > 0)
                SearchResultListView.Items[SearchResultListView.SelectedIndices[0]].Selected = false;
        }

        private void FlagFilter()
        {
            if (AdvancedFilterComboBox.SelectedIndex == 0)
                return;

            sqlReader.LoadListView();
            var operatorFilter = FlagsEnumComboBox.SelectedIndex == 0;

            var unitFlags = FlagsEnumValuesComboBox.ToByte();
            /*var Flag = FlagsEnumValuesComboBox.SelectedValue.ToUInt32();
            var FlagFilter = FlagsEnumValuesComboBox.SelectedIndex != 0;*/

            creatureTemplateResults = (from creatureTemplate in SQL.CreatureTemplate.Values
                                       where
                                           (!operatorFilter || SQL.CreatureTemplate.Count(x => (creatureTemplate.UnitFlags & unitFlags) == 0) > 0) ||
                                           (operatorFilter || SQL.CreatureTemplate.Count(x => (creatureTemplate.UnitFlags & unitFlags) != 0) > 0)
                                       select creatureTemplate).ToList();
        }

        private void SearchResultListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedIndices.Count <= 0)
                return;

            if (SearchResultListView.SelectedIndices.Count > 0)
                creatureTemplateInformative = new CreatureTemplateInformative(CreatureInformativeRichTextBox, creatureTemplateResults[SearchResultListView.SelectedIndices[0]]);
        }


        private void UpdateTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            sqlReader.ExecuteCommand(UpdateTextBox.Text);
        }

        private void CreatureInformativeTextChanged(object sender, EventArgs e)
        {
            //new CreatureTemplateInformative(CreatureInformativeRichTextBox, creatureTemplateResults[SearchResultListView.SelectedIndices[0]]);
        }

        private void CreatureTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            Contract.Requires(CreatureTabControl.SelectedIndex < 9);
            Contract.Requires(CreatureTabControl.SelectedIndex >= 0);
            
            if (creatureTemplateInformative != null)
                return;

            switch (CreatureTabControl.SelectedIndex)
            {
                case 0:
                    creatureTemplateInformative.ViewCreatureTemplateInfo();
                    break;
                case 1:
                    creatureTemplateInformative.ViewCreatureVendorOrTrainerInfo();
                    break;
            }
        }

        private void FlagsSelectedIndexChanged(object sender, EventArgs e)
        {
            //if (((ComboBox)sender).SelectedIndex != 0)
                FlagFilter();
        }

        private void FlagsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FlagsComboBox.SelectedIndex)
            {
                case 1:
                    FlagsEnumValuesComboBox.SetEnumValues<UnitFlags>("");
                    break;
                case 2:
                    FlagsEnumValuesComboBox.SetEnumValues<DynamicFlags>("");
                    break;
                case 3:
                    FlagsEnumValuesComboBox.SetEnumValues<NPCFlags>("");
                    break;
                case 4:
                    FlagsEnumValuesComboBox.SetEnumValues<FlagsExtra>("");
                    break;
                case 5:
                    FlagsEnumValuesComboBox.SetEnumValues<TypeFlags>("");
                    break;
                case 6:
                    FlagsEnumValuesComboBox.SetEnumValues<UnitClass>("");
                    break;
                case 7:
                    FlagsEnumValuesComboBox.SetEnumValues<MechanicImmuneMask>("");
                    break;
                default:
                    break;
            }
        }

        private void AdvancedFilterComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdvancedFilterTextBox.Text != String.Empty)
                AdvancedFilter();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void TestConnect(object sender, MouseEventArgs e)
        {
            sqlReader.TestConnection();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // Load Creature Templates
            //SQLReader sqlReader = new SQLReader(this);
        }
    }
}

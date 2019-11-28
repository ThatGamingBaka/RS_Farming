using RS_Farming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RS_Farming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllMenus();
            LoadLocations();            
        }

        private void HideAllMenus()
        {
            AllotmentPatchesGroup.Visible = false;
        }

        private void LoadLocations()
        {
            Locations.Items.Clear();
            Locations.DisplayMember = "Name";
            Locations.ValueMember = "PatchesForLocation";

            var locations = new Locations().All;
            locations.ForEach(l => Locations.Items.Add(new { Name = l.Name, PatchesForLocation = l.PatchesForLocation }));
        }

        private void Locations_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllMenus();

            dynamic selectedLocation = Locations.SelectedItem;
            var unboxedSelection = new Location { Name = selectedLocation.Name, PatchesForLocation = selectedLocation.PatchesForLocation };
            var name = unboxedSelection.Name;
            var patches = unboxedSelection.PatchesForLocation;

            if (patches.Any(p => p.Type == Models.Type.Allotment))
            {
                ShowAllotmentsMenu();
            }
        }

        private void ShowAllotmentsMenu()
        {
            AllotmentPatchesGroup.Visible = true;
            LoadAllotments();
        }

        private void LoadAllotments()
        {
            var crops = new Crops().All;

            ConfigureComboBox(AllotmentPatchComboBox1, "Name", "GrowTimeInMinutes");
            ConfigureComboBox(AllotmentPatchComboBox2, "Name", "GrowTimeInMinutes");
            ConfigureComboBox(AllotmentFlowerComboBox, "Name", "GrowTimeInMinutes");
            ConfigureComboBox(AllotmentHerbComboBox, "Name", "GrowTimeInMinutes");

            crops.Where(c => c.SubType == SubType.Allotment).ToList()
                .ForEach(a => AllotmentPatchComboBox1.Items.Add(new { Name = a.Name, GrowTimeInMinutes = a.GrowTimeInMinutes }));

            crops.Where(c => c.SubType == SubType.Allotment).ToList()
                .ForEach(a => AllotmentPatchComboBox2.Items.Add(new { Name = a.Name, GrowTimeInMinutes = a.GrowTimeInMinutes }));

            crops.Where(c => c.SubType == SubType.Flower).ToList()
                .ForEach(f => AllotmentFlowerComboBox.Items.Add(new { Name = f.Name, GrowTimeInMinutes = f.GrowTimeInMinutes }));

            crops.Where(c => c.SubType == SubType.Herb).ToList()
                .ForEach(h => AllotmentHerbComboBox.Items.Add(new { Name = h.Name, GrowTimeInMinutes = h.GrowTimeInMinutes }));
        }

        private void ConfigureComboBox(ComboBox comboBox, string display, string value)
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = display;
            comboBox.ValueMember = value;
        }

        private HarvestData GetHarvestData(ComboBox cropToHarvest)
        {
            var currentTime = DateTime.Now;

            dynamic selectedLocation = Locations.SelectedItem;
            var unboxedLocationSelection = new Location { Name = selectedLocation.Name, PatchesForLocation = selectedLocation.PatchesForLocation };

            dynamic SelectedCrop = cropToHarvest.SelectedItem;
            var unboxedCropSelection = new Crop { Name = SelectedCrop.Name, GrowTimeInMinutes = SelectedCrop.GrowTimeInMinutes };

            return new HarvestData(currentTime, unboxedLocationSelection, unboxedCropSelection);
        }

        private void AllotmentPatch1Btn_Click(object sender, EventArgs e)
        {
            var data = GetHarvestData(AllotmentPatchComboBox1);
            ResultBox.Text += string.Format("You can harvest {0} in {1} at {2:00}:{3:00}.\n", data.CropName, data.Location, data.HarvestTime.Hour, data.HarvestTime.Minute);
        }

        private void AllotmentPatch2Btn_Click(object sender, EventArgs e)
        {
            var data = GetHarvestData(AllotmentPatchComboBox2);
            ResultBox.Text += string.Format("You can harvest {0} in {1} at {2}:{3}.\n", data.CropName, data.Location, data.HarvestTime.Hour, data.HarvestTime.Minute);
        }

        private void FlowerPatchBtn_Click(object sender, EventArgs e)
        {
            var data = GetHarvestData(AllotmentFlowerComboBox);
            ResultBox.Text += string.Format("You can harvest {0} in {1} at {2}:{3}.\n", data.CropName, data.Location, data.HarvestTime.Hour, data.HarvestTime.Minute);
        }

        private void HerbPatchBtn_Click(object sender, EventArgs e)
        {
            var data = GetHarvestData(AllotmentHerbComboBox);
            ResultBox.Text += string.Format("You can harvest {0} in {1} at {2}:{3}.\n", data.CropName, data.Location, data.HarvestTime.Hour, data.HarvestTime.Minute);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_Farming.Models
{
    class HarvestData
    {
        public DateTime HarvestTime;
        public string Location;
        public string CropName;

        public HarvestData(DateTime plantedTime, Location location, Crop crop)
        {
            HarvestTime = plantedTime.AddMinutes(crop.GrowTimeInMinutes);
            Location = location.Name;
            CropName = crop.Name;
        }
    }
}

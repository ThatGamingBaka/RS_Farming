using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS_Farming.Models
{
    enum Type { Allotment, Hop, Bush, Tree, Fruit_Tree, Cactus, Mushroom }
    enum SubType { Allotment, Flower, Herb}

    class Crop
    {
        public string Name;
        public Type Type;
        public int GrowTimeInMinutes;
        public SubType SubType;

        public static List<Crop> GetCrops()
        {
            return new List<Crop>()
            {
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Potato", GrowTimeInMinutes = 40 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Onion", GrowTimeInMinutes = 40 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Cabbage", GrowTimeInMinutes = 40 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Tomato", GrowTimeInMinutes = 40 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Sweetcorn", GrowTimeInMinutes = 50 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Strawberry", GrowTimeInMinutes = 60 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Watermelon", GrowTimeInMinutes = 70 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Snape grass", GrowTimeInMinutes = 200 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Sunchoke", GrowTimeInMinutes = 200 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Allotment, Name = "Fly trap", GrowTimeInMinutes = 200 },

                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Marigold", GrowTimeInMinutes = 20 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Rosemary", GrowTimeInMinutes = 20 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Nasturtium", GrowTimeInMinutes = 20 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Woad", GrowTimeInMinutes = 20 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Limpwurt", GrowTimeInMinutes = 20 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "White lily", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Flower, Name = "Butterfly flower", GrowTimeInMinutes = 160 },

                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Guam", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Marrentill", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Tarromin", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Harralander", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Gout tuber", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Ranarr", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Spirit weed", GrowTimeInMinutes = 100 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Toadflax", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Irit", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Wergali", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Avantoe", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Kwuarm", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Bloodweed", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Snapdragon", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Cadantine", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Lantadyme", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Arbuck", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Dwarf weed", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Torstol", GrowTimeInMinutes = 80 },
                new Crop{ Type = Type.Allotment, SubType = SubType.Herb, Name = "Fellstalk", GrowTimeInMinutes = 80 }


            };
        }
    }
}

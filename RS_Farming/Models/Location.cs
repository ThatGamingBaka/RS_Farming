using System.Collections.Generic;

namespace RS_Farming.Models
{
    public class Location
    {
        public string Name;
        public List<Patch> PatchesForLocation;
    }

    public class Locations
    {
        public List<Location> All = new List<Location>
        {

                new Location{
                    Name = "Canifis",
                    PatchesForLocation = new List<Patch>
                    {
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Flower },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Herb }
                    }
                },
                new Location{
                    Name = "Catherby",
                    PatchesForLocation = new List<Patch>
                    {
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Flower },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Herb }
                    }
                },
                new Location{
                    Name = "Player owned farm",
                    PatchesForLocation = new List<Patch>
                    {
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Flower },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Herb }
                    }
                },
                new Location{
                    Name = "Port Sarim",
                    PatchesForLocation = new List<Patch>
                    {
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Allotment },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Flower },
                        new Patch{ Type = Type.Allotment, SubType = SubType.Herb }
                    }
                }
            };
    }
}

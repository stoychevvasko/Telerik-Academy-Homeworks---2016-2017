namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using System.Collections.Generic;
    using IntergalacticTravel.Contracts;

    public class TeleportStation_Fake : TeleportStation
    {
        public TeleportStation_Fake(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location)
            : base(owner, galacticMap, location)
        {
        }

        public IBusinessOwner Owner
        {
            get
            {
                return this.owner;
            }
        }

        public IEnumerable<IPath> GalacticMap
        {
            get
            {
                return this.galacticMap;
            }
        }

        public ILocation Location
        {
            get
            {
                return this.location;
            }
        }
    }
}


    class StoneBuilder : IBuilder
    {
        public House House { get; set; } = new House {
            Name = "Stone House",
        };
        public IBuilder Reset()
        {
            House = new House();
            return this;
        }
        public IBuilder SetWall()
        {
            House.Wall++;
            return this;
        }
        public IBuilder SetDoor()
        {
            House.Door++;
            return this;
        }
        public IBuilder SetWindow()
        {
            House.Window++;
            return this;
        }
        public IBuilder SetPool()
        {
            House.Pool++;
            return this;
        }
        public IBuilder SetGarage()
        {
            House.Garage++;
            return this;
        }
        public IBuilder SetGarden()
        {
            House.Garden++;
            return this;
        }
        public IBuilder SetHasRoof()
        {
            House.HasRoof = true;
            return this;    
        }


        public IBuilder GetHouse()
        {
            return this;
        }
    }


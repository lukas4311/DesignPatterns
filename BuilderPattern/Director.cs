public class Director
    {
        private ICarBuilder builder;
        
        public Director(ICarBuilder builder)
        {
            this.builder = builder;
        }
        
        public void BuildLowCostCar()
        {
            this.builder.SetBodykit();
            this.builder.SetDoor();
            this.builder.SetHood();
            this.builder.SetWheelRim();
            this.builder.SetWindscreen();
        }
        
        public void BuildLuxuryCar()
        {
            this.builder.SetBodykit();
            this.builder.SetDoor();
            this.builder.SetHood();
            this.builder.SetWheelRim();
            this.builder.SetHeatedWindscreen();
            this.builder.SetTransmision();
            this.builder.SetGPS();
            this.builder.SetHeadset();
        }
    }
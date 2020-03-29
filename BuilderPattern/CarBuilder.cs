using System;

public class CarBuilder : ICarBuilder
{
    private Car car = new Car();

    public void SetBodykit()
    {
        this.car.AddPart("Hatchback");
    }

    public void SetWheelRim()
    {
        this.car.AddPart("16 inch rims");
    }

    public void SetDoor()
    {
        this.car.AddPart("Door");
    }

    public void SetWindscreen()
    {
        this.car.AddPart("Normal windscreen");
    }

    public void SetHeatedWindscreen()
    {
        this.car.AddPart("Heated windscreen");
    }

    public void SetHood()
    {
        this.car.AddPart("Hood");
    }

    public void SetTransmision()
    {
        this.car.AddPart("Manul transmision");
    }

    public void SetGPS()
    {
        this.car.AddPart("GPS");
    }

    public void SetHeadset()
    {
        this.car.AddPart("Headset");
    }

    public void Reset()
    {
        this.car = new Car();
    }

    public Car GetCar()
    {
        Car car = this.car;
        this.Reset();
        return car;
    }
}
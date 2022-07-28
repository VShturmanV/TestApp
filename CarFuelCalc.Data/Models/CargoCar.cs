namespace CarFuelCalc.Data.Models;

public class CargoCar : Car
{
    public int CargoWeight { get; private set; }
    public int MaxCargoWeight { get; private set; }

    public CargoCar(int speed, int fuelCapacity, double currentFuelLevel, double averageFuelConsumtion, int cargoWeight, int maxCargoWeight)
        : base(speed, fuelCapacity, currentFuelLevel, averageFuelConsumtion)
    {
        if (cargoWeight > maxCargoWeight || cargoWeight < 0)
        {
            throw new Exception("Недопустимое кол-во груза");
        }

        CargoWeight = cargoWeight;
        MaxCargoWeight = maxCargoWeight;
    }
}

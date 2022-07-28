namespace CarFuelCalc.Data.Models;

public class PassengerCar : Car
{
    public int PassengersCount { get; private set; }

    public PassengerCar(int speed, int fuelCapacity, double currentFuelLevel, double averageFuelConsumtion, int passengersCount)
        : base(speed, fuelCapacity, currentFuelLevel, averageFuelConsumtion)
    {
        if (passengersCount > 8 || passengersCount < 1)
        {
            throw new Exception("Недопустимое кол-во пассажиров");
        }

        PassengersCount = passengersCount;
    }
}

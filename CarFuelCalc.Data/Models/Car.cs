namespace CarFuelCalc.Data.Models;
public class Car
{
    public string CarType { get; private set; }
    public double AverageFuelConsumtion { get; private set; }
    public int FuelCapacity { get; private set; }
    public double CurrentFuelLevel { get; private set; }
    public int Speed { get; private set; }

    public Car(int speed, int fuelCapacity, double currentFuelLevel, double averageFuelConsumtion)
    {
        Speed = speed;
        FuelCapacity = fuelCapacity;
        CurrentFuelLevel = currentFuelLevel;
        AverageFuelConsumtion = averageFuelConsumtion;
    }

  

    public virtual double GetRemainDistance(bool calculateForFullCapacity)
    {
        if (calculateForFullCapacity)
        {
            return FuelCapacity / AverageFuelConsumtion*100;
        }
        else
        {
            return CurrentFuelLevel / AverageFuelConsumtion*100;
        }
    }
}

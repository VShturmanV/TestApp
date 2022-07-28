using CarFuelCalc.Data.Models;

var car = new Car(100, 67, 43, 5.3);

Console.WriteLine(car.GetRemainDistance(true));
Console.WriteLine(car.GetRemainDistance(false));
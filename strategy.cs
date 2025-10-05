using System;
namespace VehicleStrategyPattern
{
    public interface IDriveStrategy
    {
        void Drive();
    }
    public class NormalDrive : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine(" Driving in Normal Mode.");
        }
    }
    public class SportDrive : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine(" Driving in Sport Mode! Fast & Aggressive.");
        }
    }

    public class EcoDrive : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine(" Driving in Eco Mode. Fuel Efficient.");
        }
    }
    public class Vehicle
    {
        private IDriveStrategy _driveStrategy;
        public void SetDriveStrategy(IDriveStrategy strategy)
        {
            _driveStrategy = strategy;
        }
        public void Drive()
        {
            if (_driveStrategy == null)
            {
                Console.WriteLine("No driving strategy selected!");
            }
            else
            {
                _driveStrategy.Drive();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle();
            myCar.SetDriveStrategy(new NormalDrive());
            myCar.Drive();
            myCar.SetDriveStrategy(new SportDrive());
            myCar.Drive();
            myCar.SetDriveStrategy(new EcoDrive());
            myCar.Drive();
            Console.ReadLine();
        }
    }
}

using System;
namespace VehicleFactoryPattern
{
    public interface IVehicle
    {
        void Drive();
    }
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike");
        }
    }
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Truck");
        }
    }
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
        public void DeliverVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            Console.WriteLine("Vehicle delivered!");
            vehicle.Drive();
        }
    }
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carFactory = new CarFactory();
            carFactory.DeliverVehicle();
            VehicleFactory bikeFactory = new BikeFactory();
            bikeFactory.DeliverVehicle();
            VehicleFactory truckFactory = new TruckFactory();
            truckFactory.DeliverVehicle();
        }
    }
}

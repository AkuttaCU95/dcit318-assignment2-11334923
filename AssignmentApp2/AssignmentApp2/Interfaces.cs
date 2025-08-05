using System;

namespace AssignmentApp2
{
    // Define the interface
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving
        }
    }
}

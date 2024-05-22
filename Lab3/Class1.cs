using System;
using System.Collections.Generic;

namespace Lab3
{
    public class AbstractTransport
    {
        public int farePerKilometer;
        public int reachedDistance;
        public string name;
        public List<Seat> seats;
        public AbstractTransport() 
        {
            seats = new List<Seat>();
        }
    }
    public class Seat
    {
        public int number;
        public bool isOccupied;
    }
    public class LandTransport : AbstractTransport
    {

    }
    public class Bus : LandTransport
    {

    }
    public class Train : LandTransport
    {

    }
    public class Tram : LandTransport
    {

    }
    public class Taxi : LandTransport
    {

    }
    public class WaterTransport : AbstractTransport
    {

    }
    public class Ferry : WaterTransport
    {

    }
    public class Ship : WaterTransport
    {

    }
    public class Liner : WaterTransport
    {

    }
    public class AirTransport : AbstractTransport
    {
        public int flightAltitude;
    }
    public class Airplane : AirTransport
    {

    }
    public class Helicopter : AirTransport
    {

    }
    public class CostCalculator
    {
        public int GetCost(List<AbstractTransport> setTransport)
        {
            int cost = 0;
            foreach (AbstractTransport transport in setTransport)
                cost += transport.reachedDistance * transport.farePerKilometer;
            return cost;
        }
    }
    class Programm
    {
        static void Main()
        {
            TransportFactory transportFactory = new TransportFactory();
            CostCalculator costCalculator = new CostCalculator();
        }
    }
    public class TransportFactory
    {
        public AbstractTransport GetRandomTransport()
        {
            Random randomNumber = new Random();
            switch (randomNumber.Next(0, 9))
            {
                case 0:
                    return new Bus() { farePerKilometer = 20 };
                case 1:
                    return new Train() { farePerKilometer = 15 };
                case 2:
                    return new Tram() { farePerKilometer = 5 };
                case 3:
                    return new Taxi() { farePerKilometer = 40 };
                case 4:
                    return new Ferry() { farePerKilometer = 20 };
                case 5:
                    return new Ship() { farePerKilometer = 15 };
                case 6:
                    return new Liner() { farePerKilometer = 55 };
                case 7:
                    return new Helicopter() { farePerKilometer = 65 };
                default:
                    return new Airplane() { farePerKilometer = 25 };
            }
        }
    }
}

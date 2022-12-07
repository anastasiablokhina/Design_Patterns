using System;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            CarFactory audi_car = new AudiFactory();
            Client c1 = new Client(ford_car);
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}", c1.ToString(), c1.RunMaxSpeed(), c1.BodyType());
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}", c2.ToString(), c2.RunMaxSpeed(), c2.BodyType());
        }
    }
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
        public abstract AbstractEngine CreateEngine();
        public abstract AbstractBody CreateBody();
    }
    abstract class AbstractCar
    {
        public string Name { get; set; }
        public abstract int MaxSpeed(AbstractEngine engine);
        public abstract string BodyType(AbstractBody type);
    }
    abstract class AbstractEngine
    {
        public int max_speed { get; set; }
    }

    abstract class AbstractBody
    {
        public string type { get; set; }
    }

    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }
    }
    class FordCar : AbstractCar
    {
        public FordCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
        public override string BodyType(AbstractBody body)
        {
            string bt = body.type;
            return bt;
        }
    }
    class FordEngine : AbstractEngine
    {
        public FordEngine()
        {
            max_speed = 220;
        }
    }
    class FordBody : AbstractBody
    {
        public FordBody()
        {
            type = "Седан";
        }
    }

        class AudiFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Ауди");
        }
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new AudiBody();
        }
    }
    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }
        public override string BodyType(AbstractBody body)
        {
            string bt = body.type;
            return bt;
        }
    }
    class AudiEngine : AbstractEngine
    {
        public AudiEngine()
        {
            max_speed = 200;
        }
    }
    class AudiBody : AbstractBody
    {
        public AudiBody()
        {
            type = "Кроссовер";
        }
    }
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractBody abstractBody;
        public Client(CarFactory car_factory)
        {
            abstractCar = car_factory.CreateCar();
            abstractEngine = car_factory.CreateEngine();
            abstractBody = car_factory.CreateBody();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }
        public string BodyType()
        {
            return abstractCar.BodyType(abstractBody);
        }
        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}

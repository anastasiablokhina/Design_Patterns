using System;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}", c1.ToString(), c1.RunMaxSpeed(), c1.BodyType());

            CarFactory audi_car = new AudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}", c2.ToString(), c2.RunMaxSpeed(), c2.BodyType());

            BMWFactory bmw_car = BMWFactory.BmwFactory;
            Client c3 = new Client(bmw_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова {2}", c3.ToString(), c3.RunMaxSpeed(), c3.BodyType());
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
        public int maxSpeed { get; set; }
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
            int ms = engine.maxSpeed;
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
            maxSpeed = 220;
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
            int ms = engine.maxSpeed;
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
            maxSpeed = 200;
        }
    }
    class AudiBody : AbstractBody
    {
        public AudiBody()
        {
            type = "Кроссовер";
        }
    }

    class BMWFactory : CarFactory
    {
        public int maxSpeed;
        public string name;
        public string type;
        private BMWFactory() { }
        static Lazy<BMWFactory> bmwFactory = new Lazy<BMWFactory>(() => new BMWFactory());
        public static BMWFactory BmwFactory
        {
            get
            {
                return bmwFactory.Value;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new BMWCar("BMW");
        }
        public override AbstractEngine CreateEngine()
        {
            return new BMWEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new BMWBody();

        }
        class BMWCar : AbstractCar
        {
            public BMWCar(string name)
            {
                Name = name;
            }
            public override int MaxSpeed(AbstractEngine engine)
            {
                int ms = engine.maxSpeed;
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
        class BMWEngine : AbstractEngine
        {
            public BMWEngine()
            {
                maxSpeed = 180;
            }
        }
        class BMWBody : AbstractBody
        {
            public BMWBody()
            {
                type = "Минивэн";
            }
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

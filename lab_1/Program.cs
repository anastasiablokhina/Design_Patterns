using System;

namespace lab_1
{
    interface Sensor
    {
        float GetTemp();
    }
    class FahrenheitSensor : Sensor
    {
        private float currentTemp;
        public FahrenheitSensor(float ct) => this.currentTemp = ct;
        public float GetTemp() => currentTemp;
    }
    class CelsiusSensor : Sensor
    {
        private float currentTemp;
        public CelsiusSensor(float ct) => this.currentTemp = ct;
        public float GetTemp() => currentTemp;
    }
    class AdapterForFahrenheitSensor : Sensor
    {
        FahrenheitSensor fahrenheitSensor;
        public AdapterForFahrenheitSensor(FahrenheitSensor fahrenheitSensor) => this.fahrenheitSensor = fahrenheitSensor;
        public float GetTemp() => (fahrenheitSensor.GetTemp() - 32) * 5 / 9;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            float c = 25.0f;
            float f = 77.0f;
            Sensor cSensor = new CelsiusSensor(c);
            Sensor fSensor = new AdapterForFahrenheitSensor(new FahrenheitSensor(f));

            Console.WriteLine(cSensor.GetTemp());
            Console.WriteLine(fSensor.GetTemp());
        }
    }
}

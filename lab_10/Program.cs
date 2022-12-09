using System;

namespace lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renault reno = new Renault("Рено", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Навигация");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Навигация"), "Безопасность");
            Print(newmyReno);

            BMW bmw = new BMW("Бмв", "BMW x4", 699.0);
            Print(bmw);
            AutoBase mybmw = new HeatedSeats(bmw, "Подогрев");
            Print(mybmw);
            AutoBase newmybmw = new ClimateControl(new HeatedSeats(bmw, "Подогрев"), "Климат-контроль");
            Print(newmybmw);

        }
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }

}

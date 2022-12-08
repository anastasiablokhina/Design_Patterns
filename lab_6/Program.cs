using System;

namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Margarita m = new Margarita(30);
            Pepperoni p = new Pepperoni(35);
            HawaiianPizza h = new HawaiianPizza(25);

            m.Make();
            p.Make();
            h.Make();
        }
    }

    abstract class Pizza
    {
        protected int size { get; set; }

        protected Pizza(int size)
        {
            this.size = size;
        }

        protected virtual void RollOutDough() => Console.WriteLine("Раскатываем тесто на пиццу {0} см", size);
        protected virtual void SpreadSauce() => Console.WriteLine("Добавляем соус");
        protected abstract void AddIngredients();
        protected virtual void SpreadCheese() => Console.WriteLine("Добавляем сыр");
        protected virtual void Bake() => Console.WriteLine("Выпекаем 15 минут");

        public void Make()
        {
            RollOutDough();
            SpreadSauce();
            SpreadCheese();

            Bake();
            Console.WriteLine("Готово!\n");
        }
    }

    class Margarita : Pizza
    {
        public Margarita(int size) : base(size) { }

        protected override void AddIngredients() => Console.WriteLine("Добавляем томаты");
    }
    class Pepperoni : Pizza
    {
        public Pepperoni(int size) : base(size) { }

        protected override void AddIngredients() => Console.WriteLine("Добавляем салями");
    }
    class HawaiianPizza : Pizza
    {
        public HawaiianPizza(int size) : base(size) { }

        protected override void AddIngredients() => Console.WriteLine("Добавляем курицу и ананасы");
    }

}

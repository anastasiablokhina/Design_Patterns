using System;

namespace lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double result = 0;
            Console.WriteLine("Исходное значение: {0}", result);
            result = calculator.Add(5);

            Console.WriteLine("Прибавить 5: {0}", result);

            result = calculator.Sub(2);
            Console.WriteLine("Вычесть 2: {0}", result);

            result = calculator.Redo();
            Console.WriteLine("Повторить: {0}", result);
            
            result = calculator.Undo();
            Console.WriteLine("Отменить: {0}", result);

            result = calculator.Mul(4);
            Console.WriteLine("Умножить на 4: {0}", result);

            result = calculator.Div(6);
            Console.WriteLine("Поделить на 6: {0}", result);
        }
    }
}

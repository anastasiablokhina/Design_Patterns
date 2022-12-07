using System;

namespace lab_5
{
    interface IRoute
    {
        void Search(string src, string dst);
        void ShowMap(string src, string dst);
    }

    class RouteType
    {
        private IRoute route;
        public RouteType(IRoute route) => this.route = route;
        public void SetStrategy(IRoute route) => this.route = route;
        public void Search(string src, string dst) => route.Search(src, dst);
        public void ShowMap(string src, string dst) => route.ShowMap(src, dst);
    }

    class HighwayRoute : IRoute
    {
        public void Search(string src, string dst) => Console.WriteLine("Поиск маршрута {0} - {1} по автодорогам", src, dst);
        public void ShowMap(string src, string dst) => Console.WriteLine("Маршрут {0} - {1} по автодорогам показан на карте", src, dst);
    }

    class HikingRoute : IRoute
    {
        public void Search(string src, string dst) => Console.WriteLine("Поиск пешего маршрута {0} - {1}", src, dst);
        public void ShowMap(string src, string dst) => Console.WriteLine("Пеший маршрут {0} - {1} показан на карте", src, dst);
    }
    class CyclewayRoute : IRoute
    {
        public void Search(string src, string dst) => Console.WriteLine("Поиск маршрута {0} - {1} по велодорожкам", src, dst);
        public void ShowMap(string src, string dst) => Console.WriteLine("Маршрут {0} - {1} по велодорожкам показан на карте", src, dst);
    }
    class PublicTransportRoute : IRoute
    {
        public void Search(string src, string dst) => Console.WriteLine("Поиск маршрута {0} - {1} на общественном транспорте", src, dst);
        public void ShowMap(string src, string dst) => Console.WriteLine("Маршрут {0} - {1} на общественном транспорте показан на карте", src, dst);
    }

    class SightseeingRoute : IRoute
    {
        public void Search(string src, string dst) => Console.WriteLine("Поиск маршрута {0} - {1} по достопримечательностям", src, dst);
        public void ShowMap(string src, string dst) => Console.WriteLine("Маршрут {0} - {1} по достопримечательностям показан на карте", src, dst);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RouteType routeType = new RouteType(new HighwayRoute());
            string sourse = "ул. Ломоносова, 9";
            string destenation = "пр-кт Кронверкский, 49";
            routeType.Search(sourse, destenation);
            routeType.ShowMap(sourse, destenation);
            Console.WriteLine("\n");

            routeType.SetStrategy (new HikingRoute());
            routeType.Search(sourse, destenation);
            routeType.ShowMap(sourse, destenation);
            Console.WriteLine("\n");

            routeType.SetStrategy(new PublicTransportRoute());
            routeType.Search(sourse, destenation);
            routeType.ShowMap(sourse, destenation);
            Console.WriteLine("\n");
        }
    }
}

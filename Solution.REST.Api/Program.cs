using Nancy.Hosting.Self;
using System;

namespace Solution.REST.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostConfiguration hostConfigs = new HostConfiguration();
            hostConfigs.UrlReservations.CreateAutomatically = true;

            NancyHost host = new NancyHost(hostConfigs, new Uri("http://localhost:1234"));
            host.Start();
            Console.WriteLine("Servidor da Web em execução ...");

            Console.ReadLine();
            host.Stop();
        }
    }

    //public class Rectangle
    //{
        
    //}

    //public abstract class Shape
    //{
    //    public abstract void Draw();
    //}

    //public sealed class Square : Shape
    //{
    //    public override void Draw()
    //    {
    //        //implementação
    //    }
    //}

    //public sealed class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        //implementação
    //    }
    //}
}

using Nancy.Hosting.Self;
using Solution.Database.Entities.Champions;
using Solution.Database.Repositories;
using Solution.Global.DI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Policy;

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
}

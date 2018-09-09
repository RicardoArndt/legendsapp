using Solution.Database.Repositories;
using Solution.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Global.DI
{
    public class Injection
    {
        ServiceLocator _serviceLocator;

        public Injection()
        {
            _serviceLocator = new ServiceLocator();
        }

        public void RegisterRepositories()
        {
            _serviceLocator.Register<IChampionRepository, ChampionRepository>();
        } 

        public void RegisterServices()
        {
            //_serviceLocator.Register<ChampionService>();
        }
    }
}

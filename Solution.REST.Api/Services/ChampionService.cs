using Solution.Database.Entities.Champions;
using Solution.Database.Repositories;
using Solution.Database.Repositories.Interfaces;
using Solution.Global.DI;
using Solution.REST.Api.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Solution.REST.Api.Services
{
    public class ChampionService : IChampionService
    {
        IChampionRepository _championRepository;

        public ChampionService()
        {
            _championRepository = ServiceLocator.GetInstance<IChampionRepository>();
        }
        
        public List<Champion> GetAllChampions()
        {
            return _championRepository.GetAll().ToList();
        }
    }
}

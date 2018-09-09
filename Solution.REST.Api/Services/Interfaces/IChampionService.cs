using Solution.Database.Entities.Champions;
using System.Collections.Generic;

namespace Solution.REST.Api.Services.Interfaces
{
    interface IChampionService
    {
        List<Champion> GetAllChampions();
    }
}

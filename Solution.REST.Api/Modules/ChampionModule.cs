using Nancy;
using Solution.Database.Entities.Champions;
using Solution.Database.Repositories;
using Solution.Database.Repositories.Interfaces;
using Solution.Global.DI;
using Solution.REST.Api.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api.Modules
{
    public class ChampionModule : NancyModule
    {
        public ChampionModule()
        {
            Get[ChampionEndpointConfigurator.GET_ALL_CHAMPIONS.PATH] = parameters => {

                try
                {
                    IChampionRepository championRepository;

                    championRepository = ServiceLocator.GetInstance<IChampionRepository>();

                    championRepository.Add(new Champion("Darius", true));
                    championRepository.Add(new Champion("Riven", false));

                    championRepository.SaveAll();

                    return Response.AsJson("Success!", HttpStatusCode.OK);
                }
                catch
                {
                    return Response.AsJson(new Exception("Not possible add new Champion"), HttpStatusCode.BadRequest);
                }
            };

            Get["teste"] = parameters =>
            {
                IChampionRepository championRepository;

                championRepository = ServiceLocator.GetInstance<IChampionRepository>();

                return Response.AsJson(championRepository.GetAll(), HttpStatusCode.OK);
            };
        }
    }
}

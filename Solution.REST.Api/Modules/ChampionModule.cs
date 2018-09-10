using LeagueOfLegends.API.Endpoints;
using LeagueOfLegends.API.Services.Interfaces;
using Nancy;
using Newtonsoft.Json;
using Solution.Database.Entities.Champions;
using Solution.Database.Repositories;
using Solution.Database.Repositories.Interfaces;
using Solution.Global.DI;
using Solution.REST.Api.Endpoints;
using Solution.REST.Api.Services;
using Solution.REST.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api.Modules
{
    public class ChampionModule : NancyModule
    {
        IChampionService _championService;
        IBaseHttpClientService _baseHttpClientService;

        public ChampionModule()
        {
            _championService = ServiceLocator.GetInstance<IChampionService>();
            _baseHttpClientService = ServiceLocator.GetInstance<IBaseHttpClientService>();

            Get[ChampionEndpointConfigurator.GET_ALL_CHAMPIONS.PATH] = parameters => {
                return null;
                //try
                //{
                //    championRepository.Add(new Champion("Darius", true));
                //    championRepository.Add(new Champion("Riven", false));

                //    championRepository.SaveAll();

                //    return Response.AsJson("Success!", HttpStatusCode.OK);
                //}
                //catch
                //{
                //    return Response.AsJson(new Exception("Not possible add new Champion"), HttpStatusCode.BadRequest);
                //}
            };

            Get["teste"] = parameters =>
            {
                var task = _baseHttpClientService.GetDataAsync(LegendsAPIEndpointConfigurator.GET_ALL_CHAMPIONS.PATH);

                task.Wait();
                var response = JsonConvert.DeserializeObject(task.Result);

                return Response.AsJson(response, HttpStatusCode.OK);
            };
        }
    }
}

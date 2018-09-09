using Solution.REST.Api.Endpoints.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api.Endpoints
{
    public sealed class ChampionEndpointConfigurator : BaseEndpointConfigurator
    {
        private static string CHAMPIONS = "champions";

        public static ChampionEndpointConfigurator GET_ALL_CHAMPIONS = new ChampionEndpointConfigurator(ROOT, CHAMPIONS);

        public ChampionEndpointConfigurator(params string[] args) : base(args) { }
    }
}

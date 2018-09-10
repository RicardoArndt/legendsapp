using System.Linq;

namespace LeagueOfLegends.API.Endpoints
{
    public class LegendsAPIEndpointConfigurator
    {
        public string PATH { get; private set; }

        //private static string ROOT = "https://na1.api.riotgames.com/lol";

        public static LegendsAPIEndpointConfigurator GET_ALL_CHAMPIONS = new LegendsAPIEndpointConfigurator("platform", "v3", "champions");

        public LegendsAPIEndpointConfigurator(params string[] path)
        {
            PATH = "https://na1.api.riotgames.com/lol";

            path.ToList()
                .ForEach(p =>
                {
                    var current = p.Trim('/');
                    PATH = string.Format($"{PATH}/{p}");
                });

            PATH += "?api_key=RGAPI-779c312d-ec34-44aa-bb71-8af0f2d2dadf";
        }
    }
}

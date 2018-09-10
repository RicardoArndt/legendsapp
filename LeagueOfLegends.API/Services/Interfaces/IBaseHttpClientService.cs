using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends.API.Services.Interfaces
{
    public interface IBaseHttpClientService
    {
        Task<string> GetDataAsync(string path);
    }
}

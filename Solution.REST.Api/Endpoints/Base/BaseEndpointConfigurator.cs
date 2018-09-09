using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api.Endpoints.Base
{
    public abstract class BaseEndpointConfigurator
    {
        public string PATH { get; private set; }

        protected static string ROOT = "legendssolution";

        public BaseEndpointConfigurator(params string[] path)
        {
            path.ToList()
                .ForEach(p =>
                {
                    var current = p.Trim('/');
                    PATH = string.Format($"{PATH}/{p}");
                });
        }
    }
}

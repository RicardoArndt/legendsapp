using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Solution.Global.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.REST.Api
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        Injection _injection;

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            _injection = new Injection();
            _injection.RegisterRepositories();
            _injection.RegisterRepositories();
            _injection.RegisterServices();
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                                .WithHeader("Access-Control-Allow-Methods", "POST,GET,PUT,DELETE,OPTIONS")
                                .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });
        }
    }
}

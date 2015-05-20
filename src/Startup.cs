using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Post.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async x =>
            {
                await x.Response.WriteAsync("Hello World!");
            });
        }
    }
}

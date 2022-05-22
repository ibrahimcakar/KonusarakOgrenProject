using KonusarakOgrenProject.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace KonusarakOgrenProject.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ProjectContext>();
                context.Database.Migrate();
            }
        }
    }
}

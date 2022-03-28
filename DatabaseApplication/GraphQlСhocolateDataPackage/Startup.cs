using GraphQlСhocolateDataPackage.DataBaseContexts;
using GraphQlСhocolateDataPackage.Infrastructure.Configuration.Mapping;
using GraphQlСhocolateDataPackage.InstanceCommands.PersonCommands;
using GraphQlСhocolateDataPackage.InstanceQueries.PersonQueries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GraphQlСhocolateDataPackage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1", new OpenApiInfo() { Title = "PureCodeFirst", Version = "v1" }));

            

            services.AddDbContext<PersonContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("PersonConnection"));
            });

            services.AddGraphQLServer()
                .AddMutationType<PersonCommandsGeneralCrudApi>();

            services.AddGraphQLServer().AddQueryType<PersonQueriesGeneralApi>();

            services.AddMapping();

            services
                .AddGraphQLServer()
                .AddProjections()
                .AddFiltering();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PureCodeFirst"));

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();

                endpoints.MapControllers();
            });
        }
    }
}
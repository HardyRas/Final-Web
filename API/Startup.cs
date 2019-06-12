using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ML;
using API.DataModels;

namespace API
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
            //PredictionEngine is not thread - safe.For improved performance and thread safety,
            //..use the PredictionEnginePool service, 
            //..which creates an ObjectPool of PredictionEngine objects for application use

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddPredictionEnginePool<PrevalenceData, MalariaPrevalencePrediction>()
                .FromFile("MLModel/Model.zip");
        }

        //This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //To make a single prediction, use PredictionEngine
        //In order to use PredictionEngine in the application we must create it when it's needed. 
        //In that case, a best practice to consider is dependency injection.

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

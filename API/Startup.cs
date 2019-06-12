using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.ML;
using Microsoft.ML.Core.Data;
using Microsoft.ML.Data;
using System.IO;
using WebApi.DataModels;

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
    //        services.AddPredictionEnginePool<Malaria, MalariaPrevalencePrediction>()
    //.FromFile("MLModels/sentiment_model.zip");
            //The recommended way to share the ITransfomer object across
            //Http requests is to register it as singleton lifetime object 
            //..in an IoC container for Dependency Injection usage
            services.AddSingleton<MLContext>();

            //ML Model (ITransformed) created as singleton for the whole API. 
            //..Loads from .zip file here.
            //..It is thread safe
            services.AddSingleton<ITransformer,
                                    TransformerChain<ITransformer>>((ctx) =>
                                    {
                                        MLContext mlContext = ctx.GetRequiredService<MLContext>();
                                        string modelFilePathName = Configuration["Model:H:/Web/Final Web/Final Web"];

                                        ITransformer mlModel;
                                        using (var fileStream = File.OpenRead(modelFilePathName))
                                                   mlModel = mlContext.Model.Load(fileStream);

                                        return (TransformerChain<ITransformer>)mlModel;
                                    });
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

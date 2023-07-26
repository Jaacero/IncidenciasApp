using AspNetCoreRateLimit;
using Core.Interfaces;
using Infrastructure.UnityOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace API.Extensions
{
    public static class AplicationServiceExtensions
    {
        public static void ConfigCores(this IServiceCollection services) =>
             services.AddCors(options =>
             {
                 options.AddPolicy("CorsPolicy", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
             });
        public static void AddAplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnityOfWork, UnityOfWork>();
        }
        public static void ConfigureRateLimiting(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IRateLimitConfiguration,RateLimitConfiguration>();
            services.AddInMemoryRateLimiting();
            services.Configure<IpRateLimitOptions>(options =>{
                options.EnableEndpointRateLimiting =true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                options.GeneralRules = new List<RateLimitRule>
                {
                    new RateLimitRule
                    {
                        Endpoint = "*",
                        Period = "10s",
                        Limit = 2
                    }

                };
            });
        }
        public static void ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>{
                options.DefaultApiVersion = new ApiVersion(1,0);
                options.AssumeDefaultVersionWhenUnspecified = true;

                //options.ApiVersionReader = new QueryStringApiVersionReader("v");
                //options.ApiVersionReader = new HeaderApiVersionReader("X-Version");
                options.ApiVersionReader = ApiVersionReader.Combine(new QueryStringApiVersionReader("v"),
                new HeaderApiVersionReader("X-Version")
                );


            });
        }
    }

}
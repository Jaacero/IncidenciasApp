using Core.Interfaces;
using Infrastructure.UnityOfWork;

namespace API.Extensions
{
    public static class AplicationServiceExtensions
    {
       public static void ConfigCores(this IServiceCollection services)=>
            services.AddCors(options =>{
                options.AddPolicy("CorsPolicy",builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            }); 
        public static void AddAplicationServices(this IServiceCollection services){
            services.AddScoped<IUnityOfWork,UnityOfWork>();
        }
    }
}
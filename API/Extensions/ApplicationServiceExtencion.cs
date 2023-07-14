

namespace API.Extensions;

public static class ApplicationServiceExtencion
{
    public static void ConfigureCors(this IServiceCollection service) => service.AddCors(
        option => {
            option.AddPolicy(
                "CorsPolicy",
                builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
                //desde cualquier servidor se conecta a tu endpoint
                //permitir cualquier header xml json 
                //permitir cualquier metodo
            );

        }
        
    );
    
}

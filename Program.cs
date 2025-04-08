using FFCE.Data;
using FFCE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Design;
namespace FFCE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Configurar a aplicação e adicionar o DbContext
/* The line `var builder = WebApplication.CreateBuilder(args);` is creating a new
instance of a `WebApplicationBuilder` using the `CreateBuilder` method provided
by the `WebApplication` class. This method is part of ASP.NET Core and is used
to set up and configure the web application. */
            var builder = WebApplication.CreateBuilder(args);

            // Configurar o DbContext para usar o SQL Server (ou outro banco de dados)
/* This code snippet is configuring the DbContext for the application to use SQL
Server (or another database provider). */
            builder.Services.AddDbContext<FloricultureDataContext>(options =>
    options.UseSqlServer("Server=localhost,1433;Database=balta; User ID=sa; Password=1q2w3e4r@#$; TrustServerCertificate=True"));
//modificar isso depois

            // Adicionar outros serviços, como controllers, etc.
/* The line `builder.Services.AddControllers();` is adding the controllers as
services to the application. In ASP.NET Core, controllers are responsible for
handling incoming HTTP requests and returning appropriate responses. By adding
controllers as services, the application is configured to use controllers to
handle requests and provide responses, typically for building APIs or web
applications. */
            builder.Services.AddControllers();

/* The line `var app = builder.Build();` is building the web application using the
configuration set up in the `builder` instance. This method call is responsible
for creating the application based on the services, middleware, and other
configurations that have been added to the `builder` instance. Once the
application is built, it is ready to be run and handle incoming HTTP requests. */
            var app = builder.Build();

/* The lines `app.UseHttpsRedirection();` and `app.MapControllers();` are
configuring the request pipeline in the ASP.NET Core application. */
            // Configuração da pipeline de requisição
            app.UseHttpsRedirection();
            app.MapControllers(); // Isso irá mapear os controladores para a API

            // Executar a aplicação
            app.Run();
        }
    }
}

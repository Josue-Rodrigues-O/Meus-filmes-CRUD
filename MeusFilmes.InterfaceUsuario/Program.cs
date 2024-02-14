using MeusFilmes.Infraestrutura.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MeusFilmes.InterfaceUsuario
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var builder = CriaHostBuilder();
            using var build = builder.Build();
            var serviceProvider = build.Services;
            var forms = serviceProvider.GetRequiredService<ListaFilmes>();
            Application.Run(forms);
        }

        private static IHostBuilder CriaHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureContainer<IServiceCollection>((context, services) =>
                {
                    services.AddScoped<ListaFilmes>();
                    services.AddScoped<IRepositorio, RepositorioRaven>();
                });
        }
    }
}
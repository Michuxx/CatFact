using CatFactWinForms;
using CatFactWinForms.Interfaces;
using CatFactWinForms.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Http;

namespace CatFactWinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    services.AddHttpClient<ICatFactService, CatFactService>();
                    services.AddSingleton<FileWriter>(provider => new FileWriter("catfacts.txt"));
                    services.AddSingleton<Form1>();
                })
                .Build();

            ApplicationConfiguration.Initialize();
            var form = host.Services.GetRequiredService<Form1>();
            Application.Run(form);
        }
    }
}

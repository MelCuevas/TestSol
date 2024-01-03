// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Escritorio;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddHttpClient<ITestSolClient, TestSolCliente>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:7255");
                });
                services.AddTransient<Form1>();
            });
    }
}
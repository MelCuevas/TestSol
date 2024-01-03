// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Negocio;

public static class Extensiones
{
    public static Configuracion AddAppConfigurationWithSettings(this WebApplicationBuilder builder)
    {
        var configuracion = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        var instance = new Configuracion();

        var value = configuracion.GetSection("AppSettings");

        value.Bind(instance);

        builder.Services.AddSingleton(instance);

        return instance;
    }
}
// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Datos;

public class Contexto : DbContext
{
    private readonly Configuracion confi;

    public DbSet<Empleado> Empleados { get; set; }
    public Contexto(Configuracion configuracion)
    {
        confi = configuracion;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(confi.cadenaDeConexion);
        base.OnConfiguring(optionsBuilder);
    }
}
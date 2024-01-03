// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.UI.Comun.Interfaces;

public interface ITestSolClient
{
    Task<List<Empleado>> ObtenerEmpleadosAsync();
    Task<Empleado> ObtenerEmpleadoPorIdAsync(int id);
    Task EliminarEmpleadoPorIdAsync(int id);
    Task CrearEmpleadoAsync(Empleado empleado);
    Task ActualizarEmpleadoAsync(Empleado empleado);
}
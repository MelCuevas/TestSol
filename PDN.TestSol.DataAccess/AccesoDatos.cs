// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.DataAccess;

public class AccesoDatos
{
    private readonly Configuracion confi;
    public AccesoDatos(Configuracion confi)
    {
        this.confi = confi;
    }

    /// <summary>
    /// Agregar un empleado
    /// </summary>
    /// <param name="empleado">Empleado a agregar</param>
    /// <returns>Awaitable Task</returns>
    public async Task AgregarAsyncEmpleado(Empleado empleado)
    {
        using Contexto ContexColaborador = new(confi);
        ContexColaborador.Empleados.Add(empleado);
        await ContexColaborador.SaveChangesAsync();
    }

    /// <summary>
    /// Obtiene todos los empleados
    /// </summary>
    /// <returns>Awaitable Task</returns>
    public async Task<List<Empleado>> ObtieneEmpleadosAsync()
    {
        using Contexto ContexColaborador = new(confi);
        List<Empleado> resultado = await ContexColaborador
            .Empleados
            .ToListAsync();
        return resultado;

    }

    /// <summary>
    /// Obtiene empleado por ID
    /// </summary>
    /// <param name="id">ID a obtener</param>
    /// <returns>Empleado</returns>
    public async Task<Empleado> ObtieneEmpleadoPorIdAsync(int id)
    {
        using Contexto contexto = new(confi);
        var item = await contexto
        .Empleados
        .ToListAsync();
        return item.FirstOrDefault(emp => emp.Id == id);

    }

    /// <summary>
    /// Actualiza empleado
    /// </summary>
    /// <param name="empleado">Empleado a actualizar</param>
    /// <returns>Awaitable Task</returns>
    public async Task ActualizarEmpleadoAsync(Empleado empleado)
    {
        using Contexto contexto = new(confi);
        contexto.Empleados.Update(empleado);
        await contexto.SaveChangesAsync();

    }

    /// <summary>
    /// Elimina empleado por ID
    /// </summary>
    /// <param name="id">ID a eliminar</param>
    /// <returns>Awaitable Task</returns>
    public async Task BajaEmpleadoAsync(int id)
    {
        using Contexto contexto = new(confi);
        var empleado = await contexto
        .Empleados
        .Where(emp => emp.Id == id)
        .FirstOrDefaultAsync();
        if (empleado is not null)
            contexto.Empleados.Remove(empleado);
        await contexto.SaveChangesAsync();
    }
}
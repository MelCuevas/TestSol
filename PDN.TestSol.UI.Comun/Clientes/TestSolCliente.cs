// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.UI.Comun.Clientes;

public class TestSolCliente : ITestSolClient
{
    private readonly HttpClient client;
    public TestSolCliente(HttpClient client)
    {
        this.client = client;
    }

    /// <summary>
    /// Obtiene todos los empleados
    /// </summary>
    /// <returns>Lista de empleados</returns>
    public async Task<List<Empleado>> ObtenerEmpleadosAsync()
    {
        var resultado = await client.GetAsync("api/Empleado");
        string resultadoEmpleado = await resultado.Content.ReadAsStringAsync();
        List<Empleado> resultadoLista = JsonConvert.DeserializeObject<List<Empleado>>(resultadoEmpleado);
        return resultadoLista;
    }

    /// <summary>
    /// Obtiene empleado por ID
    /// </summary>
    /// <param name="id">ID a buscar</param>
    /// <returns>Empleado</returns>
    public async Task<Empleado> ObtenerEmpleadoPorIdAsync(int id)
    {
        var resultado = await client.GetAsync($"api/Empleado/{id}");
        string resultadoEmpleado = await resultado.Content.ReadAsStringAsync();
        Empleado empleado = JsonConvert.DeserializeObject<Empleado>(resultadoEmpleado);
        return empleado;
    }

    /// <summary>
    /// Elimina empleado por ID
    /// </summary>
    /// <param name="id">ID a eliminar</param>
    /// <returns>Awaitable Task</returns>
    public async Task EliminarEmpleadoPorIdAsync(int id)
    {
        await client.DeleteAsync($"api/Empleado/{id}");
    }

    /// <summary>
    /// Crea un empleado
    /// </summary>
    /// <param name="empleado">Empleado a crear</param>
    /// <returns>Awaitable Task</returns>
    public async Task CrearEmpleadoAsync(Empleado empleado)
    {
        await client.PostAsJsonAsync("api/Empleado", empleado);
    }

    /// <summary>
    /// Actualiza un empleado
    /// </summary>
    /// <param name="empleado">Empleado a actualizar</param>
    /// <returns>Awaitable Task</returns>
    public async Task ActualizarEmpleadoAsync(Empleado empleado)
    {
        await client.PutAsJsonAsync("api/Empleado", empleado);
    }

}

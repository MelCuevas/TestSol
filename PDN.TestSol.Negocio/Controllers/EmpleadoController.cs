// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Negocio.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmpleadoController : ControllerBase
{
    public readonly AccesoDatos accesoDatos;
    public EmpleadoController(AccesoDatos accesoDatos)
    {
        this.accesoDatos = accesoDatos;
    }


    /// <summary>
    /// Agrega empleado
    /// </summary>
    /// <param name="empleado">Empleado a agregar</param>
    /// <returns>IActionResult</returns>
    [HttpPost]
    public async Task<IActionResult> AgregarAsyncEmpleados([FromBody] Empleado empleado)
    {
        await accesoDatos.AgregarAsyncEmpleado(empleado);
        return Ok();
    }

    /// <summary>
    /// Obtiene todos los empleados
    /// </summary>
    /// <returns>IActionResult</returns>
    [HttpGet]
    public async Task<IActionResult> ObtenerEmpleadosAsync()
    {
        var colaboradores = await accesoDatos.ObtieneEmpleadosAsync();
        return Ok(colaboradores);
    }

    /// <summary>
    /// Obtiene empleado por ID
    /// </summary>
    /// <param name="id">ID a buscar</param>
    /// <returns>IActionResult</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> ObtenerEmpleadoPorIdAsync([FromRoute] int id)
    {
        var EmpleadoID = await accesoDatos.ObtieneEmpleadoPorIdAsync(id);
        return Ok(EmpleadoID);
    }

    /// <summary>
    /// Actualiza empleado
    /// </summary>
    /// <param name="empleado">Empleado a actualizar</param>
    /// <returns>IActionResult</returns>
    [HttpPut]
    public async Task<IActionResult> ActualizarEmpleadoAsync([FromBody] Empleado empleado)
    {
        await accesoDatos.ActualizarEmpleadoAsync(empleado);
        return Ok();
    }

    /// <summary>
    /// Elimina un empleado por ID
    /// </summary>
    /// <param name="id">ID a eliminar</param>
    /// <returns>IActionResult</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> BajaEmpleadoAsync([FromRoute] int id)
    {
        await accesoDatos.BajaEmpleadoAsync(id);
        return Ok();
    }
}
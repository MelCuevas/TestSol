// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.UI.Controllers;

public class HomeController : Controller
{
    private readonly ITestSolClient cliente;
    public HomeController(ITestSolClient testSolCliente)
    {
        cliente = testSolCliente;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AgregarEmpleado()
    {
        return View();
    }

    public async Task<IActionResult> EditarEmpleado(int id)
    {
        var task = await cliente.ObtenerEmpleadoPorIdAsync(id);

        return View(task);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerEmpleados()
    {
        return Json(new { data = await cliente.ObtenerEmpleadosAsync() });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObtenerEmpleadoPorId([FromRoute] int id)
    {
        var empleado = await cliente.ObtenerEmpleadoPorIdAsync(id);
        return Json(empleado);
    }

    [HttpDelete("eliminarEmpleado/{id}")]
    public async Task<IActionResult> EliminarEmpleado([FromRoute] int id)
    {
        await cliente.EliminarEmpleadoPorIdAsync(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> ActualizarEmpleado([FromBody] Empleado empleado)
    {
        await cliente.ActualizarEmpleadoAsync(empleado);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CrearEmpleado([FromBody] Empleado empleado)
    {
        await cliente.CrearEmpleadoAsync(empleado);

        return Ok();
    }
}
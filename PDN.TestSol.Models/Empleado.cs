// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Models;

[Table("Empleados")]
public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Area { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public decimal Sueldo { get; set; }
}
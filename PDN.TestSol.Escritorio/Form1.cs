// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.Escritorio;

public partial class Form1 : Form
{
    private readonly ITestSolClient cliente;

    public Form1(ITestSolClient cliente)
    {
        InitializeComponent();

        this.cliente = cliente;
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        await RefrescarGridviewAsync();
    }

    private void btnNuevoEmpleado_Click(object sender, EventArgs e)
    {
        var t = new NuevoEmpleado(cliente, false, null, this);
        t.Show();
    }

    private void btnEditarEmpleado_Click(object sender, EventArgs e)
    {
        var selectedRow = dataTable.SelectedCells[0].OwningRow;

        var empleado = new Empleado()
        {
            Id = Convert.ToInt32(selectedRow.Cells[0].Value),
            Nombre = selectedRow.Cells[1].Value.ToString(),
            ApellidoMaterno = selectedRow.Cells[3].Value.ToString(),
            ApellidoPaterno = selectedRow.Cells[2].Value.ToString(),
            Sueldo = Convert.ToDecimal(selectedRow.Cells[6].Value),
            Area = selectedRow.Cells[4].Value.ToString(),
            FechaNacimiento = Convert.ToDateTime(selectedRow.Cells[5].Value)
        };

        var t = new NuevoEmpleado(cliente, true, empleado, this);
        t.Show();
    }

    private async void btnEliminar_Click(object sender, EventArgs e)
    {
        var selectedRow = dataTable.SelectedCells[0].OwningRow;
        var id = Convert.ToInt32(selectedRow.Cells[0].Value);

        await cliente.EliminarEmpleadoPorIdAsync(id);

        MessageBox.Show("Empleado eliminado exitosamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        await RefrescarGridviewAsync();
    }

    public async Task RefrescarGridviewAsync()
    {
        var empleados = await cliente.ObtenerEmpleadosAsync();

        dataTable.DataSource = empleados;
    }
}

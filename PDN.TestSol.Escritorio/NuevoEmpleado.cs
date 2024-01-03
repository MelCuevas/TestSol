// ---------------------------------------------------------------------------------- 
// Copyright (c) PDN
// Licensed under the MIT License
// ----------------------------------------------------------------------------------

namespace PDN.TestSol.UI.Escritorio;

public partial class NuevoEmpleado : Form
{
    private readonly ITestSolClient cliente;
    private readonly bool isEdit;
    private readonly Empleado empleado;
    private readonly Form1 form1;

    public NuevoEmpleado(ITestSolClient cliente, bool isEdit, Empleado empleado, Form1 form1)
    {
        InitializeComponent();

        this.cliente = cliente;
        this.isEdit = isEdit;
        this.empleado = empleado;
        this.form1 = form1;
    }

    private void NuevoEmpleado_Load(object sender, EventArgs e)
    {
        if (isEdit)
        {
            lblId.Text = empleado.Id.ToString();
            txtNombre.Text = empleado.Nombre;
            txtApellidoPaterno.Text = empleado.Nombre;
            txtApellidoMaterno.Text = empleado.Nombre;
            txtArea.Text = empleado.Area;
            txtSueldo.Text = empleado.Sueldo.ToString();
            txtFechaNacimiento.Value = empleado.FechaNacimiento;
        }
        else
        {
            lblId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            //txtFechaNacimiento.Value = "";
        }
    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        var newEmpleado = new Empleado()
        {
            Nombre = txtNombre.Text,
            ApellidoMaterno = txtApellidoMaterno.Text,
            ApellidoPaterno = txtApellidoPaterno.Text,
            Sueldo = Convert.ToDecimal(txtSueldo.Text),
            Area = txtArea.Text,
            FechaNacimiento = txtFechaNacimiento.Value
        };

        if (isEdit)
        {
            newEmpleado.Id = empleado.Id;
            await cliente.ActualizarEmpleadoAsync(newEmpleado);
        }
        else
            await cliente.CrearEmpleadoAsync(newEmpleado);

        if (!isEdit)
            MessageBox.Show("Empleado creado exitosamente", "Creacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        else
            MessageBox.Show("Empleado actualizado exitosamente", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Close();

        await form1.RefrescarGridviewAsync();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }
}
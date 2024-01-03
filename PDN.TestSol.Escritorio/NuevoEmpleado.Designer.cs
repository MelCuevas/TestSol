namespace PDN.TestSol.UI.Escritorio
{
    partial class NuevoEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtSueldo = new TextBox();
            lblId = new Label();
            txtFechaNacimiento = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtArea = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 62);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 167);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 274);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 379);
            label4.Name = "label4";
            label4.Size = new Size(200, 32);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 591);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 4;
            label5.Text = "Sueldo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 695);
            label6.Name = "label6";
            label6.Size = new Size(240, 32);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(521, 164);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 39);
            txtNombre.TabIndex = 7;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(521, 274);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(283, 39);
            txtApellidoPaterno.TabIndex = 8;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(521, 376);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(283, 39);
            txtApellidoMaterno.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(521, 588);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(283, 39);
            txtSueldo.TabIndex = 10;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(521, 62);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 32);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(521, 695);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(400, 39);
            txtFechaNacimiento.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(211, 811);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 72);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(721, 811);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 72);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(521, 478);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(283, 39);
            txtArea.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 481);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 17;
            label7.Text = "Area";
            // 
            // NuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 997);
            Controls.Add(txtArea);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(lblId);
            Controls.Add(txtSueldo);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoEmpleado";
            Load += NuevoEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtSueldo;
        private Label lblId;
        private DateTimePicker txtFechaNacimiento;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtArea;
        private Label label7;
    }
}
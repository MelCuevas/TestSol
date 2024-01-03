namespace PDN.TestSol.Escritorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataTable = new DataGridView();
            btnNuevoEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            SuspendLayout();
            // 
            // dataTable
            // 
            dataTable.AllowUserToAddRows = false;
            dataTable.AllowUserToDeleteRows = false;
            dataTable.AllowUserToResizeRows = false;
            dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(96, 148);
            dataTable.Name = "dataTable";
            dataTable.ReadOnly = true;
            dataTable.RowHeadersWidth = 82;
            dataTable.Size = new Size(1588, 852);
            dataTable.TabIndex = 0;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.Location = new Point(96, 38);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(245, 46);
            btnNuevoEmpleado.TabIndex = 1;
            btnNuevoEmpleado.Text = "Nuevo empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = true;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Location = new Point(402, 38);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(245, 46);
            btnEditarEmpleado.TabIndex = 2;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(713, 38);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(245, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1798, 1076);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(dataTable);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Sol";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataTable;
        private Button btnNuevoEmpleado;
        private Button btnEditarEmpleado;
        private Button btnEliminar;
    }
}

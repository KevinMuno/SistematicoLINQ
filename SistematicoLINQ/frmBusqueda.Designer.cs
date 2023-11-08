namespace SistematicoLINQ
{
    partial class frmBusqueda
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
            groupBox1 = new GroupBox();
            txtSalario = new TextBox();
            txtCargo = new TextBox();
            txtEmpresa = new TextBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtBusqueda = new TextBox();
            label1 = new Label();
            dgvDetalles = new DataGridView();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(41, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Personal";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(125, 353);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(202, 23);
            txtSalario.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(125, 257);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(202, 23);
            txtCargo.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(125, 182);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(202, 23);
            txtEmpresa.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(125, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 23);
            txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 23);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 356);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 4;
            label6.Text = "Salario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 265);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 190);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 113);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 1;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBusqueda);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(424, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 101);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro de Busqueda";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(99, 47);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(255, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(435, 150);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(587, 338);
            dgvDetalles.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(45, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 32);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(290, 456);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 32);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(876, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 30);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 515);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvDetalles);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBusqueda";
            Text = "frmBusqueda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridView dgvDetalles;
        private TextBox txtSalario;
        private TextBox txtCargo;
        private TextBox txtEmpresa;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnBuscar;
    }
}
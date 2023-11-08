using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoLINQ
{
    public partial class frmBusqueda : Form
    {
        List<Usuario> usuario = new List<Usuario>();
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario.Add(new Usuario
            {
                Nombre = txtNombre.Text,
                ID = int.Parse(txtId.Text),
                Empresa = txtEmpresa.Text,
                Cargo = txtCargo.Text,
                Salario = double.Parse(txtSalario.Text),
            });

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = usuario;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPersona = txtBusqueda.Text;

            //var resultados = usuario.Where(p => p.Nombre.Contains(buscarPersona)).ToList(); // Expresiones Lambda

            var resultados = (from usuarios in usuario
                             where usuarios.Nombre.Contains(buscarPersona)  // LINQ
                             select usuarios).ToList();

            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = resultados;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtId.Clear();
            txtEmpresa.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtNombre.Focus();
        }
    }
}

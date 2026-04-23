using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace WindowsFormsApp
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(articuloSeleccionado, true);
            modificar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado, false);
            modificar.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                dataGridView1.DataSource = negocio.Listar();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Descripcion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}

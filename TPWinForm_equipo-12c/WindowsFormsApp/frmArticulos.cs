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
            ArticuloNegocio negocio = new ArticuloNegocio();
            dataGridArticulos.DataSource = negocio.Listar();
            dataGridArticulos.Columns["Id"].Visible = false;
            dataGridArticulos.Columns["Descripcion"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Articulo articuloSeleccionado = (Articulo)dataGridArticulos.CurrentRow.DataBoundItem;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articuloNegocio.verDetalleArticulo(articuloSeleccionado.Id);

        }
    }
}

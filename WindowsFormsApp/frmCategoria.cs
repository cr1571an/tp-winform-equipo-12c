using Dominio;
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

namespace WindowsFormsApp
{
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategoria;
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargar()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategoria = negocio.listar();
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = listaCategoria;

                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvCategorias.Columns["Id"].Visible = false;
            dgvCategorias.ColumnHeadersVisible = false;
        }
        private void frmCategorias_Load_1(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null && dgvCategorias.CurrentRow.DataBoundItem != null)
            {
                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                frmAltaCategorias modificar = new frmAltaCategorias(seleccionado);
                modificar.ShowDialog();

                cargar();
            }
            else
            {
                MessageBox.Show("Seleccioná la categoria a modificar.");
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaCategorias alta = new frmAltaCategorias();
            alta.ShowDialog();
            cargar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                CategoriaNegocio marca = new CategoriaNegocio();
                marca.eliminar(seleccionado.Id);
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccioná la categoria a eliminar.");
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = txtCategoria.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaCategoria.FindAll(X =>
                    X.Descripcion.ToUpper().Contains(filtro.ToUpper())
                );
            }
            else
            {
                listaFiltrada = listaCategoria;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
            dgvCategorias.Columns["Id"].Visible = false;
            dgvCategorias.ColumnHeadersVisible = false;
        }
    }
}
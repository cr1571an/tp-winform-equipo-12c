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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarca;
        public frmMarcas()
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
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarca = negocio.listar();
                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = listaMarca;

                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvMarcas.Columns["Id"].Visible = false;
            dgvMarcas.ColumnHeadersVisible = false;
        }
        private void frmMarcas_Load_1(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null && dgvMarcas.CurrentRow.DataBoundItem != null)
            {
                Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                frmAltaMarcas modificar = new frmAltaMarcas(seleccionado);
                modificar.ShowDialog();

                cargar();
            }
            else
            {
                MessageBox.Show("Seleccioná la marca a modificar.");
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAltaMarcas alta = new frmAltaMarcas();
            alta.ShowDialog();
            cargar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                MarcaNegocio marca = new MarcaNegocio();
                marca.eliminar(seleccionado.Id);
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccioná la marca a eliaminar.");
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = txtMarca.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaMarca.FindAll(X =>
                    X.Descripcion.ToUpper().Contains(filtro.ToUpper())
                );
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltrada;
            dgvMarcas.Columns["Id"].Visible = false;
            dgvMarcas.ColumnHeadersVisible = false;
        }
    }
}
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
    public partial class frmAltaCategorias : Form
    {
        private Categoria categoria = null;
        public frmAltaCategorias()
        {
            InitializeComponent();
        }
        public frmAltaCategorias(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void frmAltaCategorias_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                this.Text = "Modificacion";
                txtCategoria.Text = categoria.Descripcion;
                lblMensaje.Text = "Modificar Categoria";
            }
            else
            {
                this.Text = "Agregar";
                lblMensaje.Text = "  Nueva Categoria  ";
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null) categoria = new Categoria();
                categoria.Descripcion = txtCategoria.Text;
                if (categoria.Id == 0)
                {
                    if (!negocio.existe(categoria.Descripcion))
                    {
                        negocio.agregar(categoria);
                        MessageBox.Show("Categoria agregada.");
                    }
                    else
                        MessageBox.Show("La Categoria ya existe, es posible agregarla.");
                    
                }
                else
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Categoria modificada.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

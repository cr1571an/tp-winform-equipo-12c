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
    public partial class frmAltaMarcas : Form
    {
        private Marca marca = null;
        public frmAltaMarcas()
        {
            InitializeComponent();
        }
        public frmAltaMarcas(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void frmAltaMarcas_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                this.Text = "Modificacion";
                txtMarca.Text = marca.Descripcion;
                lblMensaje.Text = "Modificar marca";
            }
            else
            {
                this.Text = "Agregar";
                lblMensaje.Text = "  Nueva marca  ";
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (!ValidadorUI.ValidarMaxCaracteres(txtMarca, 50, "Máximo 50 caracteres", errorProvider1)) return;
                
                if (marca == null) marca = new Marca();
                marca.Descripcion = txtMarca.Text;
                if (marca.Id == 0)
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada.");
                }
                else
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Marca modificada.");
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

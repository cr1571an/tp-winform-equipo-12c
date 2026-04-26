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
using Negocio;
using WindowsFormsApp.Helpers;

namespace WindowsFormsApp
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private bool ver = false;
        private OpenFileDialog archivo = null;
        private List<Imagen> imagenesArticulo = new List<Imagen>();
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo, bool ver)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.ver = ver;
            if (ver)
                Text = "Ver Articulo";
            else
                Text = "Modificar Articulo";

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();

                    if (articulo.Imagenes != null)
                    {
                        imagenesArticulo = articulo.Imagenes;

                        foreach (Imagen img in imagenesArticulo)
                        {
                            lstImagenes.Items.Add(img.ImagenUrl);
                        }

                        if (imagenesArticulo.Count > 0)
                            cargarImagen(imagenesArticulo[0].ImagenUrl);
                    }

                    if (ver)
                        SetModoSoloLectura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ver)
            {
                Close();
                return;
            }

            bool valido = true;

            errorProvider1.Clear();

            valido &= ValidadorUI.ValidarTexto(txtCodigo, 50, "Máximo 50 caracteres", errorProvider1);
            valido &= ValidadorUI.ValidarTexto(txtNombre, 50, "Máximo 50 caracteres", errorProvider1);
            valido &= ValidadorUI.ValidarTexto(txtDescripcion, 150, "Máximo 150 caracteres", errorProvider1);
            valido &= ValidadorUI.ValidarDecimal(txtPrecio, "El precio debe ser numérico", errorProvider1);


            if (!valido)
                return;
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {   
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagenes = imagenesArticulo;

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetModoSoloLectura()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            cboMarca.Enabled = false;
            cboCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            btnCancelar.Visible = false;
            txtUrlImagen.Enabled = false;
            btnBuscarImagen.Enabled = false;
            btnAgregarImagen.Enabled = false;
            btnEliminarImagen.Enabled = false;
            lstImagenes.Enabled = false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagen))
                    pbxAltaArticulo.Load(imagen);
                else
                    pbxAltaArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
            catch
            {
                pbxAltaArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Imágenes (*.jpg;*.png)|*.jpg;*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                MessageBox.Show("Ingresá o seleccioná una imagen.");
                return;
            }

            Imagen imagen = new Imagen();
            imagen.ImagenUrl = txtUrlImagen.Text;

            imagenesArticulo.Add(imagen);
            lstImagenes.Items.Add(txtUrlImagen.Text);

            cargarImagen(txtUrlImagen.Text);
            txtUrlImagen.Clear();
        }
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccioná una imagen para eliminar.");
                return;
            }

            int indice = lstImagenes.SelectedIndex;

            imagenesArticulo.RemoveAt(indice);
            lstImagenes.Items.RemoveAt(indice);

            if (lstImagenes.Items.Count > 0)
            {
                lstImagenes.SelectedIndex = 0;
                cargarImagen(lstImagenes.SelectedItem.ToString());
            }
            else
            {
                cargarImagen("");
            }
        }
        private void lstImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem != null)
                cargarImagen(lstImagenes.SelectedItem.ToString());
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidadorUI.ValidarTexto(txtCodigo, 50, "Máximo 50 caracteres", errorProvider1);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidadorUI.ValidarTexto(txtNombre, 50, "Máximo 50 caracteres", errorProvider1);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidadorUI.ValidarDecimal(txtPrecio, "El precio debe ser numérico", errorProvider1);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidadorUI.ValidarTexto(txtDescripcion, 150, "Máximo 150 caracteres", errorProvider1);
        }
    }
}
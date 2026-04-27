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
    public partial class frmAcercaDe : Form
    {
            public frmAcercaDe()
        {
            InitializeComponent();

            lblAcerca.Text = @"
            PROGRAMACIÓN III

            Profesor: Maximiliano Sar Fernández

            Ayudantes:
              • Regina Laurentino
              • Javier Agustín Larroca
              • Gonzalo Ligero

            Alumnos:
              • Cristian Sánchez
              • Aldana Firpo
              • Ulises Aguirre

            Año: 2026";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

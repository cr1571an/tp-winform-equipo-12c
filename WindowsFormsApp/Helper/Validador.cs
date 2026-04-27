using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp.Helpers
{
    public static class ValidadorUI
    {
        public static bool ValidarTexto(TextBox txt, int max, string msgMax, ErrorProvider ep)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                ep.SetError(txt, "Este campo es obligatorio");
                txt.BackColor = Color.LightCoral;
                return false;
            }

            if (txt.Text.Length > max)
            {
                ep.SetError(txt, msgMax);
                txt.BackColor = Color.LightCoral;
                return false;
            }

            ep.SetError(txt, "");
            txt.BackColor = Color.White;
            return true;
        }

        public static bool ValidarDecimal(TextBox txt, string mensaje, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider.SetError(txt, "El campo es obligatorio.");
                txt.BackColor = Color.LightCoral;
                return false;
            }

            if (!decimal.TryParse(txt.Text, out _))
            {
                errorProvider.SetError(txt, mensaje);
                txt.BackColor = Color.LightCoral;
                return false;
            }

            errorProvider.SetError(txt, "");
            txt.BackColor = Color.White;
            return true;
        }
    }
}
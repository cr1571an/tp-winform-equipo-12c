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
        public static bool ValidarMaxCaracteres(TextBox txt, int max, string mensaje, ErrorProvider ep)
        {
            if (txt == null || ep == null) return false;
            if (txt.Text.Length > max)
            {
                ep.SetError(txt, mensaje);
                txt.BackColor = Color.LightCoral;
                txt.Focus();
                return false;
            }
            ep.SetError(txt, string.Empty);
            txt.BackColor = Color.White;
            return true;
        }
    }
}
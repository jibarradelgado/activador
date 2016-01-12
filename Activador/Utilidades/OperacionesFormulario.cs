using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activador.Utilidades
{
    public class OperacionesFormulario
    {
        /// <summary>
        /// 18/10/2012
        /// Metodo que permite limpiar un control y los controles que contiene
        /// </summary>
        /// <param name="ctl"></param>
        public static void Limpiar(Control ctl)
        {

            if (ctl is TextBox)
            {
                ctl.Text = "";
            }
            if (ctl is ComboBox)
            {
                if (((ComboBox)ctl).Items.Count > 0)
                    ((ComboBox)ctl).SelectedIndex = 0;
            }
            if (ctl is PictureBox)
            {
                ((PictureBox)ctl).BackgroundImage = null;
                ((PictureBox)ctl).Image = null;
            }
            if (ctl is NumericUpDown)
            {
                ((NumericUpDown)ctl).Value = 0;
            }
            foreach (Control c in ctl.Controls)
            {
                Limpiar(c);
            }
        }

        public static string LlenaCeros(int iNumero, int iCeros)
        {
            string sNumero = iNumero.ToString();

            for (int i = sNumero.Length; i < iCeros; i++)
            {
                sNumero = "0" + sNumero;
            }

            return sNumero;
        }
    }
}

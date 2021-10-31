using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyHimnario
{
    public partial class frmRutasSeleccionadas : Form
    {
        public frmRutasSeleccionadas()
        {
            InitializeComponent();
        }


        private void listBoxRutas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxRutas.SelectedIndex >= 0)
            {
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = "explorer.exe";
                process.Arguments = String.Format("/select, \"{0}\"", this.listBoxRutas.SelectedItem.ToString());
                Process.Start(process);
            }
        }
    }
}

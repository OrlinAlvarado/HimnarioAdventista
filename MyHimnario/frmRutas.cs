using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHimnario
{
    public partial class frmRutas : Form
    {
        public frmRutas()
        {
            InitializeComponent();
        }

        private void frmRutas_Load(object sender, EventArgs e)
        {
            foreach (string ruta in Properties.Settings.Default.Rutas1962)
            {
                listBoxRutas1962.Items.Add(ruta);
            }

            foreach (string ruta in Properties.Settings.Default.Rutas2009)
            {
                listBoxRutas2009.Items.Add(ruta);
            }
        }


        private void btnAgregar1962_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog open = new FolderBrowserDialog())
            {
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!this.listBoxRutas1962.Items.Contains(open.SelectedPath))
                    {
                        this.listBoxRutas1962.Items.Add(open.SelectedPath);
                    }
                }
            }
        }

        private void btnGuardar1962_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Rutas1962.Clear();
                foreach (string item in this.listBoxRutas1962.Items)
                {

                    Properties.Settings.Default.Rutas1962.Add(item);
                }
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar2009_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog open = new FolderBrowserDialog())
            {
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!this.listBoxRutas2009.Items.Contains(open.SelectedPath))
                    {
                        this.listBoxRutas2009.Items.Add(open.SelectedPath);
                    }
                }
            }
        }

        private void btnGuardar2009_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Rutas2009.Clear();
                foreach (string item in this.listBoxRutas2009.Items)
                {

                    Properties.Settings.Default.Rutas2009.Add(item);
                }
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar1962_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBoxRutas1962.Items.RemoveAt(this.listBoxRutas1962.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxRutas1962_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRutas1962.SelectedIndex >= 0)
                this.btnEliminar1962.Enabled = true;
            else
                this.btnEliminar1962.Enabled = false;
        }

        private void listBoxRutas2009_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRutas2009.SelectedIndex >= 0)
                this.btnEliminar2009.Enabled = true;
            else
                this.btnEliminar2009.Enabled = false;
        }

        private void btnEliminar2009_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBoxRutas2009.Items.RemoveAt(this.listBoxRutas2009.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

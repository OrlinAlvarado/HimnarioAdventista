using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MyHimnario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DataTable dt1962;
        DataTable dt2009;

        private void frmMain_Load(object sender, EventArgs e)
        {
        
            dt1962 = this.GetStructure();
            dt2009 = this.GetStructure();

            DataSet dsHymns = new DataSet();

            string fileContents = GetResourceTextFile("Hymns.xml");

            //fileContents = this.CleanString(fileContents);
            dsHymns.ReadXml(new StringReader(fileContents));

            dt1962.Load(dsHymns.Tables[0].CreateDataReader());
            dt2009.Load(dsHymns.Tables[1].CreateDataReader());

            dt1962.DefaultView.Sort = "Numero ASC";
            dt2009.DefaultView.Sort = "Numero ASC";

            this.dataGridView1962.DataSource = dt1962;
            this.dataGridView1962.Columns[2].Visible = false;
            this.dataGridView2009.DataSource = dt2009;
            this.dataGridView2009.Columns[2].Visible = false;
        }

        private DataTable GetStructure()
        {
            DataTable dtBase = new DataTable();
            dtBase.Columns.Add("Numero", typeof(int));
            dtBase.Columns.Add("Nombre", typeof(string));
            dtBase.Columns.Add("Contenido", typeof(string));

            return dtBase;
        }

        private string CleanString(string text)
        {
            text = text.Replace("á", "a");
            text = text.Replace("Á", "A");
            text = text.Replace("é", "e");
            text = text.Replace("É", "E");
            text = text.Replace("í", "i");
            text = text.Replace("Í", "I");
            text = text.Replace("ó", "o");
            text = text.Replace("Ó", "O");
            text = text.Replace("ú", "u");
            text = text.Replace("Ú", "U");
            text = text.Replace("!", "");
            text = text.Replace("¡", "");
            text = text.Replace("¿", "");
            text = text.Replace("?", "");

            return text;
        }

        private DataTable GetDataTable(string[] Files1962)
        {
            DataTable dtBase = new DataTable();
            dtBase.Columns.Add("Numero", typeof(int));
            dtBase.Columns.Add("Nombre", typeof(string));
            dtBase.Columns.Add("Contenido", typeof(string));


            foreach (var file in Files1962)
            {
                DataRow row = dtBase.NewRow();

                string FileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                string[] FileNameParts = FileNameWithoutExtension.Split(new char[] { '_' });
                string[] FileContent = File.ReadAllLines(file);
                string FirstLine = FileContent[0];

                string HymnName = FirstLine.Split(new string[] { "{\"t\":\"" }, StringSplitOptions.None)[1].Split(new string[] { "\",\"x\":\"" }, StringSplitOptions.None)[0].Trim();
                string Content = FirstLine.Split(new string[] { "{\"t\":\"" }, StringSplitOptions.None)[1].Split(new string[] { "\",\"x\":\"" }, StringSplitOptions.None)[1].Trim();
                row["Numero"] = Convert.ToInt32(FileNameParts[2]);
                row["Nombre"] = HymnName;
                row["Contenido"] = Content.Replace("\"}", "").Replace("\n\n", "\n\r"); ;

                dtBase.Rows.Add(row);
            }

            dtBase.DefaultView.Sort = "Numero asc";

            return dtBase;
        }

        private void dataGridView1962_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1962.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1962.SelectedRows[0];
                this.richTextBox1962Content.Text = row.Cells[2].Value.ToString().Replace("\\n", Environment.NewLine).Replace(".", Environment.NewLine);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxSearch.Text.Trim()))
            {
                this.dt1962.DefaultView.RowFilter = "";
                this.dt2009.DefaultView.RowFilter = "";
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search();
            }
        }

        private void Search()
        {
            if (!String.IsNullOrEmpty(this.textBoxSearch.Text.Trim()))
            {
                this.dt1962.DefaultView.RowFilter = string.Format("Convert(Numero,'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%' OR Contenido LIKE '%{0}%'", this.textBoxSearch.Text);
                this.dt2009.DefaultView.RowFilter = string.Format("Convert(Numero,'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%' OR Contenido LIKE '%{0}%'", this.textBoxSearch.Text);
            }
            else
            {
                this.dt1962.DefaultView.RowFilter = "";
                this.dt2009.DefaultView.RowFilter = "";
            }
        }

        private void dataGridView2009_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2009.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2009.SelectedRows[0];
                this.richTextBox2009Content.Text = row.Cells[2].Value.ToString().Replace("\\n", Environment.NewLine).Replace(".", Environment.NewLine).Replace(":",Environment.NewLine).Replace(";",Environment.NewLine);
            }
        }

        private void dataGridView1962_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1962.Rows[e.RowIndex];

                string HymnNumber = row.Cells[0].Value.ToString();


                List<string> rutas = new List<string>();

                foreach (var ruta in Properties.Settings.Default.Rutas1962)
                {
                    string[] Files = Directory.GetFiles(ruta, HymnNumber.PadRight(4, ' ') + "*");

                    if (Files != null && Files.Length > 0)
                    {
                        rutas.AddRange(Files);
                    }
                }

                if (rutas.Count == 0)
                    return;
                else if (rutas.Count == 1)
                {
                    ProcessStartInfo process = new ProcessStartInfo();
                    process.FileName = "explorer.exe";
                    process.Arguments = String.Format("/select, \"{0}\"", rutas[0]);
                    Process.Start(process);
                }
                else
                {
                    frmRutasSeleccionadas seleccionado = new frmRutasSeleccionadas();
                    seleccionado.listBoxRutas.DataSource = rutas;
                    seleccionado.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1962_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1962.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridView2009_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2009.Rows[e.RowIndex].Selected = true;
        }

        private void rutasToolStripMenuItemRutas_Click(object sender, EventArgs e)
        {
            frmRutas frm = new frmRutas();
            frm.ShowDialog();
        }


        public string GetResourceTextFile(string filename)
        {
            string result = string.Empty;

            using (Stream stream = this.GetType().Assembly.
                       GetManifestResourceStream("MyHimnario." + filename))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;
        }

        private void dataGridView2009_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2009.Rows[e.RowIndex];

                string HymnNumber = row.Cells[0].Value.ToString();


                List<string> rutas = new List<string>();

                foreach (var ruta in Properties.Settings.Default.Rutas2009)
                {
                    string[] Files = Directory.GetFiles(ruta, HymnNumber.PadRight(4, ' ') + "*");

                    if (Files != null && Files.Length > 0)
                    {
                        rutas.AddRange(Files);
                    }
                }

                if (rutas.Count == 0)
                    return;
                else if (rutas.Count == 1)
                {
                    ProcessStartInfo process = new ProcessStartInfo();
                    process.FileName = "explorer.exe";
                    process.Arguments = String.Format("/select, \"{0}\"", rutas[0]);
                    Process.Start(process);
                }
                else
                {
                    frmRutasSeleccionadas seleccionado = new frmRutasSeleccionadas();
                    seleccionado.listBoxRutas.DataSource = rutas;
                    seleccionado.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFontUp_Click(object sender, EventArgs e)
        {
            Font font = this.richTextBox1962Content.Font;

            this.richTextBox1962Content.Font = new Font(font.FontFamily, font.Size + 5);
            this.richTextBox2009Content.Font = new Font(font.FontFamily, font.Size + 5);
            
        }

        private void btnFontDown_Click(object sender, EventArgs e)
        {
            try
            {
                Font font = this.richTextBox1962Content.Font;
                this.richTextBox1962Content.Font = new Font(font.FontFamily, font.Size - 5);
                this.richTextBox2009Content.Font = new Font(font.FontFamily, font.Size - 5);
            }
            catch (Exception)
            {
                
            }
        }
        
    }
}

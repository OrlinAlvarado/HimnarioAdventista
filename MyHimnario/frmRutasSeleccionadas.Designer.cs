namespace MyHimnario
{
    partial class frmRutasSeleccionadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutasSeleccionadas));
            this.listBoxRutas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxRutas
            // 
            this.listBoxRutas.FormattingEnabled = true;
            this.listBoxRutas.Location = new System.Drawing.Point(12, 13);
            this.listBoxRutas.Name = "listBoxRutas";
            this.listBoxRutas.Size = new System.Drawing.Size(392, 108);
            this.listBoxRutas.TabIndex = 0;
            this.listBoxRutas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRutas_MouseDoubleClick);
            // 
            // frmRutasSeleccionadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 137);
            this.Controls.Add(this.listBoxRutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRutasSeleccionadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas encontradas";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxRutas;

    }
}
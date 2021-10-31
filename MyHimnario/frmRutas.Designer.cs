namespace MyHimnario
{
    partial class frmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutas));
            this.listBoxRutas1962 = new System.Windows.Forms.ListBox();
            this.btnAgregar1962 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGuardar1962 = new System.Windows.Forms.Button();
            this.btnEliminar1962 = new System.Windows.Forms.Button();
            this.btnEliminar2009 = new System.Windows.Forms.Button();
            this.btnGuardar2009 = new System.Windows.Forms.Button();
            this.btnAgregar2009 = new System.Windows.Forms.Button();
            this.listBoxRutas2009 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRutas1962
            // 
            this.listBoxRutas1962.FormattingEnabled = true;
            this.listBoxRutas1962.Location = new System.Drawing.Point(12, 38);
            this.listBoxRutas1962.Name = "listBoxRutas1962";
            this.listBoxRutas1962.Size = new System.Drawing.Size(237, 199);
            this.listBoxRutas1962.TabIndex = 0;
            this.listBoxRutas1962.SelectedIndexChanged += new System.EventHandler(this.listBoxRutas1962_SelectedIndexChanged);
            // 
            // btnAgregar1962
            // 
            this.btnAgregar1962.Location = new System.Drawing.Point(12, 243);
            this.btnAgregar1962.Name = "btnAgregar1962";
            this.btnAgregar1962.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar1962.TabIndex = 1;
            this.btnAgregar1962.Text = "Agregar";
            this.btnAgregar1962.UseVisualStyleBackColor = true;
            this.btnAgregar1962.Click += new System.EventHandler(this.btnAgregar1962_Click);
            // 
            // btnGuardar1962
            // 
            this.btnGuardar1962.Location = new System.Drawing.Point(93, 243);
            this.btnGuardar1962.Name = "btnGuardar1962";
            this.btnGuardar1962.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1962.TabIndex = 2;
            this.btnGuardar1962.Text = "Guardar";
            this.btnGuardar1962.UseVisualStyleBackColor = true;
            this.btnGuardar1962.Click += new System.EventHandler(this.btnGuardar1962_Click);
            // 
            // btnEliminar1962
            // 
            this.btnEliminar1962.Enabled = false;
            this.btnEliminar1962.Location = new System.Drawing.Point(174, 243);
            this.btnEliminar1962.Name = "btnEliminar1962";
            this.btnEliminar1962.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar1962.TabIndex = 3;
            this.btnEliminar1962.Text = "Eliminar";
            this.btnEliminar1962.UseVisualStyleBackColor = true;
            this.btnEliminar1962.Click += new System.EventHandler(this.btnEliminar1962_Click);
            // 
            // btnEliminar2009
            // 
            this.btnEliminar2009.Enabled = false;
            this.btnEliminar2009.Location = new System.Drawing.Point(429, 243);
            this.btnEliminar2009.Name = "btnEliminar2009";
            this.btnEliminar2009.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar2009.TabIndex = 7;
            this.btnEliminar2009.Text = "Eliminar";
            this.btnEliminar2009.UseVisualStyleBackColor = true;
            this.btnEliminar2009.Click += new System.EventHandler(this.btnEliminar2009_Click);
            // 
            // btnGuardar2009
            // 
            this.btnGuardar2009.Location = new System.Drawing.Point(348, 243);
            this.btnGuardar2009.Name = "btnGuardar2009";
            this.btnGuardar2009.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar2009.TabIndex = 6;
            this.btnGuardar2009.Text = "Guardar";
            this.btnGuardar2009.UseVisualStyleBackColor = true;
            this.btnGuardar2009.Click += new System.EventHandler(this.btnGuardar2009_Click);
            // 
            // btnAgregar2009
            // 
            this.btnAgregar2009.Location = new System.Drawing.Point(267, 243);
            this.btnAgregar2009.Name = "btnAgregar2009";
            this.btnAgregar2009.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar2009.TabIndex = 5;
            this.btnAgregar2009.Text = "Agregar";
            this.btnAgregar2009.UseVisualStyleBackColor = true;
            this.btnAgregar2009.Click += new System.EventHandler(this.btnAgregar2009_Click);
            // 
            // listBoxRutas2009
            // 
            this.listBoxRutas2009.FormattingEnabled = true;
            this.listBoxRutas2009.Location = new System.Drawing.Point(267, 38);
            this.listBoxRutas2009.Name = "listBoxRutas2009";
            this.listBoxRutas2009.Size = new System.Drawing.Size(237, 199);
            this.listBoxRutas2009.TabIndex = 4;
            this.listBoxRutas2009.SelectedIndexChanged += new System.EventHandler(this.listBoxRutas2009_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Carpetas himnario antiguo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carpetas himnario nuevo";
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar2009);
            this.Controls.Add(this.btnGuardar2009);
            this.Controls.Add(this.btnAgregar2009);
            this.Controls.Add(this.listBoxRutas2009);
            this.Controls.Add(this.btnEliminar1962);
            this.Controls.Add(this.btnGuardar1962);
            this.Controls.Add(this.btnAgregar1962);
            this.Controls.Add(this.listBoxRutas1962);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRutas1962;
        private System.Windows.Forms.Button btnAgregar1962;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnGuardar1962;
        private System.Windows.Forms.Button btnEliminar1962;
        private System.Windows.Forms.Button btnEliminar2009;
        private System.Windows.Forms.Button btnGuardar2009;
        private System.Windows.Forms.Button btnAgregar2009;
        private System.Windows.Forms.ListBox listBoxRutas2009;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
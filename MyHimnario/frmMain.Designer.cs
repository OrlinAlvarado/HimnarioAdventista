namespace MyHimnario
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1962 = new System.Windows.Forms.DataGridView();
            this.richTextBox1962Content = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2009 = new System.Windows.Forms.DataGridView();
            this.richTextBox2009Content = new System.Windows.Forms.RichTextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rutasToolStripMenuItemRutas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFontUp = new System.Windows.Forms.Button();
            this.btnFontDown = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1962)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2009)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 93);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 444);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1085, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Antiguo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1962);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1962Content);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 399);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridView1962
            // 
            this.dataGridView1962.AllowUserToAddRows = false;
            this.dataGridView1962.AllowUserToDeleteRows = false;
            this.dataGridView1962.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1962.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1962.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1962.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1962.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1962.Name = "dataGridView1962";
            this.dataGridView1962.ReadOnly = true;
            this.dataGridView1962.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1962.Size = new System.Drawing.Size(358, 399);
            this.dataGridView1962.TabIndex = 0;
            this.dataGridView1962.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1962_CellClick);
            this.dataGridView1962.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1962_RowHeaderMouseDoubleClick);
            this.dataGridView1962.SelectionChanged += new System.EventHandler(this.dataGridView1962_SelectionChanged);
            // 
            // richTextBox1962Content
            // 
            this.richTextBox1962Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1962Content.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1962Content.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1962Content.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1962Content.Name = "richTextBox1962Content";
            this.richTextBox1962Content.Size = new System.Drawing.Size(710, 399);
            this.richTextBox1962Content.TabIndex = 3;
            this.richTextBox1962Content.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1085, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(5, 5);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2009);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox2009Content);
            this.splitContainer2.Size = new System.Drawing.Size(1075, 399);
            this.splitContainer2.SplitterDistance = 358;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridView2009
            // 
            this.dataGridView2009.AllowUserToAddRows = false;
            this.dataGridView2009.AllowUserToDeleteRows = false;
            this.dataGridView2009.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2009.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2009.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2009.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2009.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2009.Name = "dataGridView2009";
            this.dataGridView2009.ReadOnly = true;
            this.dataGridView2009.Size = new System.Drawing.Size(358, 399);
            this.dataGridView2009.TabIndex = 1;
            this.dataGridView2009.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2009_CellClick);
            this.dataGridView2009.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2009_RowHeaderMouseClick);
            this.dataGridView2009.SelectionChanged += new System.EventHandler(this.dataGridView2009_SelectionChanged);
            // 
            // richTextBox2009Content
            // 
            this.richTextBox2009Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2009Content.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2009Content.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2009Content.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox2009Content.Name = "richTextBox2009Content";
            this.richTextBox2009Content.Size = new System.Drawing.Size(710, 399);
            this.richTextBox2009Content.TabIndex = 4;
            this.richTextBox2009Content.Text = "";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(114, 26);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(547, 29);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1139, 27);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(196, 22);
            this.toolStripStatusLabel1.Text = "Creado por: Orlin Alvarado";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutasToolStripMenuItemRutas});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(88, 25);
            this.toolStripDropDownButton1.Text = "Opciones";
            // 
            // rutasToolStripMenuItemRutas
            // 
            this.rutasToolStripMenuItemRutas.Name = "rutasToolStripMenuItemRutas";
            this.rutasToolStripMenuItemRutas.Size = new System.Drawing.Size(119, 26);
            this.rutasToolStripMenuItemRutas.Text = "Rutas";
            this.rutasToolStripMenuItemRutas.Click += new System.EventHandler(this.rutasToolStripMenuItemRutas_Click);
            // 
            // btnFontUp
            // 
            this.btnFontUp.Location = new System.Drawing.Point(397, 77);
            this.btnFontUp.Name = "btnFontUp";
            this.btnFontUp.Size = new System.Drawing.Size(60, 39);
            this.btnFontUp.TabIndex = 5;
            this.btnFontUp.Text = "A˄";
            this.btnFontUp.UseVisualStyleBackColor = true;
            this.btnFontUp.Click += new System.EventHandler(this.btnFontUp_Click);
            // 
            // btnFontDown
            // 
            this.btnFontDown.Location = new System.Drawing.Point(463, 77);
            this.btnFontDown.Name = "btnFontDown";
            this.btnFontDown.Size = new System.Drawing.Size(60, 39);
            this.btnFontDown.TabIndex = 6;
            this.btnFontDown.Text = "A˅";
            this.btnFontDown.UseVisualStyleBackColor = true;
            this.btnFontDown.Click += new System.EventHandler(this.btnFontDown_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 579);
            this.Controls.Add(this.btnFontDown);
            this.Controls.Add(this.btnFontUp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Buscador de himnos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1962)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2009)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1962;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2009;
        private System.Windows.Forms.RichTextBox richTextBox1962Content;
        private System.Windows.Forms.RichTextBox richTextBox2009Content;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItemRutas;
        private System.Windows.Forms.Button btnFontUp;
        private System.Windows.Forms.Button btnFontDown;
    }
}


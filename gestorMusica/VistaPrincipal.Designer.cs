
namespace ProyectoDintNuno
{
    partial class VistaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcVistaPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpConjunto = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSecArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tcVistaPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnadir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.Location = new System.Drawing.Point(961, 487);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 42);
            this.btnAnadir.TabIndex = 3;
            this.btnAnadir.Text = "Nuevo";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(883, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcVistaPrincipal
            // 
            this.tcVistaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcVistaPrincipal.Controls.Add(this.tabPage1);
            this.tcVistaPrincipal.Controls.Add(this.tabPage2);
            this.tcVistaPrincipal.Location = new System.Drawing.Point(0, 27);
            this.tcVistaPrincipal.Name = "tcVistaPrincipal";
            this.tcVistaPrincipal.SelectedIndex = 0;
            this.tcVistaPrincipal.Size = new System.Drawing.Size(1036, 457);
            this.tcVistaPrincipal.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpConjunto);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 429);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpConjunto
            // 
            this.flpConjunto.AutoScroll = true;
            this.flpConjunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpConjunto.Location = new System.Drawing.Point(3, 3);
            this.flpConjunto.Name = "flpConjunto";
            this.flpConjunto.Size = new System.Drawing.Size(1022, 423);
            this.flpConjunto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPrincipal);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 429);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.cImage,
            this.cName,
            this.cArtist,
            this.cSecArtist,
            this.cGenre,
            this.cFormat,
            this.cType,
            this.cAdDate,
            this.cEdDate,
            this.cDescription});
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(3, 3);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowTemplate.Height = 50;
            this.dgvPrincipal.Size = new System.Drawing.Size(1022, 423);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // cImage
            // 
            this.cImage.HeaderText = "Image";
            this.cImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cImage.Name = "cImage";
            this.cImage.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cArtist
            // 
            this.cArtist.HeaderText = "Artist";
            this.cArtist.Name = "cArtist";
            this.cArtist.ReadOnly = true;
            // 
            // cSecArtist
            // 
            this.cSecArtist.HeaderText = "Secondary Artist";
            this.cSecArtist.Name = "cSecArtist";
            this.cSecArtist.ReadOnly = true;
            // 
            // cGenre
            // 
            this.cGenre.HeaderText = "Genre";
            this.cGenre.Name = "cGenre";
            this.cGenre.ReadOnly = true;
            // 
            // cFormat
            // 
            this.cFormat.HeaderText = "Format";
            this.cFormat.Name = "cFormat";
            this.cFormat.ReadOnly = true;
            this.cFormat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cFormat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cType
            // 
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            this.cType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cAdDate
            // 
            this.cAdDate.HeaderText = "Adquisition Date";
            this.cAdDate.Name = "cAdDate";
            this.cAdDate.ReadOnly = true;
            // 
            // cEdDate
            // 
            this.cEdDate.HeaderText = "Edition Date";
            this.cEdDate.Name = "cEdDate";
            this.cEdDate.ReadOnly = true;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.tcVistaPrincipal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaPrincipal";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcVistaPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tcVistaPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpConjunto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewImageColumn cImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSecArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
    }
}


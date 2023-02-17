
namespace ProyectoDintNuno
{
    partial class VistaAnadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAnadir));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnExplore = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbSecArtist = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtpAdquisition = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dtpEdition = new System.Windows.Forms.DateTimePicker();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblAdquisition = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSArtist = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(13, 38);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(252, 281);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblImage.ForeColor = System.Drawing.SystemColors.Window;
            this.lblImage.Location = new System.Drawing.Point(13, 9);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(62, 25);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Image";
            // 
            // btnExplore
            // 
            this.btnExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btnExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExplore.Location = new System.Drawing.Point(138, 8);
            this.btnExplore.Margin = new System.Windows.Forms.Padding(4);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(89, 26);
            this.btnExplore.TabIndex = 10;
            this.btnExplore.Text = "explore";
            this.btnExplore.UseVisualStyleBackColor = false;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbName.Location = new System.Drawing.Point(282, 38);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 30);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "";
            // 
            // tbArtist
            // 
            this.tbArtist.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbArtist.Location = new System.Drawing.Point(283, 99);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(228, 30);
            this.tbArtist.TabIndex = 2;
            this.tbArtist.Tag = "";
            // 
            // tbSecArtist
            // 
            this.tbSecArtist.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbSecArtist.Location = new System.Drawing.Point(282, 162);
            this.tbSecArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecArtist.Name = "tbSecArtist";
            this.tbSecArtist.Size = new System.Drawing.Size(228, 30);
            this.tbSecArtist.TabIndex = 3;
            this.tbSecArtist.Tag = "";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbDescription.Location = new System.Drawing.Point(518, 225);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(228, 94);
            this.tbDescription.TabIndex = 9;
            this.tbDescription.Tag = "";
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.ItemHeight = 23;
            this.cbFormat.Items.AddRange(new object[] {
            "CD",
            "Vinilo",
            "Cassette"});
            this.cbFormat.Location = new System.Drawing.Point(283, 288);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(228, 31);
            this.cbFormat.TabIndex = 12;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Album",
            "Single",
            "LP",
            "EP",
            "Maxi",
            "Mini LP",
            "Boxset",
            "Doble LP",
            "Doble CD"});
            this.cbType.Location = new System.Drawing.Point(518, 38);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(228, 31);
            this.cbType.TabIndex = 13;
            // 
            // dtpAdquisition
            // 
            this.dtpAdquisition.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.dtpAdquisition.Location = new System.Drawing.Point(518, 98);
            this.dtpAdquisition.Name = "dtpAdquisition";
            this.dtpAdquisition.Size = new System.Drawing.Size(228, 30);
            this.dtpAdquisition.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnCancel.Location = new System.Drawing.Point(633, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnAccept.Location = new System.Drawing.Point(518, 336);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(110, 34);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Add";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dtpEdition
            // 
            this.dtpEdition.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.dtpEdition.Location = new System.Drawing.Point(518, 159);
            this.dtpEdition.Name = "dtpEdition";
            this.dtpEdition.Size = new System.Drawing.Size(228, 30);
            this.dtpEdition.TabIndex = 8;
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbGenre.Location = new System.Drawing.Point(283, 225);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(228, 30);
            this.tbGenre.TabIndex = 4;
            this.tbGenre.Tag = "";
            // 
            // lblAdquisition
            // 
            this.lblAdquisition.AutoSize = true;
            this.lblAdquisition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAdquisition.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdquisition.Location = new System.Drawing.Point(518, 70);
            this.lblAdquisition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdquisition.Name = "lblAdquisition";
            this.lblAdquisition.Size = new System.Drawing.Size(143, 25);
            this.lblAdquisition.TabIndex = 19;
            this.lblAdquisition.Text = "Adquisition date";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblEdition.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEdition.Location = new System.Drawing.Point(518, 131);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(109, 25);
            this.lblEdition.TabIndex = 20;
            this.lblEdition.Text = "Edition Date";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblFormat.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFormat.Location = new System.Drawing.Point(283, 259);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(69, 25);
            this.lblFormat.TabIndex = 21;
            this.lblFormat.Text = "Format";
            this.lblFormat.Click += new System.EventHandler(this.lblFormat_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblType.Location = new System.Drawing.Point(518, 9);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 25);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(283, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 25);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name *";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblArtist.ForeColor = System.Drawing.SystemColors.Window;
            this.lblArtist.Location = new System.Drawing.Point(283, 72);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(67, 25);
            this.lblArtist.TabIndex = 24;
            this.lblArtist.Text = "Artist *";
            // 
            // lblSArtist
            // 
            this.lblSArtist.AutoSize = true;
            this.lblSArtist.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSArtist.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSArtist.Location = new System.Drawing.Point(283, 133);
            this.lblSArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSArtist.Name = "lblSArtist";
            this.lblSArtist.Size = new System.Drawing.Size(139, 25);
            this.lblSArtist.TabIndex = 25;
            this.lblSArtist.Text = "Secondary artist";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescription.Location = new System.Drawing.Point(517, 196);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblGenre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblGenre.Location = new System.Drawing.Point(283, 196);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(58, 25);
            this.lblGenre.TabIndex = 27;
            this.lblGenre.Text = "Genre";
            // 
            // VistaAnadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(757, 384);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblAdquisition);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.dtpEdition);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpAdquisition);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbSecArtist);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaAnadir";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbSecArtist;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpAdquisition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DateTimePicker dtpEdition;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lblAdquisition;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSArtist;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenre;
    }
}
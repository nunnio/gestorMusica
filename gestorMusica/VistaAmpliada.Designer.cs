
namespace gestorMusica
{
    partial class VistaAmpliada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAmpliada));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblArtistaSec = new System.Windows.Forms.Label();
            this.lblTGenre = new System.Windows.Forms.Label();
            this.lblTFormat = new System.Windows.Forms.Label();
            this.lblTType = new System.Windows.Forms.Label();
            this.lblTAdDate = new System.Windows.Forms.Label();
            this.lblTEdDate = new System.Windows.Forms.Label();
            this.lblTDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbSArtist = new System.Windows.Forms.TextBox();
            this.tbPArtist = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtpAdDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEdDate = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(17, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(279, 304);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblArtistaSec
            // 
            this.lblArtistaSec.AutoSize = true;
            this.lblArtistaSec.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblArtistaSec.ForeColor = System.Drawing.SystemColors.Window;
            this.lblArtistaSec.Location = new System.Drawing.Point(302, 42);
            this.lblArtistaSec.Name = "lblArtistaSec";
            this.lblArtistaSec.Size = new System.Drawing.Size(139, 25);
            this.lblArtistaSec.TabIndex = 3;
            this.lblArtistaSec.Text = "Secondary artist";
            // 
            // lblTGenre
            // 
            this.lblTGenre.AutoSize = true;
            this.lblTGenre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTGenre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTGenre.Location = new System.Drawing.Point(302, 94);
            this.lblTGenre.Name = "lblTGenre";
            this.lblTGenre.Size = new System.Drawing.Size(58, 25);
            this.lblTGenre.TabIndex = 5;
            this.lblTGenre.Text = "Genre";
            // 
            // lblTFormat
            // 
            this.lblTFormat.AutoSize = true;
            this.lblTFormat.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTFormat.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTFormat.Location = new System.Drawing.Point(302, 146);
            this.lblTFormat.Name = "lblTFormat";
            this.lblTFormat.Size = new System.Drawing.Size(69, 25);
            this.lblTFormat.TabIndex = 6;
            this.lblTFormat.Text = "Format";
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTType.Location = new System.Drawing.Point(472, 42);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(49, 25);
            this.lblTType.TabIndex = 7;
            this.lblTType.Text = "Type";
            // 
            // lblTAdDate
            // 
            this.lblTAdDate.AutoSize = true;
            this.lblTAdDate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTAdDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTAdDate.Location = new System.Drawing.Point(472, 94);
            this.lblTAdDate.Name = "lblTAdDate";
            this.lblTAdDate.Size = new System.Drawing.Size(143, 25);
            this.lblTAdDate.TabIndex = 8;
            this.lblTAdDate.Text = "Adquisition date";
            // 
            // lblTEdDate
            // 
            this.lblTEdDate.AutoSize = true;
            this.lblTEdDate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTEdDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTEdDate.Location = new System.Drawing.Point(472, 146);
            this.lblTEdDate.Name = "lblTEdDate";
            this.lblTEdDate.Size = new System.Drawing.Size(107, 25);
            this.lblTEdDate.TabIndex = 9;
            this.lblTEdDate.Text = "Edition date";
            // 
            // lblTDescription
            // 
            this.lblTDescription.AutoSize = true;
            this.lblTDescription.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTDescription.Location = new System.Drawing.Point(302, 198);
            this.lblTDescription.Name = "lblTDescription";
            this.lblTDescription.Size = new System.Drawing.Size(102, 25);
            this.lblTDescription.TabIndex = 10;
            this.lblTDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Enabled = false;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(302, 223);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(371, 122);
            this.tbDescription.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(582, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 41);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // tbGenre
            // 
            this.tbGenre.Enabled = false;
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(302, 119);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(164, 24);
            this.tbGenre.TabIndex = 4;
            // 
            // tbSArtist
            // 
            this.tbSArtist.Enabled = false;
            this.tbSArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSArtist.Location = new System.Drawing.Point(302, 67);
            this.tbSArtist.Name = "tbSArtist";
            this.tbSArtist.Size = new System.Drawing.Size(164, 24);
            this.tbSArtist.TabIndex = 3;
            // 
            // tbPArtist
            // 
            this.tbPArtist.Enabled = false;
            this.tbPArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPArtist.Location = new System.Drawing.Point(17, 351);
            this.tbPArtist.Name = "tbPArtist";
            this.tbPArtist.Size = new System.Drawing.Size(279, 30);
            this.tbPArtist.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(17, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 35);
            this.tbName.TabIndex = 1;
            // 
            // cbFormat
            // 
            this.cbFormat.Enabled = false;
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.ItemHeight = 18;
            this.cbFormat.Location = new System.Drawing.Point(302, 169);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(164, 26);
            this.cbFormat.TabIndex = 26;
            // 
            // cbType
            // 
            this.cbType.Enabled = false;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 18;
            this.cbType.Location = new System.Drawing.Point(472, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(202, 26);
            this.cbType.TabIndex = 27;
            // 
            // dtpAdDate
            // 
            this.dtpAdDate.Enabled = false;
            this.dtpAdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdDate.Location = new System.Drawing.Point(472, 119);
            this.dtpAdDate.Name = "dtpAdDate";
            this.dtpAdDate.Size = new System.Drawing.Size(202, 24);
            this.dtpAdDate.TabIndex = 7;
            // 
            // dtpEdDate
            // 
            this.dtpEdDate.Enabled = false;
            this.dtpEdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEdDate.Location = new System.Drawing.Point(472, 171);
            this.dtpEdDate.Name = "dtpEdDate";
            this.dtpEdDate.Size = new System.Drawing.Size(202, 24);
            this.dtpEdDate.TabIndex = 8;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(484, 351);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(92, 41);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(386, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VistaAmpliada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(686, 404);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dtpEdDate);
            this.Controls.Add(this.dtpAdDate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPArtist);
            this.Controls.Add(this.tbSArtist);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblTDescription);
            this.Controls.Add(this.lblTEdDate);
            this.Controls.Add(this.lblTAdDate);
            this.Controls.Add(this.lblTType);
            this.Controls.Add(this.lblTFormat);
            this.Controls.Add(this.lblTGenre);
            this.Controls.Add(this.lblArtistaSec);
            this.Controls.Add(this.pbImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaAmpliada";
            this.Text = "Detail";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblArtistaSec;
        private System.Windows.Forms.Label lblTGenre;
        private System.Windows.Forms.Label lblTFormat;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.Label lblTAdDate;
        private System.Windows.Forms.Label lblTEdDate;
        private System.Windows.Forms.Label lblTDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbSArtist;
        private System.Windows.Forms.TextBox tbPArtist;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpAdDate;
        private System.Windows.Forms.DateTimePicker dtpEdDate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}
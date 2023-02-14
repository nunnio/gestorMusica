
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblArtistaSec = new System.Windows.Forms.Label();
            this.lblTGenre = new System.Windows.Forms.Label();
            this.lblTFormat = new System.Windows.Forms.Label();
            this.lblTType = new System.Windows.Forms.Label();
            this.lblTAdDate = new System.Windows.Forms.Label();
            this.lblTEdDate = new System.Windows.Forms.Label();
            this.lblTDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbSArtist = new System.Windows.Forms.TextBox();
            this.tbPArtist = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtpAdDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEdDate = new System.Windows.Forms.DateTimePicker();
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
            this.lblArtistaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaSec.Location = new System.Drawing.Point(302, 42);
            this.lblArtistaSec.Name = "lblArtistaSec";
            this.lblArtistaSec.Size = new System.Drawing.Size(140, 22);
            this.lblArtistaSec.TabIndex = 3;
            this.lblArtistaSec.Text = "Secondary artist";
            // 
            // lblTGenre
            // 
            this.lblTGenre.AutoSize = true;
            this.lblTGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGenre.Location = new System.Drawing.Point(302, 94);
            this.lblTGenre.Name = "lblTGenre";
            this.lblTGenre.Size = new System.Drawing.Size(60, 22);
            this.lblTGenre.TabIndex = 5;
            this.lblTGenre.Text = "Genre";
            // 
            // lblTFormat
            // 
            this.lblTFormat.AutoSize = true;
            this.lblTFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFormat.Location = new System.Drawing.Point(302, 146);
            this.lblTFormat.Name = "lblTFormat";
            this.lblTFormat.Size = new System.Drawing.Size(66, 22);
            this.lblTFormat.TabIndex = 6;
            this.lblTFormat.Text = "Format";
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(472, 42);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(51, 22);
            this.lblTType.TabIndex = 7;
            this.lblTType.Text = "Type";
            // 
            // lblTAdDate
            // 
            this.lblTAdDate.AutoSize = true;
            this.lblTAdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAdDate.Location = new System.Drawing.Point(472, 94);
            this.lblTAdDate.Name = "lblTAdDate";
            this.lblTAdDate.Size = new System.Drawing.Size(138, 22);
            this.lblTAdDate.TabIndex = 8;
            this.lblTAdDate.Text = "Adquisition date";
            // 
            // lblTEdDate
            // 
            this.lblTEdDate.AutoSize = true;
            this.lblTEdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEdDate.Location = new System.Drawing.Point(472, 146);
            this.lblTEdDate.Name = "lblTEdDate";
            this.lblTEdDate.Size = new System.Drawing.Size(105, 22);
            this.lblTEdDate.TabIndex = 9;
            this.lblTEdDate.Text = "Edition date";
            // 
            // lblTDescription
            // 
            this.lblTDescription.AutoSize = true;
            this.lblTDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDescription.Location = new System.Drawing.Point(302, 198);
            this.lblTDescription.Name = "lblTDescription";
            this.lblTDescription.Size = new System.Drawing.Size(100, 22);
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
            this.tbDescription.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(582, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbGenre
            // 
            this.tbGenre.Enabled = false;
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(302, 119);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(164, 24);
            this.tbGenre.TabIndex = 18;
            // 
            // tbSArtist
            // 
            this.tbSArtist.Enabled = false;
            this.tbSArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSArtist.Location = new System.Drawing.Point(302, 67);
            this.tbSArtist.Name = "tbSArtist";
            this.tbSArtist.Size = new System.Drawing.Size(164, 24);
            this.tbSArtist.TabIndex = 23;
            // 
            // tbPArtist
            // 
            this.tbPArtist.Enabled = false;
            this.tbPArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPArtist.Location = new System.Drawing.Point(17, 351);
            this.tbPArtist.Name = "tbPArtist";
            this.tbPArtist.Size = new System.Drawing.Size(279, 30);
            this.tbPArtist.TabIndex = 24;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(17, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 35);
            this.tbName.TabIndex = 25;
            // 
            // cbFormat
            // 
            this.cbFormat.Enabled = false;
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
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
            this.dtpAdDate.TabIndex = 28;
            // 
            // dtpEdDate
            // 
            this.dtpEdDate.Enabled = false;
            this.dtpEdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEdDate.Location = new System.Drawing.Point(472, 171);
            this.dtpEdDate.Name = "dtpEdDate";
            this.dtpEdDate.Size = new System.Drawing.Size(202, 24);
            this.dtpEdDate.TabIndex = 29;
            // 
            // VistaAmpliada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 404);
            this.Controls.Add(this.dtpEdDate);
            this.Controls.Add(this.dtpAdDate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPArtist);
            this.Controls.Add(this.tbSArtist);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblTDescription);
            this.Controls.Add(this.lblTEdDate);
            this.Controls.Add(this.lblTAdDate);
            this.Controls.Add(this.lblTType);
            this.Controls.Add(this.lblTFormat);
            this.Controls.Add(this.lblTGenre);
            this.Controls.Add(this.lblArtistaSec);
            this.Controls.Add(this.pbImage);
            this.Name = "VistaAmpliada";
            this.Text = "Form3";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbSArtist;
        private System.Windows.Forms.TextBox tbPArtist;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpAdDate;
        private System.Windows.Forms.DateTimePicker dtpEdDate;
    }
}
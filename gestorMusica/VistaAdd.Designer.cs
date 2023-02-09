
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(13, 38);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(214, 272);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblImage.Location = new System.Drawing.Point(13, 9);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(62, 25);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Image";
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblCabecera.Location = new System.Drawing.Point(240, 6);
            this.lblCabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(126, 28);
            this.lblCabecera.TabIndex = 2;
            this.lblCabecera.Text = "New element";
            // 
            // btnExplore
            // 
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExplore.Location = new System.Drawing.Point(138, 8);
            this.btnExplore.Margin = new System.Windows.Forms.Padding(4);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(89, 26);
            this.btnExplore.TabIndex = 7;
            this.btnExplore.Text = "explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbName.Location = new System.Drawing.Point(240, 38);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 30);
            this.tbName.TabIndex = 8;
            this.tbName.Tag = "";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbArtist
            // 
            this.tbArtist.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbArtist.Location = new System.Drawing.Point(240, 76);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(228, 30);
            this.tbArtist.TabIndex = 9;
            this.tbArtist.Tag = "";
            this.tbArtist.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            // 
            // tbSecArtist
            // 
            this.tbSecArtist.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbSecArtist.Location = new System.Drawing.Point(240, 114);
            this.tbSecArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecArtist.Name = "tbSecArtist";
            this.tbSecArtist.Size = new System.Drawing.Size(228, 30);
            this.tbSecArtist.TabIndex = 10;
            this.tbSecArtist.Tag = "";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbDescription.Location = new System.Drawing.Point(474, 151);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(228, 115);
            this.tbDescription.TabIndex = 11;
            this.tbDescription.Tag = "";
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "CD",
            "Vinilo",
            "Cassette"});
            this.cbFormat.Location = new System.Drawing.Point(240, 215);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(228, 31);
            this.cbFormat.TabIndex = 12;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.cbType.FormattingEnabled = true;
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
            this.cbType.Location = new System.Drawing.Point(240, 279);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(228, 31);
            this.cbType.TabIndex = 13;
            // 
            // dtpAdquisition
            // 
            this.dtpAdquisition.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.dtpAdquisition.Location = new System.Drawing.Point(474, 39);
            this.dtpAdquisition.Name = "dtpAdquisition";
            this.dtpAdquisition.Size = new System.Drawing.Size(228, 30);
            this.dtpAdquisition.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnCancel.Location = new System.Drawing.Point(590, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.btnAccept.Location = new System.Drawing.Point(474, 279);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(110, 34);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Add";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dtpEdition
            // 
            this.dtpEdition.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.dtpEdition.Location = new System.Drawing.Point(474, 114);
            this.dtpEdition.Name = "dtpEdition";
            this.dtpEdition.Size = new System.Drawing.Size(228, 30);
            this.dtpEdition.TabIndex = 17;
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.tbGenre.Location = new System.Drawing.Point(240, 152);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(228, 30);
            this.tbGenre.TabIndex = 18;
            this.tbGenre.Tag = "";
            // 
            // lblAdquisition
            // 
            this.lblAdquisition.AutoSize = true;
            this.lblAdquisition.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAdquisition.Location = new System.Drawing.Point(474, 11);
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
            this.lblEdition.Location = new System.Drawing.Point(474, 79);
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
            this.lblFormat.Location = new System.Drawing.Point(240, 186);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(69, 25);
            this.lblFormat.TabIndex = 21;
            this.lblFormat.Text = "Format";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblType.Location = new System.Drawing.Point(240, 250);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 25);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Type";
            // 
            // VistaAnadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(712, 321);
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
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaAnadir";
            this.Text = "VistaAnadir";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblCabecera;
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
    }
}
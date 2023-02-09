using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProyectoDintNuno
{
    public partial class VistaAnadir : Form
    {
        public string Name;
        public string PArtist;
        public string SArtist;
        public string Genre;
        public string Format;
        public string Type;
        public DateTime AdDate;
        public DateTime EdDate;
        public string Description;

        public string pathInic;
        public Image Image { get; set; }

        public VistaAnadir()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            PArtist = tbArtist.Text;
            SArtist = tbSecArtist.Text;
            Genre = tbGenre.Text;
            Format = cbFormat.Text;
            Type = cbType.Text;
            AdDate = dtpAdquisition.Value;
            EdDate = dtpEdition.Value;
            Description = tbDescription.Text;
            Image = pbImage.Image;
            bool valido;
            
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(PArtist))
            {
                valido = false;
            }
            else
            {
                valido = true;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Png Image|*.png";
            saveFileDialog.FileName = Name + "Image";

            if (valido)
            {
                DialogResult = DialogResult.OK;
                /*using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    string pathFin = "@./imagenes";
                    try
                    {
                        File.Copy(pathInic, pathFin, true);
                        MessageBox.Show("La imagen se ha guardado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar guardar la imagen. " + ex.Message);
                    }
                */
            }
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    Image = Image.FromFile(of.FileName);
                    pbImage.Image = Image;
                    pathInic = Path.GetFullPath(of.FileName);
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name))
            {
                tbName.BackColor = Color.Red;
            }
            else
            {
                tbName.BackColor = Color.White;
            }
        }

        private void tbArtist_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PArtist))
            {
                tbArtist.BackColor = Color.Red;
            }
            else
            {
                tbArtist.BackColor = Color.White;
            }
        }
    }
}
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
            //Name = tbpName.Text;
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

            if (String.IsNullOrEmpty(PArtist))
            {
                tbArtist.BackColor = Color.Red;
            }
            else
            {
                tbArtist.BackColor = Color.White;
            }

            if (String.IsNullOrEmpty(Name))
            {
                tbName.BackColor = Color.Red;   
            }
            else
            {
                tbName.BackColor = Color.White;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Png Image|*.png";
            saveFileDialog.FileName = Name + "Image";

            if (!String.IsNullOrEmpty(PArtist) && !String.IsNullOrEmpty(Name))
            {
                DialogResult = DialogResult.OK;                
            }
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                if (of.CheckFileExists)
                {
                    try
                    {
                        Image = Image.FromFile(of.FileName);
                        pbImage.Image = Image;
                        pathInic = Path.GetFullPath(of.FileName);
                    }
                    catch(OutOfMemoryException ex)
                    {
                        MessageBox.Show("Error en la elección de Imagen\n" + ex.Message);
                    }
                    
                }
            }
        }

        private void textBoxPersonalizado1_Click(object sender, EventArgs e)
        {

        }

        private void lblFormat_Click(object sender, EventArgs e)
        {

        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
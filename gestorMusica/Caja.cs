using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorMusica
{
    public partial class Caja : Control
    {
        
        private PictureBox pb;
        private Label lblName;
        private Label lblArtist;
        private int id;

        public Caja()
        {
            // Configura el control personalizado
            this.Size = new Size(185, 300);

            // Configura el FlowLayoutPanel
            /*flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.Size = new Size(185, 300);*/

            // Añado el PictureBox
            pb = new PictureBox();
            pb.Size = new Size(180, 180);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Dock = DockStyle.Bottom;
            this.Controls.Add(pb);

            // Añado el Nombre
            lblName = new Label();
            //lblName.AutoSize = false;
            lblName.Font = new Font("Segoe UI", 16);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Size = new Size(180, 30);
            lblName.ForeColor = Color.White;
            lblName.Text = Name;
            lblName.Dock = DockStyle.Bottom;
            //lblName.Margin = new Padding(2, 0, 0, 0);
            this.Controls.Add(lblName);

            // Añado el Artista
            lblArtist = new Label();
            //lblArtist.AutoSize = false;
            lblArtist.Font = new Font("Segoe UI", 13);
            lblArtist.TextAlign = ContentAlignment.MiddleCenter;
            lblArtist.Size = new Size(180, 25);
            lblArtist.ForeColor = Color.White;
            lblArtist.Text = Artist;
            lblArtist.Dock = DockStyle.Bottom;
            //lblArtist.Margin = new Padding(2, 5, 0, 0);
            this.Controls.Add(lblArtist);

            pb.Click += caja_Click;
            
            // Agrega el FlowLayoutPanel al control personalizado
            
        }

        // Propiedad para establecer la imagen de la PictureBox
        public Image Image
        {
            get { return pb.Image; }
            set { pb.Image = value; }
        }

        // Propiedad para establecer el título del control
        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        // Propiedad para establecer la descripción del control
        public string Artist
        {
            get { return lblArtist.Text; }
            set { lblArtist.Text = value; }
        }
        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }
        /*protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }*/
        private void caja_Click(object sender, EventArgs e)
        {
            
            VistaAmpliada form = new VistaAmpliada();
            form.Name = this.lblName.Text;
            form.Artist = this.lblArtist.Text;
            form.bajaDatos();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        public void actualizaDatos(string name, string artist)
        {
            this.Name = name;
            this.Artist = artist;
        }
        public string recojeNombre()
        {
            return Name;
            
        }
    }
    
}

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
        private FlowLayoutPanel flp;
        private PictureBox pb;
        private Label lblName;
        private Label lblArtist;

        public Caja()
        {
            // Configura el control personalizado
            this.Size = new Size(200, 200);

            // Configura el FlowLayoutPanel
            flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.MinimumSize = new Size(185, 250);
            flp.MaximumSize = new Size(185, 300);

            // Agrega la PictureBox
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.MinimumSize = new Size(180, 180);
            pb.MaximumSize = new Size(180, 180);
            flp.Controls.Add(pb);

            // Agrega el título
            lblName = new Label();
            lblName.AutoSize = false;
            lblName.Font = new Font("Segoe UI", 16);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.MinimumSize = new Size(180, 30);
            lblName.Margin = new Padding(2, 0, 0, 0);
            flp.Controls.Add(lblName);

            // Agrega la descripción
            lblArtist = new Label();
            lblArtist.AutoSize = false;
            lblArtist.Font = new Font("Segoe UI", 13);
            lblArtist.TextAlign = ContentAlignment.MiddleCenter;
            lblArtist.MinimumSize = new Size(180, 25);
            lblArtist.Margin = new Padding(2, 5, 0, 0);
            flp.Controls.Add(lblArtist);

            // Agrega el FlowLayoutPanel al control personalizado
            this.Controls.Add(flp);
        }

        // Propiedad para establecer la imagen de la PictureBox
        public Image Image
        {
            get { return pb.Image; }
            set { pb.Image = value; }
        }

        // Propiedad para establecer el título del control
        public string Title
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        // Propiedad para establecer la descripción del control
        public string Description
        {
            get { return lblArtist.Text; }
            set { lblArtist.Text = value; }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
    
}

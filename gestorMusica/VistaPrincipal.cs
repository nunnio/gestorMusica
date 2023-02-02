using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDintNuno
{
    public partial class VistaPrincipal : Form
    {
        private int Contador = 1;
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            VistaAnadir form = new VistaAnadir();
            if (form.ShowDialog() == DialogResult.OK)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                PictureBox pb = new PictureBox();
                Label lblName = new Label();
                Label lblArtist = new Label();                

                lblName.Text = form.Name;
                lblName.Font = new Font("Segoe UI", 16);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.MinimumSize = new Size(180, 30);
                //lblName.BackColor = Color.Brown;
                lblName.Margin = new Padding(2,0,0,0);

                lblArtist.Text = form.PArtist;
                lblArtist.Font = new Font("Segoe UI", 13);
                lblArtist.TextAlign = ContentAlignment.MiddleCenter;
                lblArtist.MinimumSize = new Size(180, 25);
                //lblArtist.BackColor = Color.White;
                lblArtist.Margin = new Padding(2,5,0,0);

                panel.Controls.Add(pb);
                panel.Controls.Add(lblName);
                panel.Controls.Add(lblArtist);
                //panel.BackColor = Color.Red;
                panel.MinimumSize = new Size(185, 250);
                panel.MaximumSize = new Size(185, 300);

                pb.Image = form.Image;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.MinimumSize = new Size(180, 180);
                pb.MaximumSize = new Size(180, 180);
                //pb.BackColor = Color.Gray;
                flpConjunto.Controls.Add(panel);

                string[] row = new string[11];
                row[0] = Contador.ToString();
                row[2] = form.Name;
                row[3] = form.PArtist;
                row[4] = form.SArtist;
                row[5] = form.Genre;
                row[6] = form.Format;
                row[7] = form.Type;
                row[8] = form.AdDate.ToString("G");
                row[9] = form.EdDate.ToString("G");
                row[10] = form.Description;

                dgvPrincipal.Rows.Add(row);
                dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cImage"].Value = form.Image;
                Contador++;

                subeDatos(row);


            }
        }
        private void subeDatos(string[] row)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FlowLayoutPanel panel = new FlowLayoutPanel();
            Label etiqueta = new Label();
            etiqueta.Text = "Hey que pasa soy una etiqueta";
            flpConjunto.Controls.Add(etiqueta);
        }
    }
}
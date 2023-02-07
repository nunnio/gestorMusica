using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

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
                lblName.Margin = new Padding(2, 0, 0, 0);

                lblArtist.Text = form.PArtist;
                lblArtist.Font = new Font("Segoe UI", 13);
                lblArtist.TextAlign = ContentAlignment.MiddleCenter;
                lblArtist.MinimumSize = new Size(180, 25);
                //lblArtist.BackColor = Color.White;
                lblArtist.Margin = new Padding(2, 5, 0, 0);

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
                row[1] = form.Name;
                row[2] = form.PArtist;
                row[3] = form.SArtist;
                row[4] = form.Genre;
                row[5] = form.Format;
                row[6] = form.Type;
                row[7] = form.AdDate.ToString("G");
                row[8] = form.EdDate.ToString("G");
                row[9] = form.Description;
                System.Drawing.Image img = form.Image;

                dgvPrincipal.Rows.Add(row);
                dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cImage"].Value = form.Image;
                Contador++;

                subeDatos(row, img);



            }
        }
        private void subeDatos(string[] row, System.Drawing.Image img)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO productos (id, name, partist, sartist, genre, format, type, addate, eddate, description, image) value " +
                "(@id, @name, @partist, @sartist, @genre, @format, @type, @addate, @eddate, @description, @image)";

            cmd.Parameters.AddWithValue("@id", row[0]);
            cmd.Parameters.AddWithValue("@name", row[1]);
            cmd.Parameters.AddWithValue("@partist", row[2]);
            cmd.Parameters.AddWithValue("@sartist", row[3]);
            cmd.Parameters.AddWithValue("@genre", row[4]);
            cmd.Parameters.AddWithValue("@format", row[5]);
            cmd.Parameters.AddWithValue("@type", row[6]);
            cmd.Parameters.AddWithValue("@addate", row[7]);
            cmd.Parameters.AddWithValue("@eddate", row[8]);
            cmd.Parameters.AddWithValue("@description", row[9]);
            cmd.Parameters.AddWithValue("@image", img);
            try
            {
                conn.Open();
                //...
                cmd.ExecuteNonQuery();

                /*Int32 rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("RowsAffected: {0}", rowsAffected);*/

                conn.Close(); //La conexión hay que cerrarla siempre al terminar
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión");
            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine(ex.Message);
            }
        }
    }    
}
/*CREATE TABLE productos (
    id int PRIMARY KEY,
    name VARCHAR(20) UNIQUE,
    partist VARCHAR(45),
    sartist VARCHAR(45),
    genre VARCHAR(45),
    format VARCHAR(10),
    type VARCHAR(10),
    addate DATE,
eddate DATE,
    description VARCHAR(255),
    image BLOB
);*/
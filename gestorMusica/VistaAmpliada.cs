using MySql.Data.MySqlClient;
using ProyectoDintNuno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace gestorMusica
{
    public partial class VistaAmpliada : Form
    {
        private System.Drawing.Image image;
        private VistaPrincipal form = new VistaPrincipal();

        public VistaAmpliada()
        {
            InitializeComponent();
            bajaDatos();
        }
        private void VistaAmpliada_Load(object sender, System.EventArgs e)
        {
            

        }
        private void bajaDatos()
        {
            byte[] caratula;
            String sql = "Select * FROM productos WHERE name = @name AND partist = @partist ;";
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = form.Name.ToString;
            cmd.Parameters.Add("@partist", MySqlDbType.Text).Value = "Green Turtle";

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                tbName.Text = (String)reader[1];
                tbPArtist.Text = (String)reader[2];
                tbSArtist.Text = (String)reader[3];
                tbGenre.Text = (String)reader[4];
                cbType.Text = (String)reader[5];
                cbFormat.Text = (String)reader[6];
                //dtpAdDate = (DateTime)reader[7];
                //dtpEdDate = (DateTime)reader[8];
                tbDescription.Text = (String)reader[9];
                caratula = (byte[])reader[10];
                pbImage.Image = convierteAImg(caratula);
            }
        }
        public System.Drawing.Image convierteAImg(byte[] caratula)
        {
            try
            {
                image = (System.Drawing.Image)new ImageConverter().ConvertFrom(caratula);
            }
            catch { }
            return image;
        }
    }
}

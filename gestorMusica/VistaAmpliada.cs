using MySql.Data.MySqlClient;
using ProyectoDintNuno;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace gestorMusica
{
    public partial class VistaAmpliada : Form
    {
        private System.Drawing.Image image;
        private VistaPrincipal form = new VistaPrincipal();
        private int id;
        public string Name { get; set; }
        public string Artist;

        public VistaAmpliada()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            Caja caja = new Caja();
            //Name = caja.recojeNombre();
            //caja.actualizaDatos(Name, Artist);
            //bajaDatos();            
        }
        /// <summary>
        /// This method gets all the data from the object clicked and puts it on the respective fields.
        /// </summary>
        public void bajaDatos()
        {
            
            try
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
                //this.Name = Caja.Name;
                //Caja.actualizaDatos();
                cmd.Parameters.Add("@name", MySqlDbType.Text).Value = Name;
                cmd.Parameters.Add("@partist", MySqlDbType.Text).Value = Artist;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = (int)reader[0];
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
                    if (!reader.IsDBNull(reader.GetOrdinal("image")))
                    {
                        caratula = (byte[])reader[10];
                        System.Drawing.Image img = convierteAImg(caratula);
                        pbImage.Image = img;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión\n" + ex.Message);
                ex.ToString();
                Console.WriteLine(ex.Message);
            }
           
        }
        private void VistaAmpliada_Load(object sender, System.EventArgs e)
        {
            

        }
        /// <summary>
        /// This method converts a byte array to an Image
        /// </summary>
        /// <param name="caratula"></param>
        /// <returns>An Image</returns>
        public System.Drawing.Image convierteAImg(byte[] caratula)
        {
            try
            {
                image = (System.Drawing.Image)new ImageConverter().ConvertFrom(caratula);
            }
            catch { }
            return image;
        }
        

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            tbName.Enabled = true;
            tbPArtist.Enabled = true;
            tbSArtist.Enabled = true;
            tbGenre.Enabled = true;
            cbFormat.Enabled = true;
            cbType.Enabled = true;
            dtpAdDate.Enabled = true;
            dtpEdDate.Enabled = true;
            tbDescription.Enabled = true;

            btnModify.Text = "Save";
            btnClose.Text= "Cancel";
            btnModify.DialogResult = DialogResult.OK;


            if(DialogResult == DialogResult.Cancel)
            {
                tbName.Enabled = false;
                tbPArtist.Enabled = false;
                tbSArtist.Enabled = false;
                tbGenre.Enabled = false;
                cbFormat.Enabled = false;
                cbType.Enabled = false;
                dtpAdDate.Enabled = false;
                dtpEdDate.Enabled = false;
                tbDescription.Enabled = false;
            }
            if(DialogResult == DialogResult.OK) 
            {
                tbName.Enabled = false;
                tbPArtist.Enabled = false;
                tbSArtist.Enabled = false;
                tbGenre.Enabled = false;
                cbFormat.Enabled = false;
                cbType.Enabled = false;
                dtpAdDate.Enabled = false;
                dtpEdDate.Enabled = false;
                tbDescription.Enabled = false;
                


                string[] row = new string[8];
                DateTime[] fechas = new DateTime[2];
                row[1] = tbName.Text;
                row[2] = tbPArtist.Text;
                row[3] = tbSArtist.Text;
                row[4] = tbGenre.Text;
                row[5] = cbFormat.Text;
                row[6] = cbType.Text;
                row[7] = tbDescription.Text;
                fechas[0] = dtpAdDate.Value;
                fechas[1] = dtpEdDate.Value;

                System.Drawing.Image img = pbImage.Image;

                actualizaDatos(row, img, fechas, id);

                VistaPrincipal form = (VistaPrincipal)System.Windows.Forms.Application.OpenForms[System.Windows.Forms.Application.OpenForms.Count - 2];
                form.reiniciaVistaPrincipal();
                /*
                 Crear un método con clear y bajadatos en vprincipal

                en esta vista hacer:

                 */
            }
        }
        /// <summary>
        /// This method updates the changed data of an object on the database.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="img"></param>
        /// <param name="fechas"></param>
        /// <param name="id"></param>
        private void actualizaDatos(string[] row, System.Drawing.Image img, DateTime[] fechas, int id)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE productos SET " +
                "name = @name, partist = @partist, sartist = @sartist, genre = @genre, format = @format, type = @type, " +
                "addate = @addate, eddate = @eddate, description = @description WHERE id = @id";

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", row[1]);
            cmd.Parameters.AddWithValue("@partist", row[2]);
            cmd.Parameters.AddWithValue("@sartist", row[3]);
            cmd.Parameters.AddWithValue("@genre", row[4]);
            cmd.Parameters.AddWithValue("@format", row[5]);
            cmd.Parameters.AddWithValue("@type", row[6]);
            cmd.Parameters.AddWithValue("@description", row[7]);
            cmd.Parameters.AddWithValue("@addate", fechas[0]);
            cmd.Parameters.AddWithValue("@eddate", fechas[1]);
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
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión\n" + ex.Message);
                ex.ToString();
                Console.WriteLine(ex.Message);
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea borrar este producto?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string[] row = new string[8];
                row[2] = tbPArtist.Text;
                row[3] = tbSArtist.Text;
                borraProducto(row);
                DialogResult = DialogResult.Cancel;
            }
        }
        /// <summary>
        /// This method deletes an object from the database.  
        /// </summary>
        /// <param name="row"></param>
        private void borraProducto(String[] row)
        {
            
            // El usuario acepta
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM productos WHERE name = @name AND partist = @partist";
            cmd.Parameters.AddWithValue("@name", row[1]);
            cmd.Parameters.AddWithValue("@partist", row[2]);


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
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión\n" + ex.Message);
                ex.ToString();
                Console.WriteLine(ex.Message);
            }            
        }
    }
}

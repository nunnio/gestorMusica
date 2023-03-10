using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestorMusica;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoDintNuno
{
    public partial class VistaPrincipal : Form
    {
        private int Contador = 1;

        public string Name;
        public string PArtist;
        public string SArtist;
        public string Genre;
        public string Format;
        public string Type;
        public DateTime AdDate;
        public DateTime EdDate;
        public string Description;
        private System.Drawing.Image image;

        public System.Drawing.Image Image { get; set; }
        public VistaPrincipal()
        {
            InitializeComponent();
            bajaDatos();
            VistaTutorial form = new VistaTutorial();
            if(Contador== 1)
            {
                form.ShowDialog();
                lblVVacia.Visible = true;
            }
            else
            {
                lblVVacia.Visible = false;
            }
            
        }

        private void VistaPrincipal_Load(object sender, System.EventArgs e)
        {

        }
        /// <summary>
        /// This method gets some data from the database and puts it on the main FlowLayoutPanel.
        /// </summary>
        public void bajaDatos()
        {
            String sql = "Select * FROM productos WHERE id >= @id;";
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@id", MySqlDbType.Text).Value = 1;
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    /*string[] row = new string[8];
                    DateTime[] fechas = new DateTime[2];
                    System.Drawing.Image img;

                    row[0] = (String)reader[0];
                    row[1] = (String)reader[1];
                    row[2] = (String)reader[2];
                    row[3] = (String)reader[3];
                    row[4] = (String)reader[4];
                    row[5] = (String)reader[5];
                    row[6] = (String)reader[6];
                    row[7] = (String)reader[7];
                    fechas[0] = (DateTime)reader[8];
                    fechas[1] = (DateTime)reader[9];
                    img = (System.Drawing.Image)reader[10];              

                    dgvPrincipal.Rows.Add(row);
                    dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cImage"].Value = img;
                    dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cAdDate"].Value = fechas[0];
                    dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cEdDate"].Value = fechas[1];
                    */



                    string n; string a;
                    byte[] caratula;

                    Caja caja = new Caja();
                    Contador = (int)reader[0] + 1;
                    //Name = (String)reader[1];
                    //PArtist = (String)reader[2];
                    n = (String)reader[1];
                    a = (String)reader[2];
                    caja.Name = n;
                    caja.Artist = a;
                    if (!reader.IsDBNull(reader.GetOrdinal("image")))
                    {
                        caratula = (byte[])reader[10];
                        System.Drawing.Image img = convierteAImg(caratula);
                        caja.Image = img;
                    }
                    //caja.actualizaDatos(Name, PArtist);
                    flpConjunto.Controls.Add(caja);
                    
                    /*
                    lblName.Text = (String)reader[1];
                    lblName.Font = new Font("Segoe UI", 16);
                    lblName.TextAlign = ContentAlignment.MiddleCenter;
                    lblName.MinimumSize = new Size(180, 30);
                    //lblName.BackColor = Color.Brown;
                    lblName.ForeColor= Color.White;
                    lblName.Margin = new Padding(2, 0, 0, 0);

                    lblArtist.Text = (String)reader[2];
                    lblArtist.Font = new Font("Segoe UI", 13);
                    lblArtist.TextAlign = ContentAlignment.MiddleCenter;
                    lblArtist.MinimumSize = new Size(180, 25);
                    //lblArtist.BackColor = Color.White;
                    lblArtist.ForeColor = Color.White;
                    lblArtist.Margin = new Padding(2, 5, 0, 0);
                    System.DBNull si;
                    if (!reader.IsDBNull(reader.GetOrdinal("image"))) 
                    {
                        caratula = (byte[])reader[10];
                        System.Drawing.Image img = convierteAImg(caratula);
                        pb.Image = img;
                    }
                    //pb.Image = (Bitmap)caratula;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.MinimumSize = new Size(180, 180);
                    pb.MaximumSize = new Size(180, 180);
                    //pb.BackColor = Color.Gray;

                    panel.Controls.Add(pb);
                    panel.Controls.Add(lblName);
                    panel.Controls.Add(lblArtist);
                    //panel.BackColor = Color.Red;
                    panel.MinimumSize = new Size(185, 250);
                    panel.MaximumSize = new Size(185, 300);

                    flpConjunto.Controls.Add(panel);

                    Name = lblName.Text;
                    */

                    //pb.Click += new System.EventHandler(muestraInfo);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión\n" + ex.Message);
                ex.ToString();
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// This method converts an Image to a byte array.
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns>A byte array</returns>
        public byte[] convierteAArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// This method converts a byte array to an Image
        /// </summary>
        /// <param name="caratula"></param>
        /// <returns>An Image</returns>
        public System.Drawing.Image convierteAImg(byte[] caratula)
        {
            
            try { 
                image = (System.Drawing.Image)new ImageConverter().ConvertFrom(caratula);
            }
            catch { }
            return image;
            

            /* 
            Bitmap bm = (Bitmap)new ImageConverter().ConvertFrom(caratula);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;*/
            /*System.Drawing.Image returnImage;
            using (var ms = new MemoryStream(caratula))
            {
                //returnImage = (System.Drawing.Image) Bitmap.FromStream(ms);
                
                
                returnImage = System.Drawing.Image.FromStream(ms);
                return returnImage;
            }*/
            
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            VistaAnadir form = new VistaAnadir();
            // Obtener la ruta de la carpeta "Images" en la raíz del proyecto
            string imagePath = "./Images";
            

            // Copiar la imagen seleccionada en el cuadro de diálogo a la carpeta "Images"
            //File.Copy(op.FileName, Path.Combine(imagePath, Path.GetFileName(op.FileName)));

            if (form.ShowDialog() == DialogResult.OK)
            {

                Caja caja = new Caja();
                //Name = (String)reader[1];
                //PArtist = (String)reader[2];
                caja.Name = form.Name;
                caja.Artist = form.PArtist;
                caja.Image = form.Image;
                //caja.actualizaDatos(Name, PArtist);
                flpConjunto.Controls.Add(caja);

                FlowLayoutPanel panel = new FlowLayoutPanel();
                PictureBox pb = new PictureBox();
                Label lblName = new Label();
                Label lblArtist = new Label();

                /*
                lblName.Text = form.Name;
                lblName.Font = new Font("Segoe UI", 16);
                lblName.TextAlign = ContentAlignment.MiddleCenter;
                lblName.MinimumSize = new Size(180, 30);
                //lblName.BackColor = Color.Brown;
                lblName.ForeColor = Color.White;
                lblName.Margin = new Padding(2, 0, 0, 0);

                lblArtist.Text = form.PArtist;
                lblArtist.Font = new Font("Segoe UI", 13);
                lblArtist.TextAlign = ContentAlignment.MiddleCenter;
                lblArtist.MinimumSize = new Size(180, 25);
                //lblArtist.BackColor = Color.White;
                lblArtist.ForeColor = Color.White;
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
                */

                string[] row = new string[8];
                DateTime[] fechas = new DateTime[2];
                row[0] = Contador.ToString();
                row[1] = form.Name;
                row[2] = form.PArtist;
                row[3] = form.SArtist;
                row[4] = form.Genre;
                row[5] = form.Format;
                row[6] = form.Type;
                row[7] = form.Description;
                fechas[0] = form.AdDate;
                fechas[1] = form.EdDate;
                
                System.Drawing.Image img = form.Image;

                dgvPrincipal.Rows.Add(row);
                dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cImage"].Value = form.Image;
                dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cAdDate"].Value = fechas[0];
                dgvPrincipal.Rows[dgvPrincipal.Rows.Count - 1].Cells["cEdDate"].Value = fechas[1];
                
                Contador++;

                byte[] caratula = convierteAArray(img);

                subeDatos(row, caratula, fechas);

                pb.Click += new System.EventHandler(muestraInfo);
                lblVVacia.Visible = false;
                
            }
        }
        /// <summary>
        /// This method shows all the information from the object clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void muestraInfo(object sender, EventArgs e)
        {
            
            VistaAmpliada form = new VistaAmpliada();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Name = Name;
                
            }
        }
        /// <summary>
        /// This method uploads all the information from an object created.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="img"></param>
        /// <param name="fechas"></param>
        private void subeDatos(string[] row, byte[] img, DateTime[] fechas)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "enclavedb";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO productos (id, name, partist, sartist, genre, format, type, addate, eddate, description) value " +
                "(@id, @name, @partist, @sartist, @genre, @format, @type, @addate, @eddate, @description)";

            cmd.Parameters.AddWithValue("@id", row[0]);
            cmd.Parameters.AddWithValue("@name", row[1]);
            cmd.Parameters.AddWithValue("@partist", row[2]);
            cmd.Parameters.AddWithValue("@sartist", row[3]);
            cmd.Parameters.AddWithValue("@genre", row[4]);
            cmd.Parameters.AddWithValue("@format", row[5]);
            cmd.Parameters.AddWithValue("@type", row[6]);            
            cmd.Parameters.AddWithValue("@description", row[7]);
            cmd.Parameters.AddWithValue("@addate", fechas[0]);
            cmd.Parameters.AddWithValue("@eddate", fechas[1]);
            
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
                MessageBox.Show("Error en conexión a base de datos\nFallo en conexión\n"+ex.Message);
                ex.ToString();
                Console.WriteLine(ex.Message);
            }

            //string sql = "UPDATE productos SET imagen = @imagen WHERE id = @id";
            cmd.CommandText = "UPDATE productos SET image = @image WHERE id = @id";
            //cmd.Parameters.AddWithValue("@id", row[0]);
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

        private void iniciarVistaTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaTutorial form = new VistaTutorial();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void reiniciaVistaPrincipal()
        {
            //this.Dispose();
            flpConjunto.Controls.Clear();
            bajaDatos();
        }
    }
}
 
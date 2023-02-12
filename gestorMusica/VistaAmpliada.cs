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

namespace gestorMusica
{
    public partial class VistaAmpliada : Form
    {
        public VistaAmpliada()
        {
            InitializeComponent();
        }
        private void VistaAmpliada_Load(object sender, System.EventArgs e)
        {
            VistaPrincipal form = new VistaPrincipal();
            lblNombre.Text = form.Name;
            lblArtista.Text = form.PArtist;
        }
    }
}

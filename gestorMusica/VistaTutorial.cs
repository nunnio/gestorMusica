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
    public partial class VistaTutorial : Form
    {
        private int indice = 1;
        public VistaTutorial()
        {
            InitializeComponent();
            pb1.Image = Image.FromFile("./images/T1.jpg");
            pb2.Image = Image.FromFile("./images/T2.jpg");
            pb3.Image = Image.FromFile("./images/T3.jpg");
            pb4.Image = Image.FromFile("./images/T4.jpg");
            pb5.Image = Image.FromFile("./images/T5.jpg");
            pb6.Image = Image.FromFile("./images/T6.jpg");
            pb7.Image = Image.FromFile("./images/T7.jpg");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(indice >= 8)
            {
                indice = 7;
            }
            else
            {
                indice++;
                cambiaHoja();
            }
            if (indice == 7)
            {
                btnNext.Visible = false;
                btnPrevious.Visible = true;
            }
            else
            {
                btnPrevious.Visible = true;
                btnNext.Visible = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(indice <= 0)
            {
                indice = 1;
            }
            else
            {
                indice--;
                cambiaHoja();
            }
            if (indice == 1)
            {
                btnPrevious.Visible = false;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Visible = true;
                btnPrevious.Visible = true;
            }
        }
        /// <summary>
        /// This method has a switch which changes the tabView depending on the value of the index.
        /// </summary>
        private void cambiaHoja()
        {
            switch(indice)
            {
                case 1: tcTutorial.SelectedTab = tpTutorial1; break;
                case 2: tcTutorial.SelectedTab = tpTutorial2; break;
                case 3: tcTutorial.SelectedTab = tpTutorial3; break;
                case 4: tcTutorial.SelectedTab = tpTutorial4; break;
                case 5: tcTutorial.SelectedTab = tpTutorial5; break;
                case 6: tcTutorial.SelectedTab = tpTutorial6; break;
                case 7: tcTutorial.SelectedTab = tpTutorial7; break;
            }
        }

        private void VistaTutorial_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}

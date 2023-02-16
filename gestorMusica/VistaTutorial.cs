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
            if(cbStart.Checked== true )
            {
                DialogResult= DialogResult.Cancel;
            }
            else { DialogResult = DialogResult.OK; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(indice >= 12)
            {
                indice = 11;
            }
            else
            {
                indice++;
                cambiaHoja();
            }
            if (indice == 6)
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
            }
        }

        private void VistaTutorial_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}

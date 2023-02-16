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
    public partial class TextBoxPersonalizado: Control
    {
        private TextBox tb;
        private Color hintColor = Color.DarkGray;
        private string hintText;
        private bool esHint;
        private bool estaFocus = false;
        public TextBoxPersonalizado()
        {
            InitializeComponent();
            tb = new TextBox();
            tb.Dock= DockStyle.Fill;
            tb.BorderStyle= BorderStyle.Fixed3D;
            /*tb.Anchor= AnchorStyles.Left;
            tb.Anchor= AnchorStyles.Right;
            tb.Anchor= AnchorStyles.Top;
            tb.Anchor= AnchorStyles.Bottom;*/
            this.Controls.Add(tb);
        }
        [Category("Data")]
        public string textos
        {
            get
            {
                if (esHint) return "";
                else return tb.Text;
            }
            set
            {
                tb.Text = value;
                setHint();
            }
        }

        public Color HintColor{
            get
            {
                return hintColor;
            }
            set
            {
                hintColor = value;
                
            }
        }
        public string HintText
        {
            get
            {
                return hintText;
            } 
            set
            {
                hintText = value;
                tb.Text = "";
                setHint();
            }
        
        }

        private void setHint()
        {
            if(string.IsNullOrEmpty(tb.Text) && hintText != "")
            {
                esHint = true;
                tb.Text = hintText;
                tb.ForeColor = hintColor;

            }
        }
        private void borraHint()
        {
            if (esHint && hintText != "")
            {
                esHint = false;
                tb.Text = "";
                tb.ForeColor = this.ForeColor;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }
        
        private void tb_Enter(object sender, EventArgs e)
        {
            estaFocus= true;
            this.Invalidate();
            borraHint();
        }
        private void tb_Leave(object sender, EventArgs e)
        {
            estaFocus= false;
            this.Invalidate();
            setHint();
        }
    }
}

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
    public partial class TextBoxPersonalizado : Control
    {
        public TextBoxPersonalizado()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
            InitializeComponent();
        }

        bool esHint = true;
        string hintText;
        public string HintText
        {
            get { return hintText; }
            set
            {
                hintText = value;
                setHint();
            }
        }

        public new string Text
        {
            get => esHint ? string.Empty : base.Text;
            set => base.Text = value;
        }

        // Cuando el control no tiene el focus, el hint se muestra
        private void setHint()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = hintText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                esHint = true;
            }
        }

        // Cuanod el control tiene el focus, el hint se borra
        private void removePlaceHolder()
        {

            if (esHint)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                esHint = false;
            }
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setHint();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }
    }
}

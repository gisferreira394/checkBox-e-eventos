using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox_e_eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            if (maça.Checked)
            {
                txt += maça.Text + ",";
            }
            if (banana.Checked)
            {
                txt += banana.Text + ",";   
            }
            if (manga.Checked)
            {
                txt+= manga.Text + ","; 
            }
            if (uva.Checked)
            {
                txt+= uva.Text + ",";
            }
            if (cereja.Checked) { 
            txt += cereja.Text + ",";
            }
            if (laranja.Checked)
            {
                txt +=(laranja.Text+",");   
            }
            if (goiaba.Checked) {
            txt += goiaba.Text + ",";
            }
            MessageBox.Show("A fruta escolhida foi: " + txt, "A fruta escolhida foi ...");
        }
    }
}

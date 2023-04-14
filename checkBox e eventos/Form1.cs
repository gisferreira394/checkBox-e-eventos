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
        List<CheckBox> frutas  =new List<CheckBox> ();    

        public Form1()
        {
            InitializeComponent();
            frutas.Add(maça);
            frutas.Add(banana);
            frutas.Add(manga);
            frutas.Add(uva);
            frutas.Add(cereja);
            frutas.Add(laranja);
            frutas.Add(goiaba);
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            String txt = "";

            foreach (CheckBox t in frutas)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
                MessageBox.Show("A fruta escolhida foi: " + txt, "Escolha: ");

        //    if (maça.Checked)
        //    {
        //        txt += maça.Text + ",";
        //    }
        //    if (banana.Checked)
        //    {
        //        txt += banana.Text + ",";   
        //    }
        //    if (manga.Checked)
        //    {
        //        txt+= manga.Text + ","; 
        //    }
        //    if (uva.Checked)
        //    {
        //        txt+= uva.Text + ",";
        //    }
        //    if (cereja.Checked) { 
        //    txt += cereja.Text + ",";
        //    }
        //    if (laranja.Checked)
        //    {
        //        txt +=(laranja.Text+",");   
        //    }
        //    if (goiaba.Checked) {
        //    txt += goiaba.Text + ",";
        //    }
           MessageBox.Show("A fruta escolhida foi: " + txt, "A fruta escolhida foi ...");
        }

        private void maça_CheckedChanged(object sender, EventArgs e)
        {
if (maça.Checked)
            {
                MessageBox.Show("Você marcou Maçã !");
            }
        }

        private void banana_CheckedChanged(object sender, EventArgs e)
        {
            if(banana.Checked)
            {
                MessageBox.Show("Você marcou a Banana !");
            }
        }

        private void manga_CheckedChanged(object sender, EventArgs e)
        {
            if (manga.Checked)
            {
                MessageBox.Show("Voê marcou Manga ! ");
            }
        }

        private void uva_CheckedChanged(object sender, EventArgs e)
        {
            if (uva.Checked)
            {
                MessageBox.Show("Você marcou Uva !");
            }
        }

        private void cereja_CheckedChanged(object sender, EventArgs e)
        {
            if (cereja.Checked)
            {
                MessageBox.Show("Você marcou Cereja !");
               
            }

        }

        private void laranja_CheckedChanged(object sender, EventArgs e)
        {
            if(laranja.Checked)
            {
                MessageBox.Show("Você marcou Laranja !");
            }
        }

        private void goiaba_CheckedChanged(object sender, EventArgs e)
        {
            if (goiaba.Checked)
            {
                MessageBox.Show("Você marcou Goiaba !");

               
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_verschluesseln_Click(object sender, EventArgs e)
        {
            string eingabe;
            int k;


            k = Convert.ToInt32(tb_schluessel.Text);


            eingabe = tb_eingabe.Text;
            eingabe.ToUpper();
            int chVerschlüsselt =0;
            foreach (char ch in eingabe)
            {
                chVerschlüsselt = (ch - 'A' + k) % 26 + 'A';
            }



            tb_ausgabe.Text = Convert.ToString(chVerschlüsselt);

        }


    }
}

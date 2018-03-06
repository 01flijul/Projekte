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
       

        private void btn_verschluesseln_Click(object sender, EventArgs e)
        {
            string eingabe;

            eingabe = tb_eingabe.Text;
            eingabe.ToUpper();
        }


    }
}

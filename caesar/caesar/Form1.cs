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
             char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();   // Wandle einen String in ein char-Array
             string klartext = tb_eingabe.Text;                          // Der zu verschlüsselnde Text = klartext
            int schluessel = int.Parse(tb_schluessel.Text);                                             // Schlüssel 3 für die Cäsar-Verschlüsselung 
            string code = "";                                               // Hier wird der verschlüsselte Text gespeichert
 
            foreach (char c in klartext.ToUpper())                          // Iteriere durch jedes Zeichen im Klartext und wandle in Großbuchstaben
            {
                if (alphabet.Contains(c))                                   // Prüfe ob das aktuelle Zeichen ein Buchsatbe im Alphabet ist
                {
                    int position = Array.IndexOf(alphabet, c);              // Ermittle die aktuelle Indexposition des Zeichens im Array
                    int position_new = position + schluessel;               // Addiere den Schlüssel zur Indexposition 
                    int rest = position_new % 26;                           // Berechne die neue Indexposition
                    code += alphabet[rest];                                 // Füge den neuen Buchstaben dem verschlüsselten Text hinzu
                }
                else
                {
                    code += c;      // Wenn kein Buchstabe aus dem Alphabet (z.B. Leerzeichen) gefunden wurde, übernimm das Zeichen
                }
            }
            tb_ausgabe.Text = (code);


        }


    }
}

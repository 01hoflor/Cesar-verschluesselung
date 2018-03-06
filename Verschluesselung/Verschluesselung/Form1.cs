using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverschluessenln_Click(object sender, EventArgs e)
        {
            char[] eingabe = rtbEingabe.Text.ToCharArray();
            int schluessel = Convert.ToInt16(tBVerschluesselung.Text);
            int asciicode = 0;
            string halter = " ";
            string ausgabe = " ";
            for (int i = 0; i < eingabe.Length; i++)
            {
                asciicode = Convert.ToInt32(eingabe[i]);
                asciicode = asciicode + schluessel;
                eingabe[i] = Convert.ToChar(asciicode);
                halter = Convert.ToString(eingabe[i]);
                ausgabe = ausgabe + halter; 

            }
            rtbAusgabe.Text = ausgabe; 
        }

        private void btnEntschluesseln_Click(object sender, EventArgs e)
        {
            char[] eingabe = rtbEingabe.Text.ToCharArray();
            int schluessel = Convert.ToInt16(tBVerschluesselung.Text);
            int asciicode = 0;
            string halter = " ";
            string ausgabe = " ";
            for (int i = 0; i < eingabe.Length; i++)
            {
                asciicode = Convert.ToInt32(eingabe[i]);
                asciicode = asciicode + schluessel;
                eingabe[i] = Convert.ToChar(asciicode);
                halter = Convert.ToString(eingabe[i]);
                ausgabe = ausgabe + halter;

            }
            rtbEntschluesselt.Text = ausgabe; 
        }

        private void tBVerschluesselung_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbEingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbAusgabe_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void rtbEntschluesselt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntschluesseln_Click_1(object sender, EventArgs e)
        {
            char[] eingabe = rtbAusgabe.Text.ToCharArray();
            int schluessel = Convert.ToInt16(tBVerschluesselung.Text);
            int asciicode = 0;
            string halter = " ";
            string ausgabe = " ";
            for (int i = 0; i < eingabe.Length; i++)
            {
                asciicode = Convert.ToInt32(eingabe[i]);
                asciicode = asciicode - schluessel;
                eingabe[i] = Convert.ToChar(asciicode);
                halter = Convert.ToString(eingabe[i]);
                ausgabe = ausgabe + halter;

            }
            rtbEntschluesselt.Text = ausgabe; 
        }
    }
}

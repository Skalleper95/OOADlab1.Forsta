using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace GUI
{
    public partial class Form1 : Form
    {

        internal BusinessManager BusinessManager { get; set; }
        
        

        public Form1(BusinessManager businessManager)
        {
            InitializeComponent();
            BusinessManager = businessManager;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lösenord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoggaInKnapp_Click(object sender, EventArgs e)
        {
            bool OK = false;
            int ID = int.Parse(IDtext.Text);

            //kalla på metod för inloggning
            OK = BusinessManager.loggaIn(ID, Lösenordtext.Text.ToString().ToLower());



            //Loop för att logga in 
            if (OK == true)
            {
                BusinessManager.inloggad = ID;
                Start start = new Start(BusinessManager);
                start.Show();
                
            }
            else
            {
                MessageBox.Show("Misslyckad inlogging", "Fel");
            }


        }
    }
}

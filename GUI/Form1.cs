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

            //Loop för att se ifall inloggningen stämmer
            foreach (Anställd A in BusinessManager.AnstRepo.anställda)
            {
                if (A.anstNr == ID)
                {

                    if (A.lösenord.ToLower() == Lösenordtext.Text.ToString().ToLower())
                    {
                        OK = true;
                        
                        break;
                    }

                }


            }

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

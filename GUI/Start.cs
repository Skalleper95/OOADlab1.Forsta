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
    public partial class Start : Form
    {
        public BusinessManager BusinessManager { get; }
        public Start(BusinessManager businessManager)
        {
            //Laddar in saker i listorna
            InitializeComponent();
            BusinessManager = businessManager;
            List<Bok> Boklista = businessManager.BokRepo.GetBöcker();
            ListboxBöcker.DataSource = Boklista;
            ListboxBöcker.SelectionMode = SelectionMode.MultiExtended;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void SkapaBokninKnapp_Click(object sender, EventArgs e)
        {
            //Knapp för att skapa en bokning
            Anställd A = BusinessManager.GetAnställd(BusinessManager.AnstRepo.inloggad);
            int MNr = int.Parse(MedlemsIdBox.Text);
            
            //Skapar en lista med böckerna som är valda
            List<Bok> B = new List<Bok>();
            for (int i = 0; i < ListboxBöcker.Items.Count; i++)
            {
                Bok b = (Bok)ListboxBöcker.Items[i];
                B.Add(b);
            }

            Bokning Bokn = A.skapaBokning(MNr, B, BusinessManager.AnstRepo.inloggad, BusinessManager);
            
            //En box för att se så informationen stämmer
            DialogResult Svar;
            Svar = MessageBox.Show($"Medlem: {Bokn.medlem.namn}\nAnställd: {Bokn.anställd.namn}", "stämmer detta?", MessageBoxButtons.YesNo);
            if (Svar == DialogResult.No)
            {
                Close();
            }
            else if (Svar == DialogResult.Yes)
            {
                BusinessManager.BoknRepo.AddBokning(Bokn);
                MessageBox.Show($"{Bokn.BokningsNr}", "Ditt boknings nummer är");
            }
            
            
        }

        private void AvslutaBokning_Click(object sender, EventArgs e)
        {
            //Knapp för att avsluta en bokning och skapar då en fakruta
            Bokning B = null;
            if (BokningsNrBox.Text == "")
            {

            }
            else
            {
                B = BusinessManager.BoknRepo.GetBokning(int.Parse(BokningsNrBox.Text), BusinessManager);
            }
            
            if (B == null)
            {
                MessageBox.Show("Den angivna bokningen existerar inte", "Error");
            }
            else
            {
               
                Faktura F = B.skapaFaktura(B.BokningsNr, BusinessManager);

                MessageBox.Show($"Bokningen varade mellan {F.startDate} och {F.endDate}\nPriset blir {F.Pris}Kr", "Bokningen har avbrutits");
            }

        }

    }
}

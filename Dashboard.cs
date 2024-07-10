using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosalloniBlendi
{
    public partial class Dashboard : Form
    {
        public Dashboard(string loginUsername)
        {
            InitializeComponent();
            usernameLabel.Text = loginUsername;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ju jeni ne faqen e ballines! Ju lutem klikoni ne nje buton tjeter!");
        }

        private void carOffersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Veturaneshitje veturaneshitje = new Veturaneshitje();
            veturaneshitje.Show();
        }

        private void carRentalButton_Click(object sender, EventArgs e)
        {

        }

        private void carPicturesButton_Click(object sender, EventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult goBackResult = MessageBox.Show("Deshironi te kthehuni mbrapa?", "Kthehu mbrapa?", MessageBoxButtons.YesNo);
            
            if (goBackResult == DialogResult.Yes)
            {
                this.Hide();
                Kycja kycja = new Kycja();
                kycja.Show();
            }
            else
            {
                return;
            }

        }
    }
}

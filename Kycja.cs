namespace AutosalloniBlendi
{
    public partial class Kycja : Form
    {
        public Kycja()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regjistrimi regjistrimi = new Regjistrimi();
            regjistrimi.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageButtons = MessageBoxButtons.YesNo;
            DialogResult messageBox;
            messageBox = MessageBox.Show("Deshironi te mbyllni faqen?", "Mbylle", messageButtons);
            if (messageBox == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void authorRightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeDrejtat teDrejtat = new TeDrejtat();
            teDrejtat.Show();
        }
    }
}

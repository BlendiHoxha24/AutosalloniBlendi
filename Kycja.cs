using AutosalloniBlendi.Models;
using System.Data.SqlClient;

namespace AutosalloniBlendi
{
    public partial class Kycja : Form
    {
        public string dbConnectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Fresk\\source\\repos\\AutosalloniBlendi\\AutosalloniBlenidDB.mdf;Integrated Security=True";

        public Kycja()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUsername = userLoginInput.Text;
            string loginPassword = passwordLoginInput.Text;

            if (loginUsername != "" && loginPassword != "")
            {
                SqlConnection conn = new SqlConnection(dbConnectionString);
                conn.Open();

                SqlCommand findUser = new SqlCommand("SELECT * FROM Perdoruesit WHERE perdoruesi = @username AND fjalekalimi = @password");
                findUser.Parameters.AddWithValue("@username", loginUsername);
                findUser.Parameters.AddWithValue("@password", loginPassword);

                SqlDataReader dataReader = findUser.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(loginUsername);
                    dashboard.Show();
                }

                conn.Close();
            }
            else if (loginUsername == "" || loginUsername == null)
            {
                DialogResult dialogResult = MessageBox.Show("Ju lutem shenoni emrin e perdoruesit!", "Perdoruesi eshte zbrazet!", MessageBoxButtons.OK);
            }
            else if (loginPassword == "" || loginPassword == null)
            {
                DialogResult dialogResult = MessageBox.Show("Ju lutem shenoni fjalekalimin!", "Fjalekalimi eshte zbrazet!", MessageBoxButtons.OK);
            }
            else if (loginUsername == "" && loginPassword == "")
            {
                DialogResult dialogResult = MessageBox.Show("Ju lutem shenoni emrin e perdoruesit dhe fjalekalimin!", "Shenoni fushat!", MessageBoxButtons.OK);
            }

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

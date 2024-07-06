using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutosalloniBlendi
{
    public partial class Regjistrimi : Form
    {
        public Regjistrimi()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = userRegisterInput.Text;
            string password = passwordRegisterInput.Text;
            string confirmPassword = confirmPasswordInput.Text;
            if (checkEmailValid(emailRegisterInput.Text))
            {
                string email = emailRegisterInput.Text;
            }
            else
            {
                return;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kycja kycja = new Kycja();
            kycja.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 

        public bool checkEmailValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            if (Regex.IsMatch(email, regex, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Ky email eshte invalide! Sigurohuni qe email-i permban @ dhe top level domain (.com, .net etj)", "Invalid Email", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
        
    

using AutosalloniBlendi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string dbConnectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Fresk\\source\\repos\\AutosalloniBlendi\\AutosalloniBlenidDB.mdf;Integrated Security=True";
        public Regjistrimi()
        {
            InitializeComponent();
            dateOfBirthRegisterInput.Format = DateTimePickerFormat.Custom;
            dateOfBirthRegisterInput.CustomFormat = "dd/MM/yyyy";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string registerUsername = userRegisterInput.Text;
            string registerPassword = passwordRegisterInput.Text;
            string confirmPassword = confirmPasswordInput.Text;
            string registerEmail = emailRegisterInput.Text;
            string registerPhoneNumber = phoneNumberRegisterInput.Text;
            string registerAddress = addressRegisterInput.Text;
            string registerGender;
            DateTime registerDOB = dateOfBirthRegisterInput.Value.Date;

            if (genderMaleButton.Checked)
            {
                registerGender = "Mashkull";
            }
            else
            {
                registerGender = "Femer";
            }

            bool allFieldsValid = CheckAndDisplayEmptyFields(registerUsername, registerPassword, confirmPassword, registerEmail, registerPhoneNumber, registerAddress);

            if (allFieldsValid)
            {
                Perdoruesit newUser = new Perdoruesit();

                newUser.Username = registerUsername;
                newUser.Password = registerPassword;
                newUser.Email = registerEmail;
                newUser.Address = registerAddress;
                newUser.DateCreated = DateTime.Now;
                newUser.DateUpdated = DateTime.Now;
                newUser.DateOfBirth = registerDOB;
                newUser.Gender = registerGender;

                SqlConnection conn = new SqlConnection(dbConnectionString);

                conn.Open();

                SqlCommand checkIfUserExists = new SqlCommand("SELECT * FROM Perdoruesi WHERE perdoruesi = @username AND fjalekalimi = @password");
                checkIfUserExists.Parameters.AddWithValue("@username", newUser.Username);
                checkIfUserExists.Parameters.AddWithValue("@password", newUser.Password);

                SqlDataReader dataReader = checkIfUserExists.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    MessageBox.Show("Perdoruesi ekziston! Ju lutem kycuni rregullisht!");
                }
                else
                {
                    SqlCommand insertNewUser = new SqlCommand(
                        "INSERT INTO Perdoruesi(" +
                        "perdoruesi," +
                        "fjalekalimi," +
                        "email," +
                        "numriTelefonit," +
                        "adresa," +
                        "gjinia," +
                        "dataELindjes," +
                        "dataEKrijimit," +
                        "dataEPerditesimit) " +
                        "VALUES(" +
                        "@username," +
                        "@password," +
                        "@email," +
                        "@phoneNumber," +
                        "@address," +
                        "@gender," +
                        "@dob," +
                        "@dateCreated," +
                        "@dateUpdated" +
                        ")"
                        
                        );

                    insertNewUser.Parameters.AddWithValue("@username", newUser.Username);
                    insertNewUser.Parameters.AddWithValue("@password", newUser.Password);
                    insertNewUser.Parameters.AddWithValue("@email", newUser.Email);
                    insertNewUser.Parameters.AddWithValue("@phoneNumber", newUser.PhoneNumber);
                    insertNewUser.Parameters.AddWithValue("@address", newUser.Address);
                    insertNewUser.Parameters.AddWithValue("@gender", newUser.Gender);
                    insertNewUser.Parameters.AddWithValue("@dob", newUser.DateOfBirth);
                    insertNewUser.Parameters.AddWithValue("@dateCreated", newUser.DateCreated);
                    insertNewUser.Parameters.AddWithValue("@dateUpdated", newUser.DateUpdated);

                    insertNewUser.ExecuteNonQuery();

                    MessageBox.Show("Perdoruesi u krijua!");
                    this.Hide();
                    Dashboard dashboard = new Dashboard(newUser.Username);
                    dashboard.Show();

                    conn.Close();
                }
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

        private bool CheckAndDisplayEmptyFields(string username, string password, string confirmPassword, string email, string phoneNumber, string address)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Perdoruesi eshte zbrazet!");
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fjalekalimi eshte zbrazet!");
                return false;
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Konfirmo fjalkalimin!");
                return false;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Fjalkalimi nuk eshte njesoj!");
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email-i eshte zbrazet!");
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Ky email eshte invalide!");
                return false;
            }
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Numri i telefonit eshte zbrazet!");
                return false;
            }
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Ky numer eshte invalid!");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Adresa eshte zbrazet!");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string kosovoPhonePattern = @"^(\+?383|0)(44|45|49)\d{6}$";
            return Regex.IsMatch(phoneNumber, kosovoPhonePattern);
        }
    }
}
        
    

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogowanieApp
{ 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password1 = PasswordEntry1.Text;
            string password2 = PasswordEntry2.Text;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageLabel.Text = "Nieprawidłowy adres e-mail";
            }

            else if (string.IsNullOrWhiteSpace(password1) || password1 != password2)
            {
                MessageLabel.Text = "Hasła się różnią";
            }
            else
            {
                MessageLabel.Text = $"Witaj {email}";
            }
        }
    }
}
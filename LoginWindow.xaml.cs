using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MertKaymaz_301Project.Service;

namespace MertKaymaz_301Project
{
    /// <summary>
    /// LoginWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AlaService alaService = new AlaService();
            //txtPassword.Text=cetUserService.hashPassword("admin");
            var loginUser = alaService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                /// Doğru giriş yapıldı.
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                this.Close();
            }
        }
    }
}

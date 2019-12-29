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
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MertKaymaz_301Project.Data;
using MertKaymaz_301Project.Service;
using System.Linq;

namespace MertKaymaz_301Project
{
    /// <summary>
    /// PasswordChange.xaml etkileşim mantığı
    /// </summary>

    
    public partial class PasswordChange : Window { 


        private Owner loginUser;
        private AlaKurumsalDatabase db = new AlaKurumsalDatabase();
    public PasswordChange(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlaService alaService = new AlaService();

            string tempeskisifre = alaService.hashPassword(txtEski.Password.ToString());

            if (tempeskisifre == loginUser.Password)
            {
                string tempyenisifre = alaService.hashPassword(txtYeni.Password.ToString());
                string tempyenisifretekrar = alaService.hashPassword(txtYeniTekrar.Password.ToString());
                if (tempyenisifre == tempyenisifretekrar)
                {
                    loginUser.Password = tempyenisifre;
                    db.Owners.Update(loginUser);
                    db.SaveChangesAsync();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                    this.Close();
                }
                else MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else MessageBox.Show("Hatalı Giriş Yaptınız");
        }
    }
}

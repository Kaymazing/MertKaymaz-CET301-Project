using MertKaymaz_301Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MertKaymaz_301Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Owner loginUser;
        public MainWindow(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtLoginUsers.Text = "Hoş geldin " + loginUser.Name + " " + loginUser.Surname + ".";
        }

            private void MenuItem_Click(object sender, RoutedEventArgs e) //HW5'ten alınmıştır.
            {
                if (MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            }

            private void MenuItem_Click_1(object sender, RoutedEventArgs e)
            {

            }

            private void SifreDegistirClick(object sender, RoutedEventArgs e)
            {
                PasswordChange passwordChange = new PasswordChange(loginUser);
                passwordChange.Show();
            }


            private void Araclar_Click(object sender, RoutedEventArgs e)
            {
            Araclar araclar = new Araclar(loginUser);
            araclar.Show();
            this.Close();
        }

            private void Musteriler_Click(object sender, RoutedEventArgs e)
            {
            Customers customers = new Customers(loginUser);
            customers.Show();
            this.Close();
        }
        }
    }

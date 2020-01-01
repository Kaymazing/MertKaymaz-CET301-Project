using MertKaymaz_301Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;

namespace MertKaymaz_301Project
{
    /// <summary>
    /// Customers.xaml etkileşim mantığı
    /// </summary>
    public partial class Customers : Window
    {
        private Owner loginUser;
        AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
        public Customers(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
        }

        private void CWguncelleexpand_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = dgCustomers.SelectedItem as Customer;
            if (customer != null)
            {
                AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
                var customernew = alaKurumsalDatabase.Customers.Find(customer.Id);

                customernew.Name = CWisim.Text;
                customernew.Surname = CWsoyisim.Text;
                customernew.Phone = CWtelefon.Text;
                customernew.Age = int.Parse(CWyas.Text);
                customernew.City = CWsehir.Text;
                customernew.HasLicence = CWehliyet.IsChecked;
                customernew.HasCriminalRecord = CWsabika.IsChecked;
                customernew.LicenceEndDate = CWdate.SelectedDate.Value;

                alaKurumsalDatabase.SaveChanges();
                LoadCustomers();
                MessageBox.Show("Güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncellemek için bir müşteri seçmelisin!");
            }
        }

        private void CMsil_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = dgCustomers.SelectedItem as Customer;
            if (customer != null)
            {

                alaKurumsalDatabase.Customers.Remove(customer);
                alaKurumsalDatabase.SaveChanges();
                MessageBox.Show("Müşteri Silindi!");
                LoadCustomers();

            }
            else
            {
                MessageBox.Show("Silmek için bir araç seçmelisin!");
            }
        }

        private void CWekle_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = CWisim.Text;
            customer.Surname = CWsoyisim.Text;
            customer.Phone = CWtelefon.Text;
            customer.Age = int.Parse(CWyas.Text);
            customer.City = CWsehir.Text;
            customer.HasLicence = CWehliyet.IsChecked;
            customer.HasCriminalRecord = CWsabika.IsChecked;
            customer.LicenceEndDate = CWdate.SelectedDate.Value;



            alaKurumsalDatabase.Customers.Add(customer);

            alaKurumsalDatabase.SaveChanges();
            MessageBox.Show("Müşteri Kaydedildi.");

            CWisim.Text = "İsim";
            CWsoyisim.Text = "Soyisim";
            CWtelefon.Text = "Telefon";
            CWyas.Text = "Yaş";
            CWsehir.Text = "Şehir";
            CWehliyet.IsChecked = false;
            CWsabika.IsChecked = false;
            CWdate.SelectedDate = DateTime.Today;

           

            LoadCustomers();


        }
        private void LoadCustomers()
        {
            AlaKurumsalDatabase db = new AlaKurumsalDatabase();
            List<Customer> customers = db.Customers.ToList();
            dgCustomers.ItemsSource = customers;

        }

   
        private void CWAnaMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(loginUser);
            mainWindow.Show();
            this.Close();
        }

      

        private void CWwindowLoaded(object sender, RoutedEventArgs e)
        {
            LoadCustomers();
        }

        private void dgCustomers_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)
        {
            Customer customer = dgCustomers.SelectedItem as Customer;
            if (customer != null)
            {

                CWisim.Text = customer.Name;
                CWsoyisim.Text = customer.Surname;
                CWtelefon.Text = customer.Phone;
                CWyas.Text = customer.Age.ToString();
                CWsehir.Text = customer.City;
                CWehliyet.IsChecked = customer.HasLicence;
                CWsabika.IsChecked = customer.HasCriminalRecord;
                CWdate.SelectedDate = customer.LicenceEndDate;
            }
        }
    }
    
}

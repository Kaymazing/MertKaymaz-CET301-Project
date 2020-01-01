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
    /// PaymentWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class PaymentWindow : Window
    {
        private Owner loginUser;
        AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
        public PaymentWindow(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
            var booking = alaKurumsalDatabase.Bookings.ToList(); //OrderBy(d => d.Id).
            PWbooking.ItemsSource = booking;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPayments();
        }

        private void CWekle_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            payment.BookingNo = int.Parse(PWbooking.Text);
            payment.HasInstallment = PWtaksit.IsChecked;
            payment.InstallmentNumber = int.Parse(PWtaksitsayi.Text);
            payment.PaymentMethod = PWmethod.Text;
           


            alaKurumsalDatabase.Payments.Add(payment);


            alaKurumsalDatabase.SaveChanges();
            MessageBox.Show("Ödeme Kaydedildi.");

            PWbooking.Text = " ";
            PWtaksit.IsChecked = false;
            PWtaksitsayi.Text = " ";
            PWmethod.SelectedItem = " ";



            LoadPayments();
        }

        private void CMsil_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = dgPayment.SelectedItem as Payment;
            if (payment!= null)
            {

                alaKurumsalDatabase.Payments.Remove(payment);
                alaKurumsalDatabase.SaveChanges();
                MessageBox.Show("Ödeme Silindi!");
                LoadPayments();

            }
            else
            {
                MessageBox.Show("Silmek için bir ödeme seçmelisin!");
            }
        }

        private void CWguncelleexpand_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = dgPayment.SelectedItem as Payment;
            if (payment != null)
            {
                AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
                var paymentnew = alaKurumsalDatabase.Payments.Find(payment.Id);

                paymentnew.BookingNo = int.Parse(PWbooking.Text);
                paymentnew.HasInstallment = PWtaksit.IsChecked;
                paymentnew.InstallmentNumber = int.Parse(PWtaksitsayi.Text);
                paymentnew.PaymentMethod = PWmethod.Text;



                alaKurumsalDatabase.SaveChanges();
                LoadPayments();
                MessageBox.Show("Güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncellemek için bir ödeme seçmelisin!");
            }
        }

        private void CWAnaMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(loginUser);
            mainWindow.Show();
            this.Close();
        }
        private void LoadPayments()
        {
            AlaKurumsalDatabase db = new AlaKurumsalDatabase();
            List<Payment> payments = db.Payments.ToList();
            dgPayment.ItemsSource = payments;

        }

        private void dgPayment_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
           Payment payment = dgPayment.SelectedItem as Payment;
            if (payment != null)
            {
                PWbooking.Text = payment.BookingNo.ToString();
                PWmethod.Text= payment.PaymentMethod;
                PWtaksit.IsChecked = payment.HasInstallment;
                PWtaksitsayi.Text = payment.InstallmentNumber.ToString();
            

            }
        }
    }
}

using MertKaymaz_301Project.Data;
using Microsoft.EntityFrameworkCore;
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

namespace MertKaymaz_301Project
{
    /// <summary>
    /// BookingWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class BookingWindow : Window
    {
        private Owner loginUser;
        AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
        public BookingWindow(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
            var customers = alaKurumsalDatabase.Customers.OrderBy(d => d.Name).ToList();
            BWcustomer.ItemsSource = customers;
            var vehicles = alaKurumsalDatabase.Vehicles.OrderBy(d => d.ModelName).ToList();
            BWvehicle.ItemsSource = vehicles;
        }

        private void AnaMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(loginUser);
            mainWindow.Show();
            this.Close();
        }

        private void dgBooking_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            
            Booking booking = dgBooking.SelectedItem as Booking;
            if (booking != null)
            {

                BWcustomer.Text = booking.CustomerName;
                BWvehicle.Text = booking.VehicleModel;
                BWhire.Text = booking.HirePoint;
                BWdrop.Text = booking.DropPoint;
                BWbaslangic.SelectedDate = booking.StartDate;
                BWbitis.SelectedDate = booking.EndDate;
                BWsold.IsChecked = booking.IsSold;
              
            }
        }

        private void BWekle(object sender, RoutedEventArgs e)
        {
            Booking booking  = new Booking();
            booking.CustomerName = BWcustomer.Text;
            booking.VehicleModel = BWvehicle.Text;
            booking.HirePoint = BWhire.Text;
            booking.DropPoint = BWdrop.Text;
            booking.StartDate = BWbaslangic.SelectedDate.Value;
            booking.EndDate = BWbitis.SelectedDate.Value;
            booking.IsSold = BWsold.IsChecked;



            alaKurumsalDatabase.Bookings.Add(booking);

            alaKurumsalDatabase.SaveChanges();
            MessageBox.Show("Kiralama Kaydedildi.");

            BWcustomer.Text = " ";
            BWvehicle.Text = " ";
            BWhire.Text = " ";
            BWdrop.Text = " -";
            BWsold.IsChecked = false;

            

            LoadBookings();
        }

        private void BWsil(object sender, RoutedEventArgs e)
        {
            Booking booking = dgBooking.SelectedItem as Booking;
            if (booking != null)
            {

                alaKurumsalDatabase.Bookings.Remove(booking);
                alaKurumsalDatabase.SaveChanges();
                MessageBox.Show("Kiralama Silindi!");
                LoadBookings();

            }
            else
            {
                MessageBox.Show("Silmek için bir kiralama seçmelisin!");
            }
        }

        private void BWguncelle(object sender, RoutedEventArgs e)
        {
            Booking booking = dgBooking.SelectedItem as Booking;
            if (booking != null)
            {
                AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
                var bookingnew = alaKurumsalDatabase.Bookings.Find(booking.Id);

                bookingnew.CustomerName = BWcustomer.Text;
                bookingnew.VehicleModel = BWvehicle.Text;
                bookingnew.HirePoint = BWhire.Text;
                bookingnew.DropPoint = BWdrop.Text;
                bookingnew.StartDate = BWbaslangic.SelectedDate.Value;
                bookingnew.EndDate = BWbitis.SelectedDate.Value;
                bookingnew.IsSold = BWsold.IsChecked;

                alaKurumsalDatabase.SaveChanges();
                LoadBookings();
                MessageBox.Show("Güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncellemek için bir araç seçmelisin!");
            }
        }


        private void LoadBookings()
        {
            AlaKurumsalDatabase db = new AlaKurumsalDatabase();
            List<Booking> bookings = db.Bookings.ToList();
            dgBooking.ItemsSource = bookings;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBookings();
        }
    }
}

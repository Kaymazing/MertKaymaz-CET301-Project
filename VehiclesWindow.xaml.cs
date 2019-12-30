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
using MertKaymaz_301Project.Data;
using MertKaymaz_301Project.Service;

namespace MertKaymaz_301Project
{
    /// <summary>
    /// Araclar.xaml etkileşim mantığı
    /// </summary>
    public partial class Araclar : Window
    {
        private Owner loginUser;
        AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
        public Araclar(Owner owner)
        {
            loginUser = owner;
            InitializeComponent();
            var owners = alaKurumsalDatabase.Owners.OrderBy(d => d.Name).ToList();
            VWowner.ItemsSource = owners;
            
        }

        
        private void dgVehicles_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Vehicle vehicle = dgVehicles.SelectedItem as Vehicle;
            if (vehicle != null)
            {

                VWmodel.Text = vehicle.ModelName;
                VWbrand.Text = vehicle.BrandName;
                VWcolor.Text = vehicle.Color;
                VWcountry.Text = vehicle.Country;
                VWowner.Text = vehicle.Owner;
                VWyear.Text = vehicle.Year.ToString();
                VWdate.SelectedDate = vehicle.AvailableDate;
                VWavailable.IsChecked = vehicle.IsAvailable;
                VWcrashed.IsChecked = vehicle.IsCrashed;
                VWsold.IsChecked = vehicle.IsSold;
                VWrentable.IsChecked = vehicle.IsRentable;
                VWpreowned.IsChecked = vehicle.IsPreOwned;
                VWsale.IsChecked = vehicle.IsOnSale;
            }
        }

        private void LoadStudents()
        {
            AlaKurumsalDatabase db = new AlaKurumsalDatabase();
            List<Vehicle> vehicles = db.Vehicles.ToList();
            dgVehicles.ItemsSource = vehicles;
            
        }

  

        private void VehiclesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStudents();
        }

        private void AnaMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(loginUser);
            mainWindow.Show();
            this.Close();

        }

        private void AddUpdateDelete_Click(object sender, RoutedEventArgs e)
        {
            sparaclar.Visibility = Visibility.Visible;
        }

        private void VMekle(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.ModelName = VWmodel.Text;
            vehicle.BrandName = VWbrand.Text;
            vehicle.Color = VWcolor.Text;
            vehicle.Country = VWcountry.Text;
            vehicle.Owner = VWowner.Text;
            vehicle.Year = int.Parse(VWyear.Text);
            vehicle.IsAvailable = VWavailable.IsChecked;
            vehicle.IsCrashed = VWcrashed.IsChecked;
            vehicle.IsSold = VWsold.IsChecked;
            vehicle.IsRentable = VWrentable.IsChecked;
            vehicle.IsPreOwned = VWpreowned.IsChecked;
            vehicle.IsOnSale = VWsale.IsChecked;
            vehicle.AvailableDate = VWdate.SelectedDate.Value;



            alaKurumsalDatabase.Vehicles.Add(vehicle);

            alaKurumsalDatabase.SaveChanges();
            MessageBox.Show("Araç Kaydedildi.");

            VWmodel.Text = "Model";
            VWbrand.Text = "Marka";
            VWcolor.Text = "Renk";
            VWcountry.Text = "Ülke";
            VWowner.Text = "Sahibi";
            VWyear.Text = "Yılı";
            VWdate.SelectedDate = DateTime.Now;
            VWavailable.IsChecked = false;
            VWcrashed.IsChecked = false;
            VWsold.IsChecked = false;
            VWrentable.IsChecked = false;
            VWpreowned.IsChecked = false;
            VWsale.IsChecked = false;
          
            LoadStudents();


        }

        private void VWsil(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = dgVehicles.SelectedItem as Vehicle;
            if (vehicle != null)
            {

                alaKurumsalDatabase. Vehicles.Remove(vehicle);
                alaKurumsalDatabase.SaveChanges();
                MessageBox.Show("Araç Silindi!");
                LoadStudents();

            }
            else
            {
                MessageBox.Show("Silmek için bir araç seçmelisin!");
            }
        }

        private void VWguncelle(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = dgVehicles.SelectedItem as Vehicle;
            if (vehicle != null)
            {
                AlaKurumsalDatabase alaKurumsalDatabase = new AlaKurumsalDatabase();
                var vehiclenew = alaKurumsalDatabase.Vehicles.Find(vehicle.Id);
                
                vehiclenew.ModelName = VWmodel.Text;
                vehiclenew.BrandName = VWbrand.Text;
                vehiclenew.Color = VWcolor.Text;
                vehiclenew.Country = VWcountry.Text;
                vehiclenew.Owner = VWowner.Text;
                vehiclenew.Year = int.Parse(VWyear.Text);
                vehiclenew.IsAvailable = VWavailable.IsChecked;
                vehiclenew.IsCrashed = VWcrashed.IsChecked;
                vehiclenew.IsSold = VWsold.IsChecked;
                vehiclenew.IsRentable = VWrentable.IsChecked;
                vehiclenew.IsPreOwned = VWpreowned.IsChecked;
                vehiclenew.IsOnSale = VWsale.IsChecked;
                vehiclenew.AvailableDate = VWdate.SelectedDate.Value;

                alaKurumsalDatabase.SaveChanges();
                LoadStudents();
                MessageBox.Show("Güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncellemek için bir araç seçmelisin!");
            }
        }
    }
}

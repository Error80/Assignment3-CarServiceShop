using System;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3_CarServiceShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const double tax = 0.13;

        public const double engineOilChangePrice = 60;

        public const double transmissionOilChangePrice = 120;

        public const double airFilterChangePrice = 40.5;

        public int identificationNumber = 0;

        public int count = 0;

        private ObservableCollection<Service> services = new ObservableCollection<Service>();
        public MainWindow()
        {
            InitializeComponent();

            string[] carMakes =
                [
                "Audi", 
                "Bentley", 
                "BMW", 
                "BYD", 
                "Cadillac", 
                "Chervrolet", 
                "Chrysler", 
                "Dodge", 
                "Ford", 
                "Honda", 
                "Hyundai", 
                "Jaguar", 
                "Jeep", 
                "Kia", 
                "Lamborghini", 
                "Lexus", 
                "Mazda", 
                "Mercedes Benz", 
                "Nissan", 
                "Porsche", 
                "Ram", 
                "Subaru", 
                "Tesla", 
                "Toyota", 
                "Volkswagen"
                ];

            for (int index = 0; index < carMakes.Length; index++)
            {
                MakeComboBox.Items.Add(carMakes[index]);
            }

            for (int year = 2000; year < 2025; year++)
            {
                YearComboBox.Items.Add(year.ToString());
            }

            CarServiceSummaryListView.ItemsSource = services;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                // Get First Name from the text box
                string firstName = FirstNameTextBox.Text;

                // Get Last Name from the text box
                string lastName = LastNameTextBox.Text;

                // Get Phone Number from the text box
                long phoneNumber = long.Parse(PhoneNumberTextBox.Text);

                // Get Make from the dropdown menu or combo box
                string make = MakeComboBox.Text;

                string model = ModelTextBox.Text;

                string colour = ColourTextBox.Text;

                bool engineOilChange = EngineOilChangeCheckBox.IsChecked == true;

                bool transmissionOilChange = TransmissionOilChangeCheckBox.IsChecked == true;

                bool airFilterChange = AirFilterChangeCheckBox.IsChecked == true;

                double cost = 0;

                if (engineOilChange == true)
                {
                    cost += engineOilChangePrice + (engineOilChangePrice * tax);
                }

                if (transmissionOilChange == true)
                {
                    cost += transmissionOilChangePrice + (transmissionOilChangePrice * tax);
                }

                if (airFilterChange == true)
                {
                    cost += airFilterChangePrice + (airFilterChangePrice * tax);
                }

                double roundedCost = Math.Round(cost, 2);
                CostTextBox.Text = roundedCost.ToString();

                int year = int.Parse(YearComboBox.Text);

                count++;
                identificationNumber++;
                
                Service newService = new Service(count, identificationNumber, firstName, lastName, phoneNumber, make, model, year, colour, true, true, true, roundedCost);

                services.Add(newService);
            } catch
            {

            }

        }
    }
}
using System;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3_CarServiceShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Constants
        public const double tax = 0.13;
        public const double engineOilChangePrice = 60;
        public const double transmissionOilChangePrice = 120;
        public const double airFilterChangePrice = 40.5;

        // Global Varables
        public int identificationNumber = 0;
        public int count = 0;

        /// <summary>
        /// Method that clears the window
        /// </summary>
        private void ClearWindow()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            MakeComboBox.Text = "";
            ModelTextBox.Text = "";
            YearComboBox.Text = "";
            ColourTextBox.Text = "";
            EngineOilChangeCheckBox.IsChecked = false;
            TransmissionOilChangeCheckBox.IsChecked = false;
            AirFilterChangeCheckBox.IsChecked = false;
            CostTextBox.Text = "";
        }

        /// <summary>
        /// Adds to the cost depending on what check 
        /// </summary>
        /// <param name="service"></param>
        /// <param name="price"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        private static double AddCost(bool service, double price)
        {
            double cost = 0;

            // Checks if the corrisponding checkbox is checked
            if (service == true) 
            {

                //c = p
                cost = price;

            }

            return cost;
        }

        // Initalizes a collection linked to the services object
        private ObservableCollection<Service> services = new ObservableCollection<Service>();
        public MainWindow()
        {
            InitializeComponent();

            // Array of Car Makes
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

            // Adds Makes to the Make Combo box
            for (int index = 0; index < carMakes.Length; index++)
            {
                MakeComboBox.Items.Add(carMakes[index]);
            }

            // Adds Years 1980 - 2024 to the Years Combo box
            for (int year = 1980; year < 2025; year++)
            {
                YearComboBox.Items.Add(year.ToString());
            }

            CarServiceSummaryListView.ItemsSource = services;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Determines which button got clicked
                Button clickedButton = sender as Button;

                // Gets the name of the button
                string buttonName = clickedButton.Name;

                // Get text from the First Name Text box
                string firstName = FirstNameTextBox.Text;

                // Get text from the Last Name Text box
                string lastName = LastNameTextBox.Text;

                // Get text from the Phone Number Text box and convert it to long
                long phoneNumber = long.Parse(PhoneNumberTextBox.Text);

                // Get chosen item from the Make dropdown menu or combo box
                string make = MakeComboBox.Text;

                // Get text from the Model Text box
                string model = ModelTextBox.Text;

                // Get text from the Year Combo Box
                int year = int.Parse(YearComboBox.Text);

                // Get chosen item from the Year dropdown menu or combo box
                string colour = ColourTextBox.Text;

                // Check if the Engine Oil Change is Checked
                bool engineOilChange = EngineOilChangeCheckBox.IsChecked == true;

                // Check if the Transmission Oil Change is Checked
                bool transmissionOilChange = TransmissionOilChangeCheckBox.IsChecked == true;

                // Check if the Air Filter Change is Checked
                bool airFilterChange = AirFilterChangeCheckBox.IsChecked == true;

                // Initialize the cost varable
                double cost = 
                    AddCost(engineOilChange, engineOilChangePrice) +
                    AddCost(transmissionOilChange, transmissionOilChangePrice) +
                    AddCost(airFilterChange, airFilterChangePrice);

                // Adds the HST
                double finalCost = cost + (cost * tax);

                // Round the cost to the nearest hundreth
                double roundedCost = Math.Round(finalCost, 2);

                // Set the cost depending on what services was checked
                CostTextBox.Text = "$" + roundedCost.ToString();

                // Incrament identificationNumber by 1
                identificationNumber++;

                if (buttonName == "UpdateButton")
                {

                    // Initalize a new Service Object
                    Service updateService = new Service(CarServiceSummaryListView.SelectedIndex + 1, identificationNumber, firstName, lastName, phoneNumber, make, model, year, colour, true, true, true, roundedCost);


                    // Try to replace the selected comlum in the list view
                    try
                    {
                        services.Insert(CarServiceSummaryListView.SelectedIndex + 1, updateService);
                        services.RemoveAt(CarServiceSummaryListView.SelectedIndex);

                    } 
                    
                    // If no item is selected
                    catch
                    {
                        services.RemoveAt(0);

                        // Show Error Message
                        MessageBox.Show("Please select an item from the table", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    }

                } 
                else
                {
                    // Incrament count by 1
                    count++;

                    // Initalize a new Service Object
                    Service newService = new Service(count, identificationNumber, firstName, lastName, phoneNumber, make, model, year, colour, true, true, true, roundedCost);

                    // Add newService to the Serives list view
                    services.Add(newService);
                }


            }

            // If Validation fails
            catch (Exception error) 
            {

                // Show Error Message
                MessageBox.Show(error.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            // Clears all inputs
            ClearWindow();
        }

        private void RemoveAllButton_Click(object sender, RoutedEventArgs e)
        {
            // Emptys the services list view
            services.Clear();

            // Clears all inputs
            ClearWindow();
            count = 0;
            identificationNumber = 0;
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Removes seleted item from the services list view
                services.RemoveAt(CarServiceSummaryListView.SelectedIndex);
                count--;
            } catch {

                // Show Error Message
                MessageBox.Show("Please select an item from the table", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Close the program
            Close();
        }

        private void CarServiceSummaryListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
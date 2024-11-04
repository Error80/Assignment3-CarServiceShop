using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CarServiceShop
{
    public class Service
    {

        // Count Property
        private int Count;

        // Gets the value of the Count Property
        public int GetCount
        {
            get { return Count; }

            // Checks if the value is negative
            set
            {
                if (value <= -1)
                    throw new ArgumentException("Please select an item from the table");
                Count = value;

            }
        }

        // Identification Property
        private int IdentificationNumber;

        // Gets the value of the Identification Property
        public int GetIdentificationNumber
        {
            get { return IdentificationNumber; }

            // Checks if the value is negative
            set
            {
                IdentificationNumber = value;
                if (value <= 0)
                    throw new ArgumentException("IdentificationNumber cannot be negative");

            }
        }

        // First Name Property
        private string FirstName;


        // Gets the value of the First Name Property
        public string GetFirstName
        {
            get { return FirstName; }

            // Checks if the value is empty
            set
            {
                FirstName = value;
                if (String.IsNullOrEmpty(FirstName))
                    throw new ArgumentException("First Name Cannot be empty");
            }
        }

        // Last Name Property
        private string LastName;

        // Gets the value of the Last Name Property
        public string GetLastName
        {
            get { return LastName; }

            // Checks if the value is empty
            set
            {
                LastName = value;
                if (String.IsNullOrEmpty(LastName))
                    throw new ArgumentException("Last Name Cannot be empty");
            }
        }

        // Phone Number Property
        private long PhoneNumber;

        // Gets the value of the Phone Number Property
        public long GetPhoneNumber
        {
            get { return PhoneNumber; }

            // Checks if the value is between 1000000000 and 9999999999
            set
            {
                PhoneNumber = value;
                if (value < 1000000000 || value > 9999999999)
                    throw new ArgumentException("Phone number must be a ten digit number");

            }
        }

        // Make Property
        private string Make;

        // Gets the value of the Make Property
        public string GetMake
        {
            get { return Make; }

            // Checks if the value is empty
            set
            {
                Make = value;
                if (String.IsNullOrEmpty(Make))
                    throw new ArgumentException("Make cannot be empty");
            }
        }

        // Model Property
        private string Model;

        // Gets the value of the Model Property
        public string GetModel
        {
            get { return Model; }

            // Checks if the value is empty
            set
            {
                Model = value;
                if (String.IsNullOrEmpty(Model))
                    throw new ArgumentException("Model Cannot be empty");
            }
        }

        // Year Property
        private int Year;

        // Gets the value of the Year Property
        public int GetYear
        {
            get { return Year; }

            // Checks if the value is negative
            set
            {
                Year = value;
                if (value <= 0)
                    throw new ArgumentException("Year cannot be negative");

            }
        }

        // Colour Property
        private string Colour;

        // Gets the value of the Colour Property
        public string GetColour
        {
            get { return Colour; }

            // Checks if the value is empty
            set
            {
                Colour = value;
                if (String.IsNullOrEmpty(Colour))
                    throw new ArgumentException("Colour cannot be empty");
            }
        }

        // Engine Oil Change Property
        private bool EngOilChange
        {
            get;
            set;
        }

        // Transmission Oil Property
        private bool TransOilChange
        {
            get;
            set;
        }

        // Air Filter Property
        private bool AirFilterChange
        {
            get;
            set;
        }

        // Price Property
        private double Price;

        // Gets the value of the Price Property
        private double GetPrice
        {
            get { return Price; }

            // Checks if the value is negative
            set
            {
                Price = value;
                if (value <= 0)
                    throw new ArgumentException("Price cannot be negative");

            }
        }

        /// <summary>
        /// Service Object
        /// </summary>
        /// <param name="count"></param>
        /// <param name="identificationNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="colour"></param>
        /// <param name="engOilChange"></param>
        /// <param name="transOilChange"></param>
        /// <param name="airFilterChange"></param>
        /// <param name="price"></param>
        public Service (
            int count,
            int identificationNumber, 
            string firstName, 
            string lastName, 
            long phoneNumber, 
            string make, 
            string model, 
            int year, 
            string colour, 
            bool engOilChange,
            bool transOilChange,
            bool airFilterChange,
            double price)
        {
            GetCount = count;
            GetIdentificationNumber = identificationNumber;
            GetFirstName = firstName;
            GetLastName = lastName;
            GetPhoneNumber = phoneNumber;
            GetMake = make;
            GetModel = model;
            GetYear = year;
            GetColour = colour;
            EngOilChange = engOilChange;
            TransOilChange = transOilChange;
            AirFilterChange = airFilterChange;
            Price = price;
        }
    }
}

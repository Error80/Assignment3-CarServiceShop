using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CarServiceShop
{
    //public class Service
    //{
    //    private int Count 
    //    { 
    //        get; 
    //        set; 
    //    }
    //    private int IdentificationNumber
    //    {
    //        get;
    //        set;
    //    }

    //    private string FirstName
    //    {
    //        get;
    //        set;
    //    }

    //    private string LastName
    //    {
    //        get;
    //        set;
    //    }

    //    private int PhoneNumber
    //    {
    //        get;
    //        set;
    //    }
    //    private string Make
    //    {
    //        get;
    //        set;
    //    }

    //    private string Model
    //    {
    //        get;
    //        set;
    //    }

    //    private string Colour
    //    {
    //        get;
    //        set;
    //    }

    //    private int Year
    //    { 
    //        get;
    //        set;
    //    }

    //    private bool EngOilChange
    //    {
    //        get;
    //        set;
    //    }

    //    private bool TransOilChange
    //    {
    //        get;
    //        set;
    //    }

    //    private bool AirFilterChange
    //    {
    //        get;
    //        set;
    //    }

    //    private double Price
    //    {
    //        get;
    //        set;
    //    }

    //    public Service(int identificationNumber, string firstName, string lastName, int phoneNumber, string make, string model, string colour, int year, bool engOilChange, bool transOilChange, bool airFilterChange, double price)
    //    {
    //        IdentificationNumber = identificationNumber;
    //        FirstName = firstName;
    //        LastName = lastName;
    //        PhoneNumber = phoneNumber;
    //        Make = make;
    //        Model = model;
    //        Colour = colour;
    //        Year = year;
    //        EngOilChange = engOilChange;
    //        TransOilChange = transOilChange;
    //        AirFilterChange = airFilterChange;
    //        Price = price;
    //    }

    //delete below

    //}

    public class Service
    {
        private int Count;

        public int GetCount
        {
            //
            get { return Count; }

            //
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Count cannot be negative");
                Count = value;

            }
        }

        private int IdentificationNumber;

        public int GetIdentificationNumber
        {
            //
            get { return IdentificationNumber; }

            //
            set
            {
                if (value <= 0)
                    throw new ArgumentException("IdentificationNumber cannot be negative");
                IdentificationNumber = value;

            }
        }

        private string FirstName;

        public string GetFirstName
        {
            get { return FirstName; }

            set
            {
                if (FirstName == "")
                    throw new ArgumentException("First Name Cannot be empty");
                FirstName = value;
            }
        }

        private string LastName;

        public string GetLastName
        {
            get { return LastName; }

            set
            {
                if (LastName == "")
                    throw new ArgumentException("Last Name Cannot be empty");
                LastName = value;
            }
        }

        private long PhoneNumber { get; set; }

        public long GetPhoneNumber
        {
            //
            get { return PhoneNumber; }

            //
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Phone number cannot be negative");
                PhoneNumber = value;

            }
        }

        private string Make;
        public string GetMake
        {
            get { return Make; }

            set
            {
                if (Make == "")
                    throw new ArgumentException("Make cannot be empty");
                Make = value;
            }
        }


        private string Model;

        public string GetModel
        {
            get { return Model; }

            set
            {
                if (Model == "")
                    throw new ArgumentException("Model Cannot be empty");
                Model = value;
            }
        }


        private int Year;

        public int GetYear
        {
            //
            get { return Year; }

            //
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Year cannot be negative");
                Year = value;

            }
        }

        private string Colour;
        public string GetColour
        {
            get { return Colour; }

            set
            {
                if (Colour == "")
                    throw new ArgumentException("Colour cannot be empty");
                Colour = value;
            }
        }
        private bool EngOilChange
        {
            get;
            set;
        }

        private bool TransOilChange
        {
            get;
            set;
        }

        private bool AirFilterChange
        {
            get;
            set;
        }

        private double Price;

        private double GetPrice
        {
            //
            get { return Price; }

            //
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price cannot be negative");
                Price = value;

            }
        }

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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class Customer
    {
        #region Fields
        private int _customerID;
        private String _userName;
        private String _password;
        private String _lastName;
        private String _firstName;
        private String _address;
        private String _city;
        private String _stateProvince;
        private String _zip;
        private String _email;
        #endregion


        #region Properties
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        public String StateProvince
        {
            get { return _stateProvince; }
            set { _stateProvince = value; }
        }
        public String Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }
        #endregion


        #region Constructors
        public Customer()
        {

        }
        #endregion
    }
}
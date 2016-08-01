// SID: 1335894
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    public class Person
    {
        private string fullName;
        private string phoneNumber;
        private string emailAddress;
        private string postalAddress;
        private string birthDay;


        /// <summary>
        /// A default contructor for a person class
        /// </summary>
        public Person()
        {
        }
        

        /// <summary>
        /// full name of contact
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        /// <summary>
        /// phone number (mobile or landline) of contact
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// E-mail address of contact
        /// </summary>
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        /// <summary>
        /// postal address of contact
        /// </summary>
        public string PostalAddress
        {
            get { return postalAddress; }
            set { postalAddress = value; }
        }

        /// <summary>
        /// birthday of contact
        /// </summary>
        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
    }
}

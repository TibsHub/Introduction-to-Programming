// SID: 1335894
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_2
{
    public class Contact : Person
    {

        # region constructors

        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailAddress"></param>
        /// <param name="postalAddress"></param>
        /// <param name="birthDay"></param>
        public Contact(string fullName, string phoneNumber, string emailAddress, string postalAddress, string birthDay)
        {
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress= emailAddress;
            this.PostalAddress = postalAddress;
            this.BirthDay = birthDay;
        }


        /// <summary>
        /// default constructor
        /// </summary>
        public Contact()
            : this("", "", "", "", "")
        {
        }
        
                
        /// <summary>
        /// Use me to get the attributes out of a string
        /// </summary>
        /// <param name="lineOfFile">the string to chop up</param>
        public Contact(string lineOfFile)
        {
            // 1 line read in
            string line = lineOfFile;
            //split the line of data by comma delimiter
            string[] lineSplit = line.Split(',');

            try
            {
                FullName = lineSplit[0].Trim();
                PhoneNumber = lineSplit[1].Trim();
                EmailAddress = lineSplit[2].Trim();
                PostalAddress = lineSplit[3].Trim();
                BirthDay = lineSplit[4].Trim();
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }
        
        #endregion

        
        /// <summary>
        /// All the details about a contact with commas + space separating the items
        /// </summary>
        /// <returns>what you need to append to your list</returns>
        public string WriteToList()
        {
            return FullName + ", " + PhoneNumber + ", " + EmailAddress + ", " + PostalAddress + ", " + BirthDay;// +"#"; 
        }

    }
}

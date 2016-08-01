// SID: 1335894
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        // create list that'll be used throughout
        public static List<string> listItems = new List<string>();
        

        // main form
        public Form1()
        {
            InitializeComponent();

            //load content of data file
            Storage.loadDataFromFile(Storage.filePathToFileToUse);

            reloadList();
        }


        #region Buttons

        /// <summary>
        /// Add button --- add contents of textboxes to list
        /// Need at least Name and one other field to be successful
        /// </summary>
        private void button_AddContact_Click(object sender, EventArgs e)
        {
            Contact xyz = new Contact();

            if (commaFoundInFields() == false)
            {
                xyz.FullName = txtBx_Name.Text;
                xyz.PhoneNumber = txtBx_PhoneNumber.Text;
                xyz.EmailAddress = txtBx_EmailAddress.Text;
                xyz.PostalAddress = txtBx_PostalAddress.Text;
                xyz.BirthDay = txtBx_Birthday.Text;

                if (txtBx_Name.Text != "")
                //&&
                //((txtBx_PhoneNumber.Text != "") | (txtBx_EmailAddress.Text != "") | (txtBx_PostalAddress.Text != "") | (txtBx_Birthday.Text != "")))
                {
                    listItems.Add(xyz.WriteToList());
                }
                else
                {
                    MessageBox.Show("Need at least a name!");
                }
            }
            else
            {
                MessageBox.Show("Please do not use comma in fields!");
            }
       

            reloadList();

            // confirmation box popping up after successfully adding new contact
            //MessageBox.Show(xyz.FullName +
            //    ",\n" + xyz.PhoneNumber +
            //    ",\n" + xyz.EmailAddress +
            //    ",\n" + xyz.PostalAddress +
            //    ",\n" + xyz.BirthDay + "\n added.");
        }

       
        /// <summary>
        /// Remove button --- delete the contact that is currently highlighted in the listbox
        /// </summary>
        private void button_RemoveContact_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure?", "Remove Contact", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    listItems.RemoveAt(listBoxContent.SelectedIndex);
                    //Confirmation box
                    MessageBox.Show("Contact has been removed.");
                }
            }
            catch (Exception) // irrelevant due to button disabled if no selection
            {
                MessageBox.Show("First select row to remove!"); 
            }
                                    
            reloadList();

            // no selection ---> disable Edit/Remove buttons
            button_EditContact.Enabled = false;
            button_RemoveContact.Enabled = false;
        }
        

        /// <summary>
        /// Edit/Update button - update whatever is there
        /// </summary>
        private void button_EditContact_Click(object sender, EventArgs e)
        {
            if (commaFoundInFields() == false)
            {

                try
                {
                    // index of location
                    int locationToEdit = listBoxContent.SelectedIndex;
                    // delete current content
                    listItems.RemoveAt(locationToEdit);
                    // inject new data
                    listItems.Insert(locationToEdit, txtBx_Name.Text + ", " + txtBx_PhoneNumber.Text + ", " + txtBx_EmailAddress.Text + ", " + txtBx_PostalAddress.Text + ", " + txtBx_Birthday.Text);

                    reloadList();
                }
                catch (Exception) // irrelevant due to button disabled if no selection
                {
                    MessageBox.Show("Need to select a record to update first...");
                }
            }
            else
            {
                MessageBox.Show("Please do not use comma in fields!");
            }

            // no selection ---> disable Edit/Remove buttons
            //button_EditContact.Enabled = false;
            //button_RemoveContact.Enabled = false;
        }

        
        /// <summary>
        /// Search button --- search for attribute
        /// 
        /// Priority gets lowered from top to bottom
        /// Empty fields are skipped
        ///
        ///      Name (default)
        /// then Number
        /// then Email
        /// then Address
        /// then Birthday
        /// </summary>
        private void button_SearchContact_Click(object sender, EventArgs e)
        {
            
            string searchForWhat; // contents of textboxes will go in these
            string searchWhichField; // equals f_name, f_number, f_email, f_address, f_bday


            if (txtBx_Name.Text != "")
            {
                // what to look for
                searchForWhat = txtBx_Name.Text;
                // where to look for it
                searchWhichField = "name";

                searchWithAgainMsgBx(searchForWhat, searchWhichField);

                // Simple query
                // looks for the first occurrence
                //
                // string searchPattern = txtBx_Name.Text;
                //listBoxContent.SelectedIndex = listBoxContent.FindString(searchPattern, 0);
            }
            
            else if (txtBx_PhoneNumber.Text != "")
            {
                // what to look for
                searchForWhat = txtBx_PhoneNumber.Text;
                // where to look for it
                searchWhichField = "number";

                searchWithAgainMsgBx(searchForWhat, searchWhichField);

                // Simple query
                //listBoxContent.SelectedIndex = listBoxContent.FindString(txtBx_PhoneNumber.Text, 0);
            }

            else if (txtBx_EmailAddress.Text != "")
            {
                // what to look for
                searchForWhat = txtBx_EmailAddress.Text;
                // where to look for it
                searchWhichField = "email";

                searchWithAgainMsgBx(searchForWhat, searchWhichField);

                // Simple query
                //listBoxContent.SelectedIndex = listBoxContent.FindString(txtBx_EmailAddress.Text, 0);
            }

            else if (txtBx_PostalAddress.Text != "")
            {
                // what to look for
                searchForWhat = txtBx_PostalAddress.Text;
                // where to look for it
                searchWhichField = "address";

                searchWithAgainMsgBx(searchForWhat, searchWhichField);

                // Simple query
                //listBoxContent.SelectedIndex = listBoxContent.FindString(txtBx_PostalAddress.Text, 0);
            }
            else if (txtBx_Birthday.Text != "")
            {
                // what to look for
                searchForWhat = txtBx_Birthday.Text;
                // where to look for it
                searchWhichField = "bday";

                searchWithAgainMsgBx(searchForWhat, searchWhichField);

                // Simple query
                //listBoxContent.SelectedIndex = listBoxContent.FindString(txtBx_Birthday.Text, 0);
            }
            else
            {
                MessageBox.Show("Need to fill in at least one of the boxes!");
            }
        }

                
        /// <summary>
        /// Clear button - clear the contents of textboxes
        /// Disable Edit button
        /// </summary>
        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
            button_EditContact.Enabled = false;
        }


        /// <summary>
        /// Quit button
        /// </summary>
        private void button_Quit_Click(object sender, EventArgs e)
        {
            // Save content to file before quitting
            Storage.saveDataToFile(Storage.filePathToFileToUse);
            
            Application.Exit();
        }

        #endregion


        #region Menustrip
        /*
        //open option from menu
        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage.LoadDataFromFile(Storage.filePathToFileToUse);
            ReloadList();
        }

        // save option from menu
        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage.SaveDataToFile(Storage.filePathToFileToUse);
            ReloadList();
        }
        */
        #endregion

        
        #region Tools

        /// <summary>
        /// Clear content of textboxes
        /// </summary>
        public void clearFields()
        { 
            txtBx_Name.ResetText();
            txtBx_PhoneNumber.ResetText();
            txtBx_EmailAddress.ResetText();
            txtBx_PostalAddress.ResetText();
            txtBx_Birthday.ResetText();
        }
        

        /// <summary>
        /// Comma is not allowed in data entry as it is our delimiter for the fields
        /// Checks all input fields and pops message if comma is found
        /// </summary>
        public bool commaFoundInFields()
        {
            bool commaFound = false;

            if (
                (txtBx_Name.Text.Contains(",")) || (txtBx_PhoneNumber.Text.Contains(",")) ||
                (txtBx_EmailAddress.Text.Contains(",")) || (txtBx_PostalAddress.Text.Contains(",")) ||
                (txtBx_Birthday.Text.Contains(",")))
            {
                commaFound = true;
                //MessageBox.Show("Please do not use comma in fields!");
            }

            return commaFound;
        }

        
        /// <summary>
        /// Extract data from a formatted line
        /// </summary>
        public void getDetailsFromALine()
        { 
            try
            {
                string line = listBoxContent.SelectedItem.ToString();
                string[] contents = line.Split(',');

                txtBx_Name.Text = contents[0].Trim();
                txtBx_PhoneNumber.Text = contents[1].Trim();
                txtBx_EmailAddress.Text = contents[2].Trim();
                txtBx_PostalAddress.Text = contents[3].Trim();
                txtBx_Birthday.Text = contents[4].Trim();
            }
            //will not show error
            catch (Exception)
            { }
        }


        /// <summary>
        /// One click on listBox enables Remove button (Edit stays disabled)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxContent_MouseClick(object sender, MouseEventArgs e)
        {
            txtBxRowsCurrent.Text = Convert.ToString(listBoxContent.SelectedIndex + 1);
            
            //if no rows --> disable Remove/Edit buttons
            button_EditContact.Enabled = false;

            if (listItems.Count == 0)
            {
                button_RemoveContact.Enabled = false; 
            }
            else
            {
                button_RemoveContact.Enabled = true; 
            }
        }

        
        /// <summary>
        /// Double-clicking row of listbox:
        /// - copies details into textboxes
        /// - updates last selected textbox number
        /// - enables Edit button
        /// </summary>
        private void listBoxContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getDetailsFromALine();

            txtBxRowsCurrent.Text = Convert.ToString(listBoxContent.SelectedIndex + 1);

            // if no rows ---> disable Remove/Edit buttons
            if (listItems.Count > 0 )
            {
                button_EditContact.Enabled = true;
                button_RemoveContact.Enabled = true;
            }
        }


        /// <summary>
        /// Whenever list on screen is updated this will clear fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFields();
        }


        /// <summary>
        /// Method to reload the listbox's data file
        /// + Updates count of items
        /// + Disables Edit and Remove buttons
        /// + Disables Search if no contacts
        /// </summary>
        public void reloadList()
        {
            listBoxContent.DataSource = null;
            // data source for listbox
            listBoxContent.DataSource = listItems;
            
            txtBxRowsTotal.Text = Convert.ToString(listItems.Count);
            
            // Disables Remove/Edit buttons
            button_EditContact.Enabled = false;
            button_RemoveContact.Enabled = false;

            // if no items disable search too
            if (listItems.Count <= 3)
            {
                button_SearchContact.Enabled = false;
            }
            else
            { button_SearchContact.Enabled = true; }
        }

                       
        /// <summary>
        /// Search function of Form
        /// </summary>
        /// <param name="lineOfFile">a line of string going in to be processed</param>
        /// <param name="lookingForThis">what we are looking for</param>
        /// <param name="lookingForThisHere">name of the field (name/number/email/address/bday)</param>
        /// <returns></returns>
        public bool searchFunction(string lineOfFile, string lookingForThis, string lookingForThisHere)
        {
            // we'll return the value of this
            bool lineContains = false;

            //
            // the index of the line just received
            // int lineIndex = whichLineIsIt;
            //

            // Here is the line
            string line = lineOfFile;
            // we split up to words
            string[] lineSplit = line.Split(',');
            // and name the parts for what they represent about this contact
            string f_name = lineSplit[0].Trim();
            string f_number = lineSplit[1].Trim();
            string f_email = lineSplit[2].Trim();
            string f_address = lineSplit[3].Trim();
            string f_bday = lineSplit[4].Trim();

            // depending on where we look for
            string lookingForWhatWhere = lookingForThisHere;
            // what we are looking for
            string lookingForWhat = lookingForThis;
            
            // we`ll start if statements to direct the method to what we wanna do
            switch (lookingForWhatWhere)
            {
                case "name":
                    if (f_name.Contains(lookingForWhat) == true) { lineContains = true; }
                    break;
                case "number":
                    if (f_number.Contains(lookingForWhat) == true) { lineContains = true; }
                    break;
                case "email":
                    if (f_email.Contains(lookingForWhat) == true) { lineContains = true; }
                    break;
                case "address":
                    if (f_address.Contains(lookingForWhat) == true) { lineContains = true; }
                    break;
                case "bday":
                    if (f_bday.Contains(lookingForWhat) == true) { lineContains = true; }
                    break;
            }

            return lineContains;
        }


        /// <summary>
        /// Search button --- main caller
        /// Passing parameters to Search Function method
        /// </summary>
        /// <param name="searchForWhat"></param>
        /// <param name="searchWhichField"></param>
        public void searchWithAgainMsgBx(string searchForWhat, string searchWhichField)
        {
            for (int i = 0; i < listItems.Count; i++)
            {
                if (searchFunction(listItems[i], searchForWhat, searchWhichField) == true)
                {
                    listBoxContent.SelectedIndex = i;

                    int hereItIsNumberHuman = i + 1;
                    string messageToConv = Convert.ToString(hereItIsNumberHuman);
                    string message = "Found a record matching the search criteria!";// +hereItIsNumberHuman;

                    MessageBox.Show(message);

                    var result = MessageBox.Show("Should I try to find another one?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        break;
                    }
                }
                if (searchFunction(listItems[i], searchForWhat, searchWhichField) == false)
                {
                    clearFields();
                }
               
            }
        }

        #endregion
    }
}

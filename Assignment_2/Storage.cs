// SID: 1335894
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Assignment_2
{
    static class Storage
    {
        /// <summary>
        /// String containing the path to the file we use
        /// By default storage location is program directory
        /// </summary>
        public static string filePathToFileToUse = "MyPhoneBookContent.txt";
        
        /// <summary>
        /// Loads: content of file > to 'listItems'
        /// </summary>
        /// <param name="fileIsHere">the path to the file</param>
        public static void loadDataFromFile(string fileIsHere)
        {
            filePathToFileToUse = fileIsHere;
            StreamReader reader = new StreamReader(filePathToFileToUse);

            while (!reader.EndOfStream)
            {
                string lineOfFile = reader.ReadLine();
                
                //MessageBox.Show(lineOfFile);

                new Contact(lineOfFile);
                Form1.listItems.Add(lineOfFile);
            }
            reader.Close();
        }

        /// <summary>
        /// Saves: content of 'listItems > to file
        /// </summary>
        /// <param name="fileIsHere">the path to the file</param>
        public static void saveDataToFile(string fileIsHere)
        {
            filePathToFileToUse = fileIsHere;
            StreamWriter writer = new StreamWriter(filePathToFileToUse);

            for (int i = 0; i < Form1.listItems.Count; i++)
            {
                writer.WriteLine(Form1.listItems[i].ToString());
                //MessageBox.Show(Form1.listItems[i].ToString());
            }
            writer.Close();
        }

    }
}

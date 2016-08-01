// Anglia Ruskin University, Cambridge
// SID: 1335894 @ 07/11/2013

using System;
class PhoneBook
    {
        public static void Main()
        {
            // Declaring variables
            string menuPoint; // used to get menu choice
            string haveAnOtherGo;
            int recordToUpdate; // user`s interpretation of record numbers
            int maxIndex = 0;

            int phoneBookIndex;
            string[] phoneBook = new string[40]; // Our records from 0 to 39: first 20 for names, second 20 for numbers belonging to those names


        /* ================================================================================================================================================================ */


            // Greetings, general information
            Console.WriteLine("Basics");
            Console.WriteLine("======");
            Console.WriteLine("- Use number keys to navigate your way through the menu.\n  After selection press Enter to continue.");
            Console.WriteLine("- To answer questions: number 1 means `Yes`, any other key equals `No`.");
            Console.WriteLine("- You can store up to 20 names with phone numbers.");
            Console.WriteLine("- If the phonebook becomes full you will not be able to add new record(s).");
            Console.WriteLine("- If the phonebook is empty you will not be able to remove record(s).");
            Console.WriteLine("\nPlease press Enter to continue to the main program!");
            Console.ReadLine();


        /* ================================================================================================================================================================ */

                
                do // the following at least once while option 1, 2 or 3 is chosen
                {
                    // Menu
                    Console.Clear(); 
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("---------");
                    Console.WriteLine("Key 1: Add Record");
                    Console.WriteLine("Key 2: Remove record");
                    Console.WriteLine("Key 3: Print book");
                    Console.WriteLine("\nAnything else: Exit program");
                    menuPoint = Convert.ToString(Console.ReadLine());
                    Console.Clear();


        /* ================================================================================================================================================================ */
// Menu framework

                    
                    switch (menuPoint)
                    {
                        
                        
                        
// Add new record(s)
                        case "1": 

                            // Check for number of empty slots (in case of deletions)
                            for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                            {
                                if (phoneBook[phoneBookIndex] == null)
                                {
                                    maxIndex++;
                                }
                            }

                            // If there is room in the phonebook
                            if (maxIndex > 0)
                            {
                                do
                                {
                                    Console.WriteLine("Add Record\n");
                                    Console.WriteLine("Phonebook Contents\n------------------");
                                    maxIndex = 0; // used to exit adding to phonebook once it is full

                                    // List empty records and keep count of the number of them
                                    for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                                    {
                                        if (phoneBook[phoneBookIndex] == null)
                                        {
                                            Console.WriteLine("Record " + (phoneBookIndex + 1) + " is empty...");
                                            maxIndex++;
                                        }
                                    }

                                    Console.WriteLine("\nType number of empty record you would like to use and press Enter to continue.");
                                    Console.WriteLine("Choosing a number not on this list will overwrite an existing record!");
                                    recordToUpdate = Convert.ToInt32(Console.ReadLine());   // Number of record user wants to update
                                    
                                    // ! Program will crash here if input is not a number or empty; this applies to the same statement inside the loop following up
                                    
                                    while (recordToUpdate < 1 || recordToUpdate > 20) // Check if it is within our of range 0-19 | 1-20 (users perspective)
                                    {
                                        Console.WriteLine("Records are numbered from 1 to 20!\nPlease type a new, correct number!");
                                        recordToUpdate = Convert.ToInt32(Console.ReadLine());
                                    }

                                    phoneBookIndex = recordToUpdate - 1;                    // Computer`s interpretation of the same

                                    Console.WriteLine("Type name and press Enter:");
                                    phoneBook[phoneBookIndex] = Console.ReadLine(); // Add name
                                    Console.WriteLine("Type number and press Enter:");
                                    phoneBook[phoneBookIndex + 20] = Console.ReadLine(); // Add number

                                    // Check number of existing records again (in case any of them was overwritten)
                                    maxIndex = 0;
                                    for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                                    {
                                        if (phoneBook[phoneBookIndex] == null)
                                        {
                                            maxIndex++;
                                        }
                                    }

                                    // Ask for another addition IF there is at least 1 empty slot remaining, Exit otherwise
                                    if (maxIndex > 0)
                                    {
                                        Console.WriteLine("Would you like to add more?\nYes: type number 1 - No: any other key");
                                        haveAnOtherGo = Convert.ToString(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Phonebook is full!");
                                        Console.WriteLine("Please press Enter to continue...");
                                        Console.ReadLine();
                                        haveAnOtherGo = "0";
                                    }

                                }
                                while (haveAnOtherGo == "1" && (maxIndex > 0)); // If user chose to fill another empty (IF) record
                            }

                            // If there is no room in the phonebook
                            else
                            {
                                Console.WriteLine("Phonebook is full!");
                                Console.WriteLine("Please press Enter to continue...");
                                Console.ReadLine();
                            }
                            break;



                        /* ================================================================================================================================================================ */
                        
                        
                        
// Remove record(s)
                        case "2":
                            
                            // Check exact number of empty records
                            maxIndex = 0;
                            for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                            {
                                if (phoneBook[phoneBookIndex] == null)
                                {
                                    maxIndex++;
                                }
                            }

                            // If phonebook has records left to delete
                            if (maxIndex != 20)
                            {
                                do
                                {

                                    Console.Clear();
                                    Console.WriteLine("Remove Record(s)\n");
                                    Console.WriteLine("Phonebook Contents\n------------------");

                                    // List records with content
                                    for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                                    {
                                        if (phoneBook[phoneBookIndex] != null)
                                        {
                                            Console.WriteLine("Record " + (phoneBookIndex + 1) + ": " + phoneBook[phoneBookIndex] + " " + phoneBook[phoneBookIndex + 20]);
                                        }
                                    }

                                    Console.WriteLine("\nType number of the record you would like to delete and press Enter!");
                                    recordToUpdate = Convert.ToInt32(Console.ReadLine());
                                    
                                    // ! Program will crash here if input is not a number or empty; this applies to the same statement inside the loop following up
                                    
                                    // Check if it is within our range of 0-19 | 1-20 (users perspective) AND if it has any content
                                    while ( (recordToUpdate > 20 || recordToUpdate < 1) || (phoneBook[(recordToUpdate - 1)] == null) )
                                    {
                                        Console.WriteLine("Please choose an existing record!\nNumber 1 to 20 and on the list.");
                                        recordToUpdate = Convert.ToInt32(Console.ReadLine());
                                    }
                                    
                                    phoneBookIndex = recordToUpdate - 1;

                                    phoneBook[phoneBookIndex] = null;
                                    phoneBook[phoneBookIndex + 20] = null;

                                    // Indicate a deletion
                                    maxIndex++;

                                    if (maxIndex == 20) // Phonebook became empty
                                    {
                                        Console.WriteLine("Done!\nPhonebook is empty!\nPlease press Enter to continue...");
                                        Console.ReadLine();
                                        haveAnOtherGo = "0";
                                    }
                                    else // If continue while phonebook not empty
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Done!\nWould you like to remove another one?\nYes: type number 1 - No: any other key");
                                        haveAnOtherGo = Convert.ToString(Console.ReadLine());
                                    }
                                }
                                while (haveAnOtherGo == "1");
                            }
                            
                            // If phonebook is already empty
                            else
                            {
                                Console.WriteLine("The phonebook is empty.");
                                Console.WriteLine("Please press Enter to continue...");
                                Console.ReadLine();
                            }
                            
                            break;



                        /* ================================================================================================================================================================ */


                        
// Print content to screen
                        case "3": 

                            Console.WriteLine("Phonebook Contents\n------------------");
                            
                            for (phoneBookIndex = 0; phoneBookIndex < 20; phoneBookIndex++)
                            {
                                if (phoneBook[phoneBookIndex] == null)
                                {
                                    Console.WriteLine("Record " + (phoneBookIndex + 1) + " is empty...");
                                }
                                else
                                {
                                    Console.WriteLine("Record " + (phoneBookIndex + 1) + ": {0,-20} {1,-20}", phoneBook[phoneBookIndex], phoneBook[phoneBookIndex + 20]);
                                }
                            }
                            
                            Console.WriteLine("\nPress Enter to continue!");
                            Console.ReadLine();
                            
                            break;



                        /* ================================================================================================================================================================ */



// Exit:
                        default: // exit program
                            break;



                    }

                }
                while (menuPoint == "1" | menuPoint == "2" | menuPoint == "3"); //Since menus are for 1, 2 and 3; any other number or letter has to exit after running at least once
        }
    }
/* ================================================================================================================================================================ */
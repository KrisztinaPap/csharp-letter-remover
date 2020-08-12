using System;

namespace c_letter_remover_practice_KrisztinaPap
{
    class Program
    {
        static void Main(string[] args)
        {
            
         /*
            Title: C# Letter Remover Practice
            Purpose: The program prompts the user for a string and a character. It returns the string without the chosen character. 
            Author: Krisztina Pap
            Date of last edit: Aug 12, 2020
        */

            // Explain user how to use program
            Console.WriteLine("This program prompts the user for a string and a character. It returns the string without the chosen character.");

            // Declare variables
            string userString = "";
            string userInput = "";
            char userChar;
            string userName;
            int action;
            bool doesItContain;
            int charsIndex;

            // Prompt user for their name and save it into a variable
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine().Trim();

            do
            {
                // Prompt user for string and save it into a variable
                Console.WriteLine("Enter the string you want to modify, {0}:", userName);
                userString = Console.ReadLine().ToLower().Trim(); 

                // Prompt user for a character and save it into a variable
                Console.WriteLine("Enter the character(s) you wish to remove from your string, {0}:", userName);
                userInput = Console.ReadLine().ToLower();

                // Is it one or more characters?
                if ( userInput.Length == 1 ){
                    userChar = char.Parse(userInput);

                    Console.WriteLine("Here's your new string, {0}:", userName);

                    for ( int i = 0; i < userString.Length ; i++ )
                    {
                        // Check each string letter to see if it's the same as the character
                        if ( userString[i] != userChar )
                        {
                            // Return new string
                            Console.Write(userString[i]);
                        }   
                    }
                }
                else 
                {
                    do
                    {
                            // Citation:
                        //      https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                        //      The below line of code checks if the user string actually contains the characters to be removed
                        doesItContain = userString.Contains(userInput);

                        // Citation:
                        //      https://www.c-sharpcorner.com/uploadfile/mahesh/add-remove-replace-strings-in-C-Sharp/
                        //      The below line of code finds the index where we need to start removing from
                        charsIndex = userString.IndexOf(userInput);
                        //      The below line of code removes the userInput from the userString (starts at the index calculated below and continues for the lengths of the input)
                        userString = userString.Remove(charsIndex, userInput.Length);
                        // Citation:
                        //      https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                        //      The below line of code checks if the user string actually contains the characters to be removed
                        doesItContain = userString.Contains(userInput);
                    } while ( doesItContain == true );
                    
                    Console.WriteLine("Here's your new string, {0}:\n{1}", userName, userString);
                }
                Console.WriteLine(" ");
                Console.WriteLine("What would you like to do next?\n-------------------\n1. Start again\n2. Quit program");
                action = int.Parse(Console.ReadLine());

            } while ( action != 2 );
                
        } 
    }
}
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
            char userChar;
            string userName;

            // Prompt user for their name and save it into a variable
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();

            // Prompt user for string and save it into a variable
            Console.WriteLine("Enter the string you want to modify, {0}:", userName);
            userString = Console.ReadLine().ToLower(); 

            // Prompt user for a character and save it into a variable
            Console.WriteLine("Enter the character you wish to remove from your string, {0}:", userName);
            userChar = char.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Here's your new string, {0}:", userName);

            // Remove the character from the string and save result into a new string
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
    }
}
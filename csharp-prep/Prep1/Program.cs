using System;

/*
Program Specification

Overview
An iconic line from the James Bond movies is that he would introduce himself as "Bond, James Bond." For this assignment you will write a program that asks for your name and repeats it back in this way.

Assignment
Prompt the user for their first name. Then, prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name" as shown:

What is your first name? Scott
What is your last name? Burton

Your name is Burton, Scott Burton.

What is your first name? Brigham
What is your last name? Young

Your name is Young, Brigham Young.

Make sure to be precise! You should have the spacing, comma, and period appear exactly as shown in the examples.

Program Loop:
1. Get first name from user and assign to a variable
2. Get last name from user and assign to a variable
3. Construct and display output
4. End Program
*/

class Program
{
    static void Main(string[] args)
    {
        // retreive input and assign it to a variable
        string firstName = GetInput("What is your first name? ");
        string lastName = GetInput("What is your last name? ");
        
        // constuct and display output string from names given
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }

    // python-like method to get user input with a prompt
    static string GetInput(string prompt)
    {   
        // show prompt
        Console.WriteLine(prompt);

        // get user input
        string name = Console.ReadLine();

        return name;
    }
}
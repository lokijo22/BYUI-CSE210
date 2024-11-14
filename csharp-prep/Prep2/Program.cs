using System;

/*
Program Specification
Here are the instructions that you saw previously in CSE 110 that we will use as our program specification:

Overview
Write a program that determines the letter grade for a course according to the following scale:

A >= 90
B >= 80
C >= 70
D >= 60
F < 60
Assignment
Start by completing the core requirements, then when that part is complete, if you have time, see if you can complete some of the stretch challenges as well.

Please work through the requirements in order rather than jumping ahead to more complicated steps, to ensure that everyone is following the concepts.

Core Requirements
Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.

Program loop
1. ask user for their grade as a percent and save it as a variable
2. verify the input was valid
3. convert it into an int for comparison
4. calculate the letter grade conversion
5. print the result out to console
6. End Program
*/
class Program
{
    private static void Main(string[] args)
    {
        // Ask user for their grade
        Console.WriteLine("Enter your grade percentage(Whole Number):");
        string userInput = Console.ReadLine();

        // Convert the input to an integer and check if it is a valid number
        if (int.TryParse(userInput, out int gradePercent))
        {

            if (gradePercent <= 100 && gradePercent >= 0)
            {
                string letterGrade = GetLetter(gradePercent);
                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid Number. Needs to be between 0-100");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input. Input must be a number");
        }
    }

    static string GetLetter(int gradePercent)
    {
        if (gradePercent > 89)
        {
            return "A";
        }
        else if (gradePercent > 79)
        {
            return "B";
        }
        else if (gradePercent > 69)
        {
            return "C";
        }
        else if (gradePercent > 59)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

}
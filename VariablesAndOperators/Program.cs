using System;

class Program
{
static void Main()
    {
        string name = "Öykü";
        int age = 23;
        double height = 1.65;
        bool isStudent = false;

        int afterYears = age + 5;
        double heightSquare = height * height;
        double bmi = age / heightSquare;  
        
        bool youth = age < 30;
        bool isTall= height > 1.60;


        string message = $"Hello {name}!\n" +
                       $"Your age: {age}, after 5 years: {afterYears}\n" +
                       $"Your height: {height}m, height square: {heightSquare}\n" +
                       $"BMI: {bmi}\n" +
                       $"Are you young? {youth}\n" +
                       $"Are you tall? {isTall}\n" +
                       $"Are you a student? {isStudent}";

        Console.WriteLine(message);


    }

}
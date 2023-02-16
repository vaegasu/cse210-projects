using System;

class Program
{
    static void Main(string[] args)
    {
        // Base for assignment
        Assignment a1 = new Assignment("Eirilani Aulai", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Derived class assignments
        MathAssignment a2 = new MathAssignment("Eirike Maafala", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Christina Alama", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
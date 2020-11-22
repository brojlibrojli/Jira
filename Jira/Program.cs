using System;

namespace Jira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do You want to make? ");
            Console.WriteLine("a: Bug" + "\n" + "b: TestCase");
            char typeOfProject;
            bool isChar = char.TryParse(Console.ReadLine().ToLower(), out typeOfProject);

            while ((typeOfProject != 'a') && (typeOfProject != 'b'))
            {
                Console.WriteLine("Wprowadz a lub b");
                char.TryParse(Console.ReadLine(), out typeOfProject);
            }

            if (typeOfProject == 'a')
            {
                Bug bug = new Bug();
            }
            
            else if (typeOfProject == 'b')
            {
                TestCase testCase = new TestCase();
                Console.Write("Test case ID: "); testCase.ID = (Console.ReadLine());
                Console.Write("Autor: "); testCase.autor = (Console.ReadLine());
                Console.Write("Date: "); testCase.date = (Console.ReadLine());
                Console.Write("Description: "); testCase.description = (Console.ReadLine());
                Console.Write("Enviroment and version: "); testCase.enviroment = (Console.ReadLine());
                Console.Write("Prerequisites: "); testCase.prerequisites = (Console.ReadLine());
                Console.Write("Steps details: "); testCase.stepsDetails = (Console.ReadLine());
                Console.Write("Actual result: "); testCase.actualResult = (Console.ReadLine());
                Console.Write("Expected result: "); testCase.expectedResult = (Console.ReadLine());
                Console.Write("Pass/Fail: "); testCase.passOrFail = (Console.ReadLine());

                testCase.ID = "/<" + testCase.ID + ">";
            }
        }
    }
}

using Jira.GettersAndTranslators;   
using System;
using System.IO;

namespace Jira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do You want to make? ");
            Console.WriteLine("a: Bug" + "\n" + "b: TestCase");

            char typeOfProject;
            bool istypeOFProjectChar = char.TryParse(Console.ReadLine().ToLower(), out typeOfProject);


            while ((typeOfProject != 'a') && (typeOfProject != 'b'))
            {
                Console.WriteLine("Type (a/b): ");
                istypeOFProjectChar = char.TryParse(Console.ReadLine(), out typeOfProject);
            }

            if (typeOfProject == 'a')
            {
                Bug bug = new Bug();

                UserInputGetter.GetUserTypes(bug);
                UserInputGetter.TransUserTypes(bug);
                
                string bugPath = @"bug " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".xml";
                
                if (!File.Exists(bugPath))
                {
                    using (StreamWriter sw = new StreamWriter(bugPath))
                    {
                        UserInputGetter.StreamWrite(bug, sw);
                    }
                    Console.WriteLine("The file bug.xml has been created");
                }
                else
                {
                    Console.WriteLine("The file bug.xml already exist!");
                }

            }

            else if (typeOfProject == 'b')
            {
                TestCase testCase = new TestCase();

                UserInputGetter.GetUserTypes(testCase);
                UserInputGetter.TransUserTypes(testCase);
                
                string testCasePath = @"testCase " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".xml";
                
                if (!File.Exists(testCasePath))
                {
                    using (StreamWriter sw = new StreamWriter(testCasePath))
                    {
                        UserInputGetter.StreamWrite(testCase, sw);
                    }

                    Console.WriteLine("The file testCase.xml has been created");
                }
                else
                {
                    Console.WriteLine("The file testCase.xml already exist!");
                }
            }
        }


    }
}
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
            bool istypeOFProjectChar = char.TryParse(Console.ReadLine().ToLower(), out typeOfProject);


            while ((typeOfProject != 'a') && (typeOfProject != 'b'))
            {
                Console.WriteLine("Type (a/b): ");
                istypeOFProjectChar = char.TryParse(Console.ReadLine(), out typeOfProject);
            }

            if (typeOfProject == 'a')
            {
                BugItem bug = new BugItem();
            }

            else if (typeOfProject == 'b')
            {
                TestCase testCase = new TestCase();

                Console.Write("Test case ID: "); bool isIntID = int.TryParse(Console.ReadLine(), out testCase.ID);
                while (!isIntID)
                {
                    Console.WriteLine("Insert number: ");
                    isIntID = int.TryParse(Console.ReadLine(), out testCase.ID);
                }

                Console.Write("Autor: "); testCase.autor = (Console.ReadLine());
                Console.Write("Date: "); bool isDate = DateTime.TryParse(Console.ReadLine(), out testCase.date);

                Console.WriteLine("Is that test automatic? (y/n):");
                char isAutomaticAnswer;
                bool isCharAutomatic = char.TryParse(Console.ReadLine(), out isAutomaticAnswer);

                while (((!isCharAutomatic) && (isAutomaticAnswer != 'y') && (isAutomaticAnswer != 'n')))
                {
                    Console.WriteLine("Type y/n :");
                    char.TryParse(Console.ReadLine(), out isAutomaticAnswer);
                }
                if (isAutomaticAnswer == 'y')
                {
                    testCase.isAutomated = true;
                }
                else if (isAutomaticAnswer == 'n')
                {
                    testCase.isAutomated = false;
                }

                Console.WriteLine("Test category: " +
                    "\n" + "a: functionality" +
                    "\n" + "b: userInterface" +
                    "\n" + "c: performence" +
                    "\n" + "d: integration" +
                    "\n" + "e: usability" +
                    "\n" + "f: database" +
                    "\n" + "g: secuity" +
                    "\n" + "h: userAcceptance"
                    );

                char testCategoryAnser;
                bool isCharTestCategory = char.TryParse(Console.ReadLine(), out testCategoryAnser);
                while (((!isCharTestCategory) && (testCategoryAnser != 'a') && (testCategoryAnser != 'b')
                    && (testCategoryAnser != 'c') && (testCategoryAnser != 'd') && (testCategoryAnser != 'e')
                    && (testCategoryAnser != 'f') && (testCategoryAnser != 'g') && (testCategoryAnser != 'h')))
                {
                    Console.WriteLine("Type one of the letters: ");
                    char.TryParse(Console.ReadLine(), out testCategoryAnser);
                }
                if (testCategoryAnser == 'a')
                {
                    testCase.testCategory = TestCategory.functionality.ToString();
                }
                else if (testCategoryAnser == 'b')
                {
                    testCase.testCategory = TestCategory.userInterface.ToString();
                }
                else if (testCategoryAnser == 'c')
                {
                    testCase.testCategory = TestCategory.performence.ToString();
                }
                else if (testCategoryAnser == 'd')
                {
                    testCase.testCategory = TestCategory.integration.ToString();
                }
                else if (testCategoryAnser == 'e')
                {
                    testCase.testCategory = TestCategory.functionality.ToString();
                }
                else if (testCategoryAnser == 'f')
                {
                    testCase.testCategory = TestCategory.usability.ToString();
                }
                else if (testCategoryAnser == 'g')
                {
                    testCase.testCategory = TestCategory.database.ToString();
                }
                else if (testCategoryAnser == 'h')
                {
                    testCase.testCategory = TestCategory.secuity.ToString();
                }


                Console.Write("Title/Description: "); testCase.title = (Console.ReadLine());
                Console.Write("Enviroment and version: "); testCase.enviroment = (Console.ReadLine());
                Console.Write("Prerequisites: "); testCase.prerequisitesList.Add(Console.ReadLine());
                char answerAnotherPrereq;
                do
                {
                    Console.Write("Want to add another prerequisites (y/n)? :");
                    bool isCharPrereq = char.TryParse(Console.ReadLine(), out answerAnotherPrereq);
                    while ((answerAnotherPrereq != 'y') && (answerAnotherPrereq != 'n'))
                    {
                        Console.Write("Type y or n: "); char.TryParse(Console.ReadLine(), out answerAnotherPrereq);
                    }

                    if (answerAnotherPrereq == 'y')
                    {
                        Console.Write("Another prerequisites: ");
                        testCase.prerequisitesList.Add(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                } while (answerAnotherPrereq == 'y');


                Console.Write("Steps details: "); testCase.stepsList.Add(Console.ReadLine());
                char answerAnotherSteps;
                do
                {
                    Console.Write("Want to add another steps? (y/n):");
                    bool isCharSteps = char.TryParse(Console.ReadLine(), out answerAnotherSteps);
                    while ((answerAnotherSteps != 'y') && (answerAnotherSteps != 'n'))
                    {
                        Console.Write("Type y or n: "); char.TryParse(Console.ReadLine(), out answerAnotherSteps);
                    }
                    if (answerAnotherSteps == 'y')
                    {
                        Console.WriteLine("another steps: ");
                        testCase.stepsList.Add(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                } while (answerAnotherSteps == 'y');

                Console.Write("Actual result: "); testCase.actualResultList.Add(Console.ReadLine());
                char answerActual;
                do
                {
                    Console.Write("Want to add more for actual result? (y/n):");
                    bool isCharActual = char.TryParse(Console.ReadLine(), out answerActual);
                    while ((answerActual != 'y') && (answerActual != 'n'))
                    {
                        Console.Write("Type y or n: "); char.TryParse(Console.ReadLine(), out answerActual);
                    }
                    if (answerAnotherSteps == 'y')
                    {
                        Console.WriteLine("another actual result: ");
                        testCase.actualResultList.Add(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                } while (answerActual == 'y');

                Console.Write("Expected result: "); testCase.expectedResultList.Add(Console.ReadLine());
                char answerExpected;
                do
                {
                    Console.Write("Want to add more for expected result? (y/n):");
                    bool isCharActual = char.TryParse(Console.ReadLine(), out answerExpected);
                    while ((answerExpected != 'y') && (answerExpected != 'n'))
                    {
                        Console.Write("Type y or n: "); char.TryParse(Console.ReadLine(), out answerExpected);
                    }
                    if (answerExpected == 'y')
                    {
                        Console.WriteLine("another expected result: ");
                        testCase.expectedResultList.Add(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                } while (answerExpected == 'y');

                Console.Write("Pass/Fail (y/n): ");
                char passOrFailAnswer;
                bool isCharPassedOrNo = char.TryParse(Console.ReadLine(), out passOrFailAnswer);
                while ((!isCharPassedOrNo) && ((passOrFailAnswer != 'y') && (passOrFailAnswer != 'n')))
                {
                    Console.WriteLine("Type y/n: ");
                    char.TryParse(Console.ReadLine(), out passOrFailAnswer);
                }

            }
        }
    }
}
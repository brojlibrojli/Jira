using System;

namespace Jira
{
    public static class UserTypesGetter
    {
        public static void getID(TestCase TestCase)
        {
            Console.Write("Test case ID: "); bool isIntID = int.TryParse(Console.ReadLine(), out TestCase.ID);
            while (!isIntID)
            {
                Console.WriteLine("Insert number: ");
                isIntID = int.TryParse(Console.ReadLine(), out TestCase.ID);
            }
        }

        public static void getAuthor(TestCase TestCase)
        {
            Console.Write("Autor: "); TestCase.author = (Console.ReadLine());
        }

        public static void getIsAutomated(TestCase TestCase)
        {
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
                TestCase.isAutomated = true;
            }
            else if (isAutomaticAnswer == 'n')
            {
                TestCase.isAutomated = false;
            }
        }

        public static void getTestCategory(TestCase TestCase)
        {
            Console.WriteLine("Test category: " +
            "\n" + "a: functionality" +
            "\n" + "b: userInterface" +
            "\n" + "c: performence" +
            "\n" + "d: integration" +
            "\n" + "e: usability" +
            "\n" + "f: database" +
            "\n" + "g: secuity" +
            "\n" + "h: userAcceptance");

            char testCategoryAnser;
            bool isCharTestCategory = char.TryParse(Console.ReadLine(), out testCategoryAnser);
            while (((!isCharTestCategory) || (testCategoryAnser != 'a') && (testCategoryAnser != 'b')
                && (testCategoryAnser != 'c') && (testCategoryAnser != 'd') && (testCategoryAnser != 'e')
                && (testCategoryAnser != 'f') && (testCategoryAnser != 'g') && (testCategoryAnser != 'h')))
            {
                Console.WriteLine("Type one of the letters: ");
                isCharTestCategory = char.TryParse(Console.ReadLine(), out testCategoryAnser);
            }
            if (testCategoryAnser == 'a')
            {
                TestCase.testCategory = TestCategory.functionality.ToString();
            }
            else if (testCategoryAnser == 'b')
            {
                TestCase.testCategory = TestCategory.userInterface.ToString();
            }
            else if (testCategoryAnser == 'c')
            {
                TestCase.testCategory = TestCategory.performence.ToString();
            }
            else if (testCategoryAnser == 'd')
            {
                TestCase.testCategory = TestCategory.integration.ToString();
            }
            else if (testCategoryAnser == 'e')
            {
                TestCase.testCategory = TestCategory.functionality.ToString();
            }
            else if (testCategoryAnser == 'f')
            {
                TestCase.testCategory = TestCategory.usability.ToString();
            }
            else if (testCategoryAnser == 'g')
            {
                TestCase.testCategory = TestCategory.database.ToString();
            }
            else if (testCategoryAnser == 'h')
            {
                TestCase.testCategory = TestCategory.security.ToString();
            }
        }
        public static void getTittleDescription(TestCase TestCase)
        {
            Console.Write("Title/Description: "); TestCase.title = (Console.ReadLine());
        }

        public static void getEnviromentAndVersion(TestCase TestCase)
        {
            Console.Write("Enviroment and version: "); TestCase.enviroment = (Console.ReadLine());
        }

        public static void getPrerequisites(TestCase TestCase)
        {
            Console.Write("Prerequisites: "); TestCase.prerequisitesList.Add(Console.ReadLine());
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
                    TestCase.prerequisitesList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherPrereq == 'y');
        }

        public static void getStepsList(TestCase TestCase)
        {
            Console.Write("Steps details: "); TestCase.stepsList.Add(Console.ReadLine());
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
                    TestCase.stepsList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherSteps == 'y');
        }

        public static void getActualResultList(TestCase TestCase)
        {
            Console.Write("Actual result: "); TestCase.actualResultList.Add(Console.ReadLine());
            char answerAnotherActual;
            do
            {
                Console.Write("Want to add more for actual result? (y/n):");
                bool isCharActual = char.TryParse(Console.ReadLine(), out answerAnotherActual);
                while ((answerAnotherActual != 'y') && (answerAnotherActual != 'n'))
                {
                    Console.Write("Type y or n: "); char.TryParse(Console.ReadLine(), out answerAnotherActual);
                }
                if (answerAnotherActual == 'y')
                {
                    Console.WriteLine("another actual result: ");
                    TestCase.actualResultList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherActual == 'y');
        }

        public static void getExpectedResultList(TestCase TestCase)
        {
            Console.Write("Expected result: "); TestCase.expectedResultList.Add(Console.ReadLine());
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
                    TestCase.expectedResultList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerExpected == 'y');

        }
        public static void getIsPassed(TestCase TestCase)
        {
            Console.Write("Pass/Fail (y/n): ");
            char isPassAnser;
            bool isCharIsPass = char.TryParse(Console.ReadLine(), out isPassAnser);
            while ((!isCharIsPass) && ((isPassAnser != 'y') && (isPassAnser != 'n')))
            {
                Console.WriteLine("Type y/n: ");
                char.TryParse(Console.ReadLine(), out isPassAnser);
            }
        }

    }
}

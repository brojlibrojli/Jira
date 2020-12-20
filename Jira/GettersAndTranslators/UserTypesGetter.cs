using System;

namespace Jira
{
    public static class UserTypesGetter
    {
        public static void getID(JiraItem jiraItem)
        {
            Console.Write("ID: "); bool isIntID = int.TryParse(Console.ReadLine(), out jiraItem.ID);
            while (!isIntID)
            {
                Console.WriteLine("Insert number: ");
                isIntID = int.TryParse(Console.ReadLine(), out jiraItem.ID);
            }
        }

        public static void getAuthor(JiraItem jiraItem)
        {
            Console.Write("Author: "); jiraItem.author = (Console.ReadLine());
            while (jiraItem.author.Length < 1)
            {
                Console.WriteLine("The field cannot be empty");
                Console.Write("Author: "); jiraItem.author = (Console.ReadLine());
            }
        }

        public static void getIsAutomated(TestCase testCase)
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
        public static void getTittleDescription(JiraItem jiraItem)
        {
            Console.Write("Title/Description: "); jiraItem.title = (Console.ReadLine());
            while(jiraItem.title.Length < 1)
            {
                Console.WriteLine("The field cannot be empty");
                Console.Write("Title/Description: "); jiraItem.title = (Console.ReadLine());
            }
        }

        public static void getEnviromentAndVersion(JiraItem jiraItem)
        {
            Console.Write("Enviroment and version: "); jiraItem.enviroment = (Console.ReadLine());
            while (jiraItem.enviroment.Length < 1)
            {
                Console.WriteLine("The field cannot be empty");
                Console.Write("Enviroment and version: "); jiraItem.enviroment = (Console.ReadLine());
            }
        }

        public static void getPriority(Bug Bug)
        {
            Console.WriteLine("Bug priority: " +
            "\n" + "a: low" +
            "\n" + "b: medium" +
            "\n" + "c: high" +
            "\n" + "d: immediate");

            char bugPriorityAnswer;
            bool isCharBugPriority = char.TryParse(Console.ReadLine(), out bugPriorityAnswer);
            while (((!isCharBugPriority) || (bugPriorityAnswer != 'a') && (bugPriorityAnswer != 'b')
                && (bugPriorityAnswer != 'c') && (bugPriorityAnswer != 'd')))
            {
                Console.WriteLine("Type one of the letters: ");
                isCharBugPriority = char.TryParse(Console.ReadLine(), out bugPriorityAnswer);
            }
            if (bugPriorityAnswer == 'a')
            {
                Bug.priority = BugPriority.low.ToString();
            }
            else if (bugPriorityAnswer == 'b')
            {
                Bug.priority = BugPriority.medium.ToString();
            }
            else if (bugPriorityAnswer == 'c')
            {
                Bug.priority = BugPriority.high.ToString(); ;
            }
            else if (bugPriorityAnswer == 'd')
            {
                Bug.priority = BugPriority.immediate.ToString();
            }
        }

        public static void getSeverity(Bug Bug)
        {
            Console.WriteLine("Bug severity: " +
            "\n" + "a: low" +
            "\n" + "b: major" +
            "\n" + "c: minor" +
            "\n" + "d: critical");

            char bugSeverityAnswer;
            bool isCharBugSeverity = char.TryParse(Console.ReadLine(), out bugSeverityAnswer);
            while (((!isCharBugSeverity) || (bugSeverityAnswer != 'a') && (bugSeverityAnswer != 'b')
                && (bugSeverityAnswer != 'c') && (bugSeverityAnswer != 'd')))
            {
                Console.WriteLine("Type one of the letters: ");
                isCharBugSeverity = char.TryParse(Console.ReadLine(), out bugSeverityAnswer);
            }
            if (bugSeverityAnswer == 'a')
            {
                Bug.severity = BugSeverity.low.ToString();
            }
            else if (bugSeverityAnswer == 'b')
            {
                Bug.severity = BugSeverity.major.ToString();
            }
            else if (bugSeverityAnswer == 'c')
            {
                Bug.severity = BugSeverity.minor.ToString();
            }
            else if (bugSeverityAnswer == 'd')
            {
                Bug.severity = BugSeverity.critical.ToString();
            }
        }

        public static void getPrerequisites(JiraItem jiraItem)
        {
            Console.Write("Prerequisites: "); jiraItem.prerequisitesList.Add(Console.ReadLine());
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
                    jiraItem.prerequisitesList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherPrereq == 'y');
        }

        public static void getStepsList(JiraItem jiraItem)
        {
            Console.Write("Steps details: "); jiraItem.stepsList.Add(Console.ReadLine());
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
                    jiraItem.stepsList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherSteps == 'y');
        }

        public static void getActualResultList(JiraItem jiraItem)
        {
            Console.Write("Actual result: "); jiraItem.actualResultList.Add(Console.ReadLine());
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
                    jiraItem.actualResultList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherActual == 'y');
        }

        public static void getExpectedResultList(JiraItem jiraItem)
        {
            Console.Write("Expected result: "); jiraItem.expectedResultList.Add(Console.ReadLine());
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
                    jiraItem.expectedResultList.Add(Console.ReadLine());
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

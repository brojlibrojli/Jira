using System;

namespace Jira
{
    public static class UserBugTypesGetter
    {
        public static void getBugID(Bug Bug)
        {
            Console.Write("Bug ID: "); bool isIntID = int.TryParse(Console.ReadLine(), out Bug.ID);
            while (!isIntID)
            {
                Console.WriteLine("Insert number: ");
                isIntID = int.TryParse(Console.ReadLine(), out Bug.ID);
            }
        }

        public static void getBugAuthor(Bug Bug)
        {
            Console.Write("Autor: "); Bug.author = (Console.ReadLine());
        }

        public static void getBugTittleDescription(Bug Bug)
        {
            Console.Write("Title/Description: "); Bug.title = (Console.ReadLine());
        }

        public static void getBugEnviromentAndVersion(Bug Bug)
        {
            Console.Write("Enviroment and version: "); Bug.enviroment = (Console.ReadLine());
        }

        public static void getBugPriority(Bug Bug)
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
                Bug.priority = Bug.BugPriority.low.ToString();
            }
            else if (bugPriorityAnswer == 'b')
            {
                Bug.priority = Bug.BugPriority.medium.ToString();
            }
            else if (bugPriorityAnswer == 'c')
            {
                Bug.priority = Bug.BugPriority.high.ToString();
            }
            else if (bugPriorityAnswer == 'd')
            {
                Bug.priority = Bug.BugPriority.immediate.ToString();
            }
        }

        public static void getBugSeverity(Bug Bug)
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
                Bug.severity = Bug.BugSeverity.low.ToString();
            }
            else if (bugSeverityAnswer == 'b')
            {
                Bug.severity = Bug.BugSeverity.major.ToString();
            }
            else if (bugSeverityAnswer == 'c')
            {
                Bug.severity = Bug.BugSeverity.minor.ToString();
            }
            else if (bugSeverityAnswer == 'd')
            {
                Bug.severity = Bug.BugSeverity.critical.ToString();
            }
        }



        public static void getBugPrerequisites(Bug Bug)
        {
            Console.Write("Prerequisites: "); Bug.prerequisitesList.Add(Console.ReadLine());
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
                    Bug.prerequisitesList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherPrereq == 'y');
        }

        public static void getBugStepsList(Bug Bug)
        {
            Console.Write("Steps details: "); Bug.stepsList.Add(Console.ReadLine());
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
                    Bug.stepsList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherSteps == 'y');
        }

        public static void getBugActualResultList(Bug Bug)
        {
            Console.Write("Actual result: "); Bug.actualResultList.Add(Console.ReadLine());
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
                    Bug.actualResultList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerAnotherActual == 'y');
        }

        public static void getBugExpectedResultList(Bug Bug)
        {
            Console.Write("Expected result: "); Bug.expectedResultList.Add(Console.ReadLine());
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
                    Bug.expectedResultList.Add(Console.ReadLine());
                }
                else
                {
                    break;
                }
            } while (answerExpected == 'y');

        }
    }
}

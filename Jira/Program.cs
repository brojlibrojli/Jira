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

                getUserTypes(bug);
                transUserTypes(bug);
                string bugPath = @"bug.txt " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
                if (!File.Exists(bugPath))
                {
                    using (StreamWriter sw = new StreamWriter(bugPath))
                        streamWrite(bug, sw);
                    Console.WriteLine("The file bug.txt has been created");
                }
                else
                {
                    Console.WriteLine("The file bug.txt already exist!");
                }

            }

            else if (typeOfProject == 'b')
            {
                TestCase testCase = new TestCase();

                getUserTypes(testCase);
                transUserTypes(testCase);
                string testCasePath = @"testCase.txt " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
                if (!File.Exists(testCasePath))
                {
                    using (StreamWriter sw = new StreamWriter(testCasePath))
                        streamWrite(testCase, sw);
                    Console.WriteLine("The file testCase.txt has been created");
                }
                else
                {
                    Console.WriteLine("The file testCase.txt already exist!");
                }
            }
        }

        private static void streamWrite(TestCase testCase, StreamWriter streamWriter)
        {
            streamWriter.WriteLine(UserTypesXmlTranslator.mainTestCaseElement());
            streamWriter.WriteLine(UserTypesXmlTranslator.transID(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transAuthor(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transIsAutomated(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transTestCategory(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transTittle(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transEnviromentAndVersion(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transPrerequisites(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transStepsList(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transActualResults(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transExpectedResults(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.transIsPassed(testCase));
            streamWriter.WriteLine(UserTypesXmlTranslator.mainTestCaseElementEnd());
        }

        private static void transUserTypes(TestCase testCase)
        {
            Console.WriteLine();
            Console.WriteLine(UserTypesXmlTranslator.transID(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transAuthor(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transIsAutomated(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transTestCategory(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transTittle(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transEnviromentAndVersion(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transPrerequisites(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transStepsList(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transActualResults(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transExpectedResults(testCase));
            Console.WriteLine(UserTypesXmlTranslator.transIsPassed(testCase));
        }

        private static void getUserTypes(TestCase testCase)
        {
            UserTypesGetter.getID(testCase);
            UserTypesGetter.getAuthor(testCase);
            UserTypesGetter.getIsAutomated(testCase);
            UserTypesGetter.getTestCategory(testCase);
            UserTypesGetter.getTittleDescription(testCase);
            UserTypesGetter.getEnviromentAndVersion(testCase);
            UserTypesGetter.getPrerequisites(testCase);
            UserTypesGetter.getStepsList(testCase);
            UserTypesGetter.getActualResultList(testCase);
            UserTypesGetter.getExpectedResultList(testCase);
            UserTypesGetter.getIsPassed(testCase);
        }

        private static void streamWrite(Bug bug, StreamWriter streamWriter)
        {
            streamWriter.WriteLine(UserTypesXmlTranslator.mainBugElement());
            streamWriter.WriteLine(UserTypesXmlTranslator.transID(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transAuthor(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transTittle(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transEnviromentAndVersion(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transPriority(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transSeverity(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transPrerequisites(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transStepsList(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transActualResults(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.transExpectedResults(bug));
            streamWriter.WriteLine(UserTypesXmlTranslator.mainBugElementEnd());
        }

        private static void transUserTypes(Bug bug)
        {
            Console.WriteLine(UserTypesXmlTranslator.transID(bug));
            Console.WriteLine(UserTypesXmlTranslator.transAuthor(bug));
            Console.WriteLine(UserTypesXmlTranslator.transTittle(bug));
            Console.WriteLine(UserTypesXmlTranslator.transEnviromentAndVersion(bug));
            Console.WriteLine(UserTypesXmlTranslator.transPriority(bug));
            Console.WriteLine(UserTypesXmlTranslator.transSeverity(bug));
            Console.WriteLine(UserTypesXmlTranslator.transPrerequisites(bug));
            Console.WriteLine(UserTypesXmlTranslator.transStepsList(bug));
            Console.WriteLine(UserTypesXmlTranslator.transActualResults(bug));
            Console.WriteLine(UserTypesXmlTranslator.transExpectedResults(bug));
        }

        private static void getUserTypes(Bug bug)
        {
            UserTypesGetter.getID(bug);
            UserTypesGetter.getAuthor(bug);
            UserTypesGetter.getTittleDescription(bug);
            UserTypesGetter.getEnviromentAndVersion(bug);
            UserTypesGetter.getPriority(bug);
            UserTypesGetter.getSeverity(bug);
            UserTypesGetter.getPrerequisites(bug);
            UserTypesGetter.getStepsList(bug);
            UserTypesGetter.getActualResultList(bug);
            UserTypesGetter.getExpectedResultList(bug);
        }
    }
}
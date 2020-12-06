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

                UserBugTypesGetter.getBugID(bug);
                UserBugTypesGetter.getBugAuthor(bug);
                UserBugTypesGetter.getBugTittleDescription(bug);
                UserBugTypesGetter.getBugEnviromentAndVersion(bug);
                UserBugTypesGetter.getBugPriority(bug);
                UserBugTypesGetter.getBugSeverity(bug);
                UserBugTypesGetter.getBugPrerequisites(bug);
                UserBugTypesGetter.getBugStepsList(bug);
                UserBugTypesGetter.getBugActualResultList(bug);
                UserBugTypesGetter.getBugExpectedResultList(bug);

                Console.WriteLine(UserBugTypesXmlTranslator.transBugID(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugAuthor(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugTittle(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugEnviromentAndVersion(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugPriority(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugSeverity(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugPrerequisites(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugStepsList(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugActualResults(bug));
                Console.WriteLine(UserBugTypesXmlTranslator.transBugExpectedResults(bug));

                string path = @"bug.txt";
                StreamWriter streamWriter;
                if (!File.Exists(path))
                {
                    streamWriter = File.CreateText(path);
                    Console.WriteLine("The file bug.txt has been created");
                }
                else
                {
                    streamWriter = new StreamWriter(path);
                    Console.WriteLine("The file bug.txt has been opened");
                }

                streamWriter.WriteLine(UserBugTypesXmlTranslator.MainElement());
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugID(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugAuthor(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugTittle(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugEnviromentAndVersion(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugPriority(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugSeverity(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugPrerequisites(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugStepsList(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugActualResults(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.transBugExpectedResults(bug));
                streamWriter.WriteLine(UserBugTypesXmlTranslator.MainElementEnd());
                Console.WriteLine();
                streamWriter.Close();
            }

            else if (typeOfProject == 'b')
            {
                TestCase testCase = new TestCase();

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

                string path = @"jirer.txt";
                StreamWriter streamWriter;
                if (!File.Exists(path))
                {
                    streamWriter = File.CreateText(path);
                    Console.WriteLine("The file jirer.txt has been created");
                }
                else
                {
                    streamWriter = new StreamWriter(path);
                    Console.WriteLine("The file jirer.txt has been opened");
                }
                
                streamWriter.WriteLine(UserTypesXmlTranslator.mainElement());
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
                streamWriter.WriteLine(UserTypesXmlTranslator.mainElementEnd());
                Console.WriteLine();
                streamWriter.Close();
            }
        }
    }
}
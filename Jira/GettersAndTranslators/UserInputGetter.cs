using System;
using System.IO;

namespace Jira.GettersAndTranslators
{
    public static class UserInputGetter
    {
        public static void StreamWrite(TestCase testCase, StreamWriter streamWriter)
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

        public static void TransUserTypes(TestCase testCase)
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

        public static void GetUserTypes(TestCase testCase)
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

        public static void StreamWrite(Bug bug, StreamWriter streamWriter)
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

        public static void TransUserTypes(Bug bug)
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

        public static void GetUserTypes(Bug bug)
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

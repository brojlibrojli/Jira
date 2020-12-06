namespace Jira
{
    public static class UserTypesXmlTranslator
    {
        public static string mainElement()
        {
            return "<TestCase-xml>";
        }

        public static string transID(TestCase TestCase)
        {
            return "<ID>" + TestCase.ID.ToString() + "</ID>";
        }
        public static string transAuthor(TestCase TestCase)
        {
            return "<Author>" + TestCase.author.ToString() + "</Author>";
        }
        public static string transDate(TestCase TestCase)
        {
            return "<Date>" + TestCase.date.ToString() + "</Date>";
        }
        public static string transIsAutomated(TestCase TestCase)
        {
            return "<IsAutomatedTest>" + TestCase.isAutomated.ToString() + "</IsAutomatedTest>";
        }
        public static string transTestCategory(TestCase TestCase)
        {
            return "<TestCategory>" + TestCase.testCategory.ToString() + "</TestCategory>";
        }
        public static string transTittle(TestCase TestCase)
        {
            return "<Title>" + TestCase.title.ToString() + "</Title>";
        }
        public static string transEnviromentAndVersion(TestCase TestCase)
        {
            return "<Enviroment-Version>" + TestCase.enviroment.ToString() + "</Enviroment-Version>";
        }
        public static string transPrerequisites(TestCase TestCase)
        {
            return "<Prerequisites>" + TestCase.prerequisitesList.ToString() + "</Prerequisites>";
        }
        public static string transStepsList(TestCase TestCase)
        {
            return "<StepsToReproduce>" + TestCase.stepsList.ToString() + "</StepsToReproduce>";
        }
        public static string transActualResults(TestCase TestCase)
        {
            return "<ActualResults>" + TestCase.actualResultList.ToString() + "</ActualResults>";
        }
        public static string transExpectedResults(TestCase TestCase)
        {
            return "<ExpectedResults>" + TestCase.expectedResultList.ToString() + "</ExpectedResults>";
        }
        public static string transIsPassed(TestCase TestCase)
        {
            return "<Pass-Fail> " + TestCase.isPassed.ToString() + "</Pass-Fail>";
        }

        public static string mainElementEnd()
        {
            return "</TestCase-xml>";
        }

    }
}


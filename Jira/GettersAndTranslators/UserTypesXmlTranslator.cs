namespace Jira
{
    public static class UserTypesXmlTranslator
    {
        public static string mainTestCaseElement()
        {
            return "<TestCase-xml>";
        }
        public static string mainBugElement()
        {
            return "<Bug-xml>";
        }

        public static string transID(JiraItem jiraItem)
        {
            return "<ID>" + jiraItem.ID.ToString() + "</ID>";
        }
        public static string transAuthor(JiraItem jiraItem)
        {
            return "<Author>" + jiraItem.author.ToString() + "</Author>";
        }
        public static string transDate(JiraItem jiraItem)
        {
            return "<Date>" + jiraItem.date.ToString() + "</Date>";
        }
        public static string transIsAutomated(TestCase testCase)
        {
            return "<IsAutomatedTest>" + TestCase.isAutomated.ToString() + "</IsAutomatedTest>";
        }
        public static string transTestCategory(TestCase TestCase)
        {
            return "<TestCategory>" + TestCase.testCategory.ToString() + "</TestCategory>";
        }
        public static string transTittle(JiraItem jiraItem)
        {
            return "<Title>" + jiraItem.title.ToString() + "</Title>";
        }
        public static string transEnviromentAndVersion(JiraItem jiraItem)
        {
            return "<Enviroment-Version>" + jiraItem.enviroment.ToString() + "</Enviroment-Version>";
        }
        public static string transPriority(Bug Bug)
        {
            return "<Bug-priority>" + Bug.priority.ToString() + "</Bug-priority>";
        }

        public static string transSeverity(Bug Bug)
        {
            return "<Bug-severity>" + Bug.severity.ToString() + "</Bug-severity>";
        }
        public static string transPrerequisites(JiraItem jiraItem)
        {
            string actualItem = "";
            foreach (var item in jiraItem.prerequisitesList)
            {
                actualItem += "<Prerequisites>" + item + "</Prerequisites>" + "\n";
            }
            return actualItem;
        }
        public static string transStepsList(JiraItem jiraItem)
        {
            string actualItem = "";
            foreach (var item in jiraItem.stepsList)
            {
                actualItem += "<StepsToReproduce>" + item + "</StepsToReproduce>" + "\n";
            }
            return actualItem;
        }
        public static string transActualResults(JiraItem jiraItem)
        {
            string actualItem = "";
            foreach (var item in jiraItem.actualResultList)
            {
                actualItem += "<ActualResults>" + item + "</ActualResults>" + "\n";
            }
            return actualItem;
        }
        public static string transExpectedResults(JiraItem jiraItem)
        {
            string actualItem = "";
            foreach (var item in jiraItem.expectedResultList)
            {
                actualItem += "<ExpectedResults>" + item + "</ExpectedResults>" + "\n";
            }
            return actualItem;
        }
        public static string transIsPassed(TestCase TestCase)
        {
            return "<Pass-Fail>" + TestCase.isPassed.ToString() + "</Pass-Fail>";
        }

        public static string mainTestCaseElementEnd()
        {
            return "</TestCase-xml>";
        }
        public static string mainBugElementEnd()
        {
            return "</Bug-xml>";
        }


    }
}


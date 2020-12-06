using System;
using System.Collections.Generic;
using System.Text;

namespace Jira
{
    class UserBugTypesXmlTranslator
    {
        public static string MainElement()
        {
            return "<Bug-xml>";
        }
        
        public static string transBugID(Bug Bug)
        {
            return "<ID>" + Bug.ID.ToString() + "</ID>";
        }

        public static string transBugAuthor(Bug Bug)
        {
            return "<Author>" + Bug.author.ToString() + "</Author>";
        }

        public static string transBugDate(Bug Bug)
        {
            return "<Date>" + Bug.date.ToString() + "</Date>";
        }

        public static string transBugTittle(Bug Bug)
        {
            return "<Title>" + Bug.title.ToString() + "</Title>";
        }
        public static string transBugEnviromentAndVersion(Bug Bug)
        {
            return "<Enviroment-Version>" + Bug.enviroment.ToString() + "</Enviroment-Version>";
        }

        public static string transBugPriority(Bug Bug)
        {
            return "<Bug-priority>" + Bug.priority.ToString() + "</Bug-priority>";
        }

        public static string transBugSeverity(Bug Bug)
        {
            return "<Bug-severity>" + Bug.severity.ToString() + "</Bug-severity>";
        }

        public static string transBugPrerequisites(Bug Bug)
        {
            return "<Prerequisites>" + Bug.prerequisitesList.ToString() + "</Prerequisites>";
        }
        public static string transBugStepsList(Bug Bug)
        {
            return "<Steps-To-Reproduce>" + Bug.stepsList.ToString() + "</Steps-To-Reproduce>";
        }
        public static string transBugActualResults(Bug Bug)
        {
            return "<ActualResults>" + Bug.actualResultList.ToString() + "</ActualResults>";
        }
        public static string transBugExpectedResults(Bug Bug)
        {
            return "<ExpectedResults>" + Bug.expectedResultList.ToString() + "</ExpectedResults>";
        }

        public static string MainElementEnd()
        {
            return "</Bug-xml>";
        }
    }
}

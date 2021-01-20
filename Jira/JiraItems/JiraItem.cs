using System;
using System.Collections.Generic;

namespace Jira
{
    public abstract class JiraItem
    {
        public int ID;
        public string author;
        public DateTime date;
        public string title;
        public string enviroment;
        public List<string> prerequisitesList = new List<string>();
        public List<string> stepsList = new List<string>();
        public List<string> actualResultList = new List<string>();
        public List<string> expectedResultList = new List<string>();
        public List<string> testCaseResultList = new List<string>();
        public enum statusEnum
        {
            status
        }
        public string remarks;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Jira
{
    public abstract class JiraItem
    {
        public string ID;
        public string autor;
        public string date;
        public string description;
        public string enviroment;
        public string prerequisites;
        public string stepsDetails;
        public string actualResult;
        public string expectedResult;
        public string passOrFail;

        public string priority;
        public string status;
        public string stepsToReproduce;

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Jira
{
    public class TestCase : JiraItem
    {
        public bool isAutomated;
        public bool isPassed;
        public string testCategory;
    }
}

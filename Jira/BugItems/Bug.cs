using System;
using System.Collections.Generic;
using System.Text;

namespace Jira
{
    public class Bug : JiraItem
    {
        public string priority;
        public enum BugPriority
        {
            low,
            medium,
            high,
            immediate
        }

        public string severity;
        public enum BugSeverity
        {
            low,
            minor,
            major,
            critical
        }
    }
}

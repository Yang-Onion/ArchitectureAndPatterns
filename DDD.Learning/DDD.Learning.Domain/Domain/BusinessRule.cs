using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public class BusinessRule
    {
        private readonly string _ruleDescription;
        public BusinessRule(string ruleDescription)
        {
            _ruleDescription = ruleDescription;
        }
        public string RuleDescription
        {
            get { return _ruleDescription; }
        }
    }
}

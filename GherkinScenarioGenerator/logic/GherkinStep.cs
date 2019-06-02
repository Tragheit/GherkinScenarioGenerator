using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinScenarioGenerator.logic
{
    public class GherkinStep
    {
        public string Type {get; set;}
        public string Description { get; set; }

        public GherkinStep(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }
    
}

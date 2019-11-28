using System;
using System.Collections.Generic;
using System.Text;

namespace StepFunctionsHelloWorld
{
    /// <summary>
    /// The state passed between the step function executions.
    /// </summary>
    public class State
    {
        public int Salary { get; set; }
        public bool IsPremium { get; set; }
    }
}
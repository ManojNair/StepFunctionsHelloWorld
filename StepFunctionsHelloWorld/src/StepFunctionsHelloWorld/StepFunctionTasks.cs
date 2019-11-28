using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon.Lambda.Core;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace StepFunctionsHelloWorld
{
    public class StepFunctionTasks
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public StepFunctionTasks()
        {
        }
        

        public State PremiumUser(State state, ILambdaContext context)
        {
            // Tell Step Function to wait 5 seconds before calling 

            var salary = state.Salary;

            state.IsPremium = salary > 10000;

           

            return state;
        }
    }
}
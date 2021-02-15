using System;

namespace WorkflowEngine
{
    public class CalWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Web service is called");
        }
    }
}

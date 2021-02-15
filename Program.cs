using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var workflow = new Workflow();
            workflow.Add(new CalWebService());
            workflow.Add(new SendAnEmail());
            workflow.Add(new UploadVideo());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
            

        }
    }
}

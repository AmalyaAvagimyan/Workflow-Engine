using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        
        public void Run (IWorkflow workflow)
        {
            foreach (var wf in workflow.GetTasks())
                wf.Execute();
        }
       
    }
}

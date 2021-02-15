using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
       
        private readonly IList<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }
        public void Add(ITask workflow)
        {
            _tasks.Add(workflow);
        }

        public void Remove(ITask workflow)
        {
            _tasks.Remove(workflow);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}

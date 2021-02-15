using System;

namespace WorkflowEngine
{
    public class UploadVideo : ITask
    {
        void ITask.Execute()
        {
            Console.WriteLine("Video is uploaded");
        }
    }
}

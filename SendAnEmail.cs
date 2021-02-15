using System;

namespace WorkflowEngine
{
    public class SendAnEmail : ITask
    {
       public void Execute()
        {
            Console.WriteLine("Email is sent");
        }
    }
}

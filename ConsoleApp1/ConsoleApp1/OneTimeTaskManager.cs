using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OneTimeTaskManager : TaskManager
    {
        private List<OneTimeTask> _OneTimeTasks = new List<OneTimeTask>() { };
        public void cancelTask(OneTimeTask task)
        {
            _OneTimeTasks.Remove(task);
        }

        public override void getTask()
        {
            foreach (var task in _OneTimeTasks)
            {
                Console.WriteLine("Task" + (_OneTimeTasks.IndexOf(task)+1));
                Console.WriteLine("Name: " + task.Name);
                Console.WriteLine("Description: " + task.Description);

            }
        }

        public override void setTask()
        {
            OneTimeTask task = new OneTimeTask();
            _OneTimeTasks.Add(task);
            Console.WriteLine("Enter the name of the task");
            task.Name = Console.ReadLine();
            Console.WriteLine("Enter the description of the task");
            task.Description = Console.ReadLine();
            Console.WriteLine("task" + '"' + task.Name + '"' + "created");

        }
    }
}

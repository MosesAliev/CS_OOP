using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class DailyTaskManager: TaskManager
    {
        private List<DailyTask> _DailyTasks = new List<DailyTask>() { };

        public override void getTask()
        {
            foreach (var task in _DailyTasks)
            {
                Console.WriteLine("Task " + (_DailyTasks.IndexOf(task)+1));
                Console.WriteLine("Name: " + task.Name);
                Console.WriteLine("Description: " + task.Description);

            }
        }
        public override void setTask()
        {
            DailyTask task = new DailyTask();
            _DailyTasks.Add(task);
            Console.WriteLine("Enter the name of the task");
            task.Name = Console.ReadLine();
            Console.WriteLine("Enter the description of the task");
            task.Description = Console.ReadLine();
            Console.WriteLine("task" + '"' + task.Name + '"' + "created");

        }
        public void cancelTask(DailyTask task)
        {
            _DailyTasks.Remove(task);
        }
    }
}

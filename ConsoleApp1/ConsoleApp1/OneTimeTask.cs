using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OneTimeTask : Task, ITask
    {
        public void perform() 
        {
            Status = true;
            Console.WriteLine("task" + '"' + Name + '"' + " " + "Done");
        }
    }
}

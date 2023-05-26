using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DailyTask : Task, ITask
    {
        private DateTime dateTime = DateTime.Now;
        public DateTime DateTime 
        {
            get 
            { 
                return dateTime;
            } 
        }

        public void perform()
        {
            Status = true;
            Console.WriteLine('"' + Name + '"' + " " + "Выполнено"); 
        }

        
    }
}

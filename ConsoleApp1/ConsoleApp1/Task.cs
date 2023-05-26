using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task
    {
        private int priority;
        private bool status = false;
        public int Priority
        {
            set { priority = value; }
            get { return priority; }
        }

        public string? Description { set; get; } = "";

        public string? Name { set; get; } = "";

        public bool Status
        {
            set { status = value; }
            get { return status; }
        }
    }
}

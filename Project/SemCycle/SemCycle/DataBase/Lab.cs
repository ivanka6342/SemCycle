using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    class Lab
    {
        protected DateTime deadline;
        protected string name { get => name; set => name = value; }
        protected string note { set => note = value; }
        protected int importance { get => importance; set => importance = value; }

        public void update()
        {

        }
        public void setDeadLine(DateTime time)
        {
            this.deadline = time;
        }
    }
}

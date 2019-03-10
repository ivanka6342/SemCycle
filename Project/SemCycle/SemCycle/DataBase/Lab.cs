using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    class Lab
    {
        protected DateTime deadline;
        private string name;
        private string note;
        private int importance;

        protected string Name { get => name; set => name = value; }
        protected string Note { get => note; set => note = value; }
        protected int Importance { get => importance; set => importance = value; }

        public Lab()
        {

        }
        public void update()
        {

        }
        public void setDeadLine(DateTime time)
        {
            this.deadline = time;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    class Discipline
    {
        protected List<Lab> labList = new List<Lab>();
        protected DateTime deadline;
        protected string teacher = "";
        protected int importance;
        private string name;
        private string note;

        protected string Name { get => name; set => name = value; }
        protected string Note { get => note; set => note = value; }

        public Lab getLab(string name)
        {
            return labList[1];
        }
        public void addLab()
        {    

        }
        public void deleteLab(string name)
        {

        }
        public void setDeadLine(DateTime time)
        {
            this.deadline = time;
        }

    }
}

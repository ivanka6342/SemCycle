using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    class Semester
    {
        protected List<Discipline> DisciplineList = new List<Discipline>();
        private int semNumber;
        protected int SemNumber { get => semNumber; set => semNumber = value; }

        public Semester()
        {

        }
        public Semester(int num)
        {
            semNumber = num;
        }
        public Discipline getDiscipline(String name)
        {
            return DisciplineList[1];
        }
        public void addDiscipline()
        {

        }
        public void deleteDiscipline(String name)
        {

        }
    }
}

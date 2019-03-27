using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    public class Semester
    {
        private List<Discipline> DisciplineList = new List<Discipline>();
        private int semNumber;
        protected int SemNumber { get => semNumber; set => semNumber = value; }

        public Semester()
        {

        }
        public void ClearDiscipline()
        {
            DisciplineList.Clear();
        }
        public Semester(int num)
        {
            semNumber = num;
        }
      /*  public Discipline getDiscipline(String name)
        {
            return DisciplineList[1];
        }*/
        public void addDiscipline(Discipline inputDisc)
        {
            DisciplineList.Add(inputDisc);
        }


        public void deleteDiscipline(String name)
        {

        }
    }
}

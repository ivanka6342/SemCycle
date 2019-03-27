using System;
using System.Collections.Generic;
using System.Text;

namespace SemCycle.DataBase
{
    public class Discipline
    {
        private List<Lab> labList;
        private string name;
        private string additional;
        private int numDoneLab;
       
        public Discipline(string n, string a, int l, int dL)
        {
            name = n;
            additional = a;
            labList = new List<Lab>(l);
            numDoneLab = dL;
        }
       /* public Lab getLab(string name)
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
        }*/

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWADFinalAssessment
{
    class StayManager
    {
        public List<SingleStay> singleStays;

        public StayManager()
        {
            singleStays = new List<SingleStay>();
        }

        public void CheckIn(string name, double limit)
        {
            singleStays.Add(new SingleStay(name, limit));
        }

        public double CheckOut(int id)
        {
            double i = 0;

            foreach(SingleStay s in singleStays)
            {
                if(s.id == id)
                {
                    i = s.CheckOut();
                }
            }

            return i;
        }

        public void AddChild(int id, string name)
        {
            foreach (SingleStay s in singleStays)
            {
                if (s.id == id)
                {
                    s.AddChild(name);
                }
            }
        }

        public SingleStay GetSingleStay(int id)
        {
            foreach(SingleStay s in singleStays)
            {
                if(s.id == id)
                {
                    return s;
                }
            }
            return null;
        }

        public int[] GetAllSingleStaysID()
        {
            List<int> list = new List<int>();

            foreach(SingleStay s in singleStays)
            {
                if(s.checkedOut == false)
                {
                    list.Add(s.id);
                }
            }

            return list.ToArray();
        }
    }
}

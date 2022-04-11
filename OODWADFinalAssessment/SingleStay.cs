using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWADFinalAssessment
{
    class SingleStay
    {
        private static int nextStayID = 1000;
        public int id { get; private set; }
        private List<string> names;
        private double limit;
        public bool checkedOut { get; private set; }
        private double currentBill;

        public SingleStay(string name, double limit)
        {
            this.names = new List<string>();
            this.id = nextStayID;
            nextStayID += 10;
            this.names.Add(name);
            this.limit = limit;
            this.checkedOut = false;
            this.currentBill = 0;
        }

        public double CheckOut()
        {
            this.checkedOut = true;
            return this.currentBill;
        }

        public void AddChild(string name)
        {
            this.names.Add(name);
        }

        public bool BuyProduct(double price)
        {
            if(this.limit < (this.currentBill+price))
            {
                return false;
            }else
            {
                this.currentBill += price;
                return true;
            }
        }

        public string GetAllChildren()
        {
            string test = "";

            foreach(string n in names)
            {
                test += n + "  ";
            }

            return test;
        }
    }
}

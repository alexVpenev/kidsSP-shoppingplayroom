using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWADFinalAssessment
{
    class CandiesAndDrinks
    {
        private static int nextProductID = 3000;
        public int id { get; private set; }
        private string name;
        public double price { get; private set; }

        public CandiesAndDrinks(string name, double price)
        {
            this.id = nextProductID;
            nextProductID += 10;
            this.name = name;
            this.price = price;
        }
    }
}

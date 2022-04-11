using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWADFinalAssessment
{
    class ProductManager
    {
        public List<CandiesAndDrinks> CandiesAndDrinks;

        public ProductManager()
        {
            CandiesAndDrinks = new List<CandiesAndDrinks>();
        }

        public void CreateProduct(string name, double price)
        {
            CandiesAndDrinks.Add(new CandiesAndDrinks(name, price));
        }

        public CandiesAndDrinks GetProduct(int id)
        {
            foreach (CandiesAndDrinks p in CandiesAndDrinks)
            {
                if(p.id == id)
                {
                    return p;
                }
            }
            return null;
        }

        public int[] GetAllProductsID()
        {
            List<int> list = new List<int>();

            foreach (CandiesAndDrinks p in CandiesAndDrinks)
            {
                list.Add(p.id);
            }

            return list.ToArray();
        }
    }
}

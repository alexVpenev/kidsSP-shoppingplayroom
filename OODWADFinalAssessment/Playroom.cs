using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODWADFinalAssessment
{
    class Playroom
    {
        public StayManager StayManager;
        public ProductManager ProductManager;

        public Playroom()
        {
            this.StayManager = new StayManager();
            this.ProductManager = new ProductManager();
        }

        public bool BuyProduct(int SingleStayID, int ProductID)
        {
            CandiesAndDrinks prod = ProductManager.GetProduct(ProductID);
            SingleStay stay = StayManager.GetSingleStay(SingleStayID);

            bool test = stay.BuyProduct(prod.price);

            return test;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODWADFinalAssessment
{
    public partial class Form1 : Form
    {
        private Playroom playroom;
        public Form1()
        {
            InitializeComponent();
            playroom = new Playroom();
            LoadSingleStays();
            LoadProducts();
        }

        private void LoadSingleStays()
        {
            AllSingleStayCheckOutCbx.Items.Clear();
            AllSingleStaysCbx.Items.Clear();
            AllSingleStayAddChildCbx.Items.Clear();

            foreach (int i in playroom.StayManager.GetAllSingleStaysID())
            {
                AllSingleStaysCbx.Items.Add(i);
                AllSingleStayCheckOutCbx.Items.Add(i);
                AllSingleStayAddChildCbx.Items.Add(i);
            }
        }

        private void LoadProducts()
        {
            AllProductsCbx.Items.Clear();

            foreach(int i in playroom.ProductManager.GetAllProductsID())
            {
                AllProductsCbx.Items.Add(i);
            }
        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            playroom.StayManager.CheckIn(ChildNameTbx.Text, Convert.ToDouble(LimitTbx.Text));
            LoadSingleStays();
        }

        private void CreateProductTbx_Click(object sender, EventArgs e)
        {
            playroom.ProductManager.CreateProduct(ProductNameTbx.Text, Convert.ToDouble(ProductPriceTbx.Text));
            LoadProducts();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            double bill = playroom.StayManager.CheckOut(Convert.ToInt32(AllSingleStayCheckOutCbx.SelectedItem));
            SingleStay s = playroom.StayManager.GetSingleStay(Convert.ToInt32(AllSingleStayCheckOutCbx.SelectedItem));
            string kids = s.GetAllChildren();
            MessageBox.Show("Checked out, Your bill is " + bill + "!" + "   Children checked out: " + kids);
            LoadSingleStays();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            bool test = playroom.BuyProduct(Convert.ToInt32(AllSingleStaysCbx.SelectedItem), Convert.ToInt32(AllProductsCbx.SelectedItem));

            if (test)
            {
                MessageBox.Show("Product Price added to Bill!");
            }
            else
            {
                MessageBox.Show("Limit has been reached!");
            }
        }

        private void AddChildBtn_Click(object sender, EventArgs e)
        {
            playroom.StayManager.AddChild(Convert.ToInt32(AllSingleStayAddChildCbx.SelectedItem), NewChildTbx.Text);
        }
    }
}

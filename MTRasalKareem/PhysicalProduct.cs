using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MTRasalKareem
{
    public class PhysicalProduct : Product
    {
        private double _weight;
        private double _shippingCost;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public double ShippingCost
        {
            get { return _shippingCost; }
            set { _shippingCost = value; }
        }

        public PhysicalProduct(int productId, string name, double price, double weight, double shippingCost)
            : base(productId, name, price)
        {
            _weight = weight;
            _shippingCost = shippingCost;
        }

        // Method overriding for total price calculation
        public new double TotalPrice()
        {
            return Price + _shippingCost;
        }
    }
}










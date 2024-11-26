using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTRasalKareem
{
    public class Product
    {
        private int _productId;
        private string _name;
        private double _price;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Product(int productId, string name, double price)
        {
            _productId = productId;
            _name = name;
            _price = price;
        }


        public double TotalPrice()
        {
            return _price;
        }
    }
}

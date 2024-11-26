using MTRasalKareem;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MTRasalKareem
{
    /// Product-Tracking-System
    /// Name: Rasal Kareem
    /// Date: 10/07/2024
    /// Student ID: 991673642
    public partial class MainWindow : Window
    {
        private List<PhysicalProduct> _products;

        public MainWindow()
        {
            InitializeComponent();

            _products = new List<PhysicalProduct>()
            {
                new PhysicalProduct(1, "Laptop", 1000, 2.5, 60),
                new PhysicalProduct(2, "Smartphone", 800, 0.5, 20),
                new PhysicalProduct(3, "Camera",600,1.1,30 )
            };
            //Referred from stackoverflow
            lstProducts.ItemsSource = _products;
            lstProducts.DisplayMemberPath = "Name"; 
        }

        private void lstProducts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                
                var selectedProduct = (PhysicalProduct)lstProducts.SelectedItem;

                txtProductId.Text = selectedProduct.ProductId.ToString();
                txtName.Text = selectedProduct.Name;
                txtPrice.Text = selectedProduct.ShippingCost.ToString(); 
            }
        }

        
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                var selectedProduct = (PhysicalProduct)lstProducts.SelectedItem;

               
                txtTotalPrice.Text = selectedProduct.TotalPrice().ToString();
            }
        }

        
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                var selectedProduct = _products[lstProducts.SelectedIndex];
                selectedProduct.ProductId = int.Parse(txtProductId.Text);
                selectedProduct.Name = txtName.Text;
                selectedProduct.ShippingCost = double.Parse(txtPrice.Text); 

                
                lstProducts.Items.Refresh();
            }
        }

        
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

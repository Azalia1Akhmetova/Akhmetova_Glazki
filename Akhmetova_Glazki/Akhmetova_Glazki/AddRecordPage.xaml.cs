using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Akhmetova_Glazki
{
    /// <summary>
    /// Логика взаимодействия для AddRecordPage.xaml
    /// </summary>
    public partial class AddRecordPage : Page
    {
        private ProductSale currentProductSale = new ProductSale();
        Agent CurrentAgent;
        public AddRecordPage(Agent Agent)
        {
            InitializeComponent();

            CurrentAgent = Agent;
            var products = Akhmetova_glazkiEntities.GetContext().Product.ToList();
            Products.ItemsSource = products;
            DataContext = currentProductSale;
        }

        private void Products_TextChanged(object sender, TextChangedEventArgs e)
        {
            Products.IsDropDownOpen = true;
            var products = Akhmetova_glazkiEntities.GetContext().Product.ToList();
            products = products.Where(p => p.Title.ToLower().Contains(Products.Text.ToLower())).ToList();
            Products.ItemsSource = products;
        }

        private void SaveRecord_Click(object sender, RoutedEventArgs e)
        {
            var products = Akhmetova_glazkiEntities.GetContext().Product.ToList();

            currentProductSale.ID = 0;
            currentProductSale.AgentID = CurrentAgent.ID;
            currentProductSale.ProductID = products[Products.SelectedIndex].ID;
            currentProductSale.SaleDate = Convert.ToDateTime(ProductSaleDate.Text);
            currentProductSale.ProductCount = Convert.ToInt32(ProductCount.Text);

            Akhmetova_glazkiEntities.GetContext().ProductSale.Add(currentProductSale);
            Akhmetova_glazkiEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена");
            Manager.MainFrame.GoBack();

        }
    }
}

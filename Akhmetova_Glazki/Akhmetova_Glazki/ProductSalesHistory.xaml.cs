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
    /// Логика взаимодействия для ProductSalesHistory.xaml
    /// </summary>
    public partial class ProductSalesHistory : Page
    {
        Agent currentAgent;

        public ProductSalesHistory(Agent SelectedAgent)
        {
            InitializeComponent();
            currentAgent = SelectedAgent;
            var Sales = Akhmetova_glazkiEntities.GetContext().ProductSale.ToList();
            if(SelectedAgent.ID !=0)
            {
                Sales = Sales.Where(p => p.AgentID == SelectedAgent.ID).ToList();
            }
            Sales_ListView.ItemsSource = Sales;
            DeleteButton.Visibility = Visibility.Collapsed;
        }

        private void Update_Sales()
        {
            var Sales = Akhmetova_glazkiEntities.GetContext().ProductSale.ToList();
            if(currentAgent.ID!=0)
            {
                Sales = Sales.Where(p => p.AgentID == currentAgent.ID).ToList();
            }
            Sales_ListView.ItemsSource = Sales;
        }

        private void Sales_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sales_ListView.SelectedItems.Count == 0)
                DeleteButton.Visibility = Visibility.Collapsed;
            if (Sales_ListView.SelectedItems.Count > 0)
                DeleteButton.Visibility = Visibility.Visible;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddRecordPage(currentAgent));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            List<ProductSale> SelectedSales = Sales_ListView.SelectedItems.Cast<ProductSale>().ToList();
            foreach(ProductSale Sale in SelectedSales)
            {
                Akhmetova_glazkiEntities.GetContext().ProductSale.Remove(Sale);
            }
            Akhmetova_glazkiEntities.GetContext().SaveChanges();
            Update_Sales();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Update_Sales();
        }
    }
}

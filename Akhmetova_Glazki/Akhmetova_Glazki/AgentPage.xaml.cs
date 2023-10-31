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
    /// Логика взаимодействия для AgentPage.xaml
    /// </summary>
    public partial class AgentPage : Page
    {
        public AgentPage()
        {
            InitializeComponent();
            var currentAgents = Akhmetova_glazkiEntities.GetContext().Agent.ToList();
            AgentListView.ItemsSource = currentAgents;
            SortCombo.SelectedIndex = 0;
            FilterCombo.SelectedIndex = 0;

            UpdateAgent();
        }

        private void UpdateAgent()
        {
            var currentAgent = Akhmetova_glazkiEntities.GetContext().Agent.ToList();

            currentAgent = currentAgent.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())|| p.Email.ToLower().Contains(TBoxSearch.Text.ToLower())
            || p.Phone.Replace("+7","8").Replace("(","").Replace(")","").Replace(" ","").Replace("-","").Contains(TBoxSearch.Text)).ToList();

            AgentListView.ItemsSource = currentAgent;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAgent();
        }

        private void SortCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

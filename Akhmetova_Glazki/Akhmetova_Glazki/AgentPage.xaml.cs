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
            //поиск
            currentAgent = currentAgent.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())|| p.Email.ToLower().Contains(TBoxSearch.Text.ToLower())
            || p.Phone.Replace("+7","8").Replace("(","").Replace(")","").Replace(" ","").Replace("-","").Contains(TBoxSearch.Text)).ToList();
            //сортировка
            if(SortCombo.SelectedIndex == 0) 
            {
                currentAgent = currentAgent.OrderBy(p => p.Title).ToList();
            }

            if(SortCombo.SelectedIndex == 1)
            {
                currentAgent = currentAgent.OrderByDescending(p => p.Title).ToList();
            }

            if(SortCombo.SelectedIndex == 4)
            {
                currentAgent = currentAgent.OrderBy(p => p.Priority).ToList();
            }

            if(SortCombo.SelectedIndex == 5)
            {
                currentAgent = currentAgent.OrderByDescending(p => p.Priority).ToList();
            }

            //фильтрация
            switch(FilterCombo.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "МФО").ToList();
                    break;
                case 2:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "ЗАО").ToList();
                    break;
                case 3:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "МКК").ToList();
                    break;
                case 4:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "ООО").ToList();
                    break;
                case 5:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "ОАО").ToList();
                    break;
                case 6:
                    currentAgent = currentAgent.Where(p => p.AgentTypeString.ToString() == "ПАО").ToList();
                    break;
            }

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
            UpdateAgent();
        }

        private void FilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateAgent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

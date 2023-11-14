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
using System.Windows.Shapes;

namespace Akhmetova_Glazki
{
    /// <summary>
    /// Логика взаимодействия для PriorityWindow.xaml
    /// </summary>
    public partial class PriorityWindow : Window
    {
        public PriorityWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TBPriority.Text))
                Close();
            else
                MessageBox.Show("Введите новый приоритет агентов", "Ошибка");
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            TBPriority.Text = "";
            Close();
        }
    }
}

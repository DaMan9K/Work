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

namespace Work.Windows
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        CreditOfficeEntities credit = new CreditOfficeEntities();
        public Manager()
        {
            InitializeComponent();
            Update();
        }
        private void Update()
        {
            DGContr.ItemsSource = credit.Contarct.ToList();
            DGClient.ItemsSource = credit.Clients.ToList();

        }

        private void BTContr_Click(object sender, RoutedEventArgs e)
        {
            GContr.Visibility = Visibility.Visible;
            GClient.Visibility = Visibility.Hidden;
        }

        private void BTСlients_Click(object sender, RoutedEventArgs e)
        {
            GClient.Visibility = Visibility.Visible;
            GContr.Visibility = Visibility.Hidden;
        }
    }
}

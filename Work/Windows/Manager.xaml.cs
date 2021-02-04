using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        private List<int> worker = new List<int>();
        COfficeEntities1 credit  = new COfficeEntities1();   
        
        public Manager()
        {
            InitializeComponent();
          
            Update();
        }
        private void Update()
        {
            

            SProch.Value = 11;
            string Sptest;
            Sptest = SProch.Value.ToString();
            DGContr.ItemsSource = credit.Contarct.ToList();
            DGClient.ItemsSource = credit.Clients.ToList();
            CBCLients.ItemsSource = credit.Clients.Select(x => x.LastName).ToList();
            CBWorker.ItemsSource = credit.Workers.Select(x => x.LastName).ToList();
            CBMouth.ItemsSource = credit.Mouths.Select(x => x.NomberOfMouths).ToString().ToList();

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


        private void BTSave_OnClick(object sender, RoutedEventArgs e)
        {
            Contarct contarct = new Contarct();

        }
    }
}

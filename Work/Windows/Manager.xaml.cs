using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Microsoft.Win32.SafeHandles;

namespace Work.Windows
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    
    public partial class Manager : Window
    { 
        List<int> CBWorkerson = new List<int>();
        List<int> CBClientson = new List<int>();
        COfficeEntities1 credit  = new COfficeEntities1();   
        
        public Manager()
        {
            InitializeComponent();
            Flued();
            Update();
        }

        private void Flued()
        {
           List<Workers> vs = credit.Workers.ToList();
           foreach (var item in vs)
            {
                CBWorker.Items.Add($"{item.LastName} {item.FirstName} {item.SecondName}");
                 CBWorkerson.Add(item.IdWorker);

           }
           List<Clients> ss = credit.Clients.ToList();
           foreach (var iClientse in ss)
           {
               CBCLients.Items.Add($"{iClientse.LastName} {iClientse.FirstName} {iClientse.SecondName}");
               CBClientson.Add(iClientse.IDClients);
           }
        }
        private void Update()
        {
            Workers workers = new Workers();
            Clients clients = new Clients();
            int c = workers.IdWorker;
            int g = 0;
            for (int i = 0; i < CBWorkerson.Count; i++)
            {
                if (CBWorkerson[i] == c)
                    g = i;
            }

            int clientid = clients.IDClients;
            int r = 0;
            for (int s = 0; s < CBClientson.Count; s++)
            {
                if (CBClientson[s] == clientid)
                    r = s;
            }
            credit.SaveChanges();
            CBWorker.SelectedIndex = g;
            SProch.Value = 11;
            string Sptest;
            Sptest = SProch.Value.ToString();
            DGContr.ItemsSource = credit.Contarct.ToList();
            DGClient.ItemsSource = credit.Clients.ToList();
            CBMouth.ItemsSource = credit.Mouths.Select(x => x.NomberOfMouths).ToList();

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
            Contarct contract = new Contarct();
            contract.IdWorker = CBWorkerson[CBWorker.SelectedIndex];
            try
            {
                contract.CreditAmount = Convert.ToDouble(TBCredit.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Вы ввели неверные символы");
            }

            contract.IdClients = CBClientson[CBCLients.SelectedIndex];
            contract.DueDate = CBMouth.Text;
            contract.InterestOnALoan = Convert.ToInt32(TBLPocent.Text);
            credit.Contarct.Add(contract);
             Update();



        }

        private void TBPass_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890".IndexOf(e.Text) < 0;
        }
    }
}

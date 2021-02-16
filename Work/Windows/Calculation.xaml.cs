using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
    /// Логика взаимодействия для Calculation.xaml
    /// </summary>
    public partial class Calculation : Window
    {
        Contarct contractAdd;
        public Calculation(Contarct contract)
        {
            InitializeComponent();
            contractAdd = contract;
            Update();
        }

        public void Update()
        {
            TBLData.Text = contractAdd.AgreementDate.ToString();
            TBLData1.Text = contractAdd.Clients.LastName;
            TBMoney.Text = contractAdd.CreditAmount.ToString();
            TBPorcent.Text = contractAdd.InterestOnALoan.ToString();
            TBLDueData.Text = contractAdd.DueDate.ToString();
        }

        private void TBPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TBPrint.Visibility = Visibility.Hidden;
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
                this.Close();
            }
        }
    }
}

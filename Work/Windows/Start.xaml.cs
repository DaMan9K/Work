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
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    
   
    public partial class Start : Window
    {

        CreditOfficeEntities creditoffice = new CreditOfficeEntities();
        public Start()
        {
            
            InitializeComponent();

        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
       
            Workers m = creditoffice.Workers.Where(c => c.Login == Login.Text && c.Password == Password.Password).SingleOrDefault();
            if(m.Post == "Менеджер")
            {
                Windows.Manager manager = new Windows.Manager();
                manager.Show();
                this.Close();
            }
            else if(m == null)
            {
                MessageBox.Show("Такого пользователя нет");
            }
           
        }
        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

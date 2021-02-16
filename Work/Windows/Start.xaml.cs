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

         COEntities  creditoffice = new COEntities();
        public Start()
        {
            
            InitializeComponent();

        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {

       
            var m = creditoffice.Workers.SingleOrDefault(c => c.Login == Login.Text && c.Password == Password.Password);
            if (m == null)
            {
                MessageBox.Show("такого пользователя нет");
            }
            else if (m.Post == "Менеджер")
            {
                var manager = new Manager();
                manager.Show();
                this.Close();
            } 
            
           
        }
        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

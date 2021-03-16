using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

         CreditEntities  creditoffice = new CreditEntities();

        public Start()
        {
            
            InitializeComponent();

        }
        public static bool CheckBoxTB(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
            {
                tb.BorderBrush = Brushes.Red;
                
                
                return true;
            }
          
            else
            {
                
                tb.BorderBrush = Brushes.Gray;
                return false;
            }
        }
        public static bool CheckBoxPB(PasswordBox pb)
        {
            if (String.IsNullOrEmpty(pb.Password))
            {
                pb.BorderBrush = Brushes.Red;
                
                return true;
            }
            else
            {
                pb.BorderBrush = Brushes.Gray;
                return false;
            }
        }
        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            
            if (CheckBoxTB(Login) || CheckBoxPB(Password))
            {
                MessageBox.Show("Вы не заполнили все поля");
            }
            else
            {
                var m = creditoffice.Workers.SingleOrDefault(c => c.Login == Login.Text && c.Password == Password.Password);
                if (m == null) MessageBox.Show("такого пользователя нет");             
                else if (m.Post == "Менеджер")
                {
                    Manager manager = new Manager(m);
                    manager.Show();
                    this.Close();
                }
            }
        }
        private void BTBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

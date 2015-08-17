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

namespace InjectionPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoftUniEntities softuniContext;
        public MainWindow()
        {
            InitializeComponent();
            softuniContext = new SoftUniEntities();
        }

        private void buttonPesho_Click(object sender, RoutedEventArgs e)
        {
            string address = this.textboxPesho.Text;
            softuniContext.Database.ExecuteSqlCommand("INSERT into Addresses (AddressText, TownID) VALUES ('" + address + "', 4)");
            softuniContext.SaveChanges();
            





        }
    }
}

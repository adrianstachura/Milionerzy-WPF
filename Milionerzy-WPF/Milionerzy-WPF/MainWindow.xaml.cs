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

namespace Milionerzy_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string name;
        private void button_Start(object sender, RoutedEventArgs e)
        {
            string namecheck = namebox.Text;
            if(namecheck != "Wprowadz imie" && namecheck != String.Empty)
            {

            name = namebox.Text;
            Window gWindow = new GameWindow();
            gWindow.Show();
            this.Close();
            }
            else
            {
                
                MessageBox.Show("Wprowadz imie!");
            }
        }
        private void button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}

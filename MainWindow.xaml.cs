/*
 *Josh Degazio
 *Feb 8, 2018
 *Output
 *User inputs a "name", the system then greets the user, using their name
*/
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

namespace U1_02_JoshOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
        }

        private void btnshowgreeting_Click(object sender, RoutedEventArgs e)
        {
            lbloutput.Content = "Hey, " + entryname.Text;
        }
    }
}

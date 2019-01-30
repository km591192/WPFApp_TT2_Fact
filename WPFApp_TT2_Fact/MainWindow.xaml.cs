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

namespace WPFApp_TT2_Fact
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Factorial factorial = new Factorial();

        private int N = 0;
        private string S = String.Empty;


        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            N = Convert.ToInt32(tbNumber.Text);
            factorial.checkn(N);
            tbMsg.Text += factorial.S + "\n";
            factorial.rev_Fact(N);
            factorial.check_correct_answer(N);
            tbMsg.Text += factorial.S + "\n";

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tbNumber.Text = String.Empty;
            tbMsg.Text = String.Empty;
        }
    }
}

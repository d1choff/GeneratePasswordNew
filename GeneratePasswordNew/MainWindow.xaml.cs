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

namespace GeneratePasswordNew
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

        public string GetPass()
        {
            string result = "";
            Random rnd = new Random();
            string[] abc = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0","q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "!", "@", "#", "$", "%", "^", "&", "*", "("};
            string Num = "0123456789";
            int Numbers = Convert.ToInt32(tbLengthPass.Text);

            if (rbUppWords.IsChecked == true)
            {
                for (int i = 0; i < Numbers; i++)
                    result += abc[rnd.Next(abc.Length)].ToUpper();
            }
            if(rbLowWords.IsChecked == true)
            {
                for (int i = 0; i < Numbers; i++)
                    result += abc[rnd.Next(abc.Length)].ToLower();
            }
            if(rbSimple.IsChecked == true) 
            { 
            for (int i = 0; i < Numbers; i++)
                result += abc[rnd.Next(abc.Length)];
            }
            if (rbNum.IsChecked == true)
            {
                for (int i = 0; i < Numbers; i++)
                    result += Num[rnd.Next(Num.Length)];
            }

            return result;
        }

        private void btnGenPass_Click(object sender, RoutedEventArgs e)
        {
            tbOutPasswords.Text = GetPass();
        }
    }
}

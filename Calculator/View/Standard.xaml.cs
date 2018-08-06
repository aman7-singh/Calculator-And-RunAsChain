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

namespace Calculator.View
{
    /// <summary>
    /// Interaction logic for Standard.xaml
    /// </summary>
    public partial class Standard : UserControl
    {
        public Standard()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Expression.Text += "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Expression.Text += "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Expression.Text += "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Expression.Text += "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Expression.Text += "5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Expression.Text += "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Expression.Text += "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Expression.Text += "8";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Expression.Text += "9";
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Expression.Text += "0";
        }
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            Expression.Text = CalculatedVal.Text + ".";
        }
        private void Button_Click_Sign(object sender, RoutedEventArgs e)
        {
            if (Expression.Text.StartsWith("-"))
            {
                Expression.Text = Expression.Text.Substring(1, Expression.Text.Length - 1);
                Expression.Text = Expression.Text;
            }
            else
            {
                Expression.Text = "-Logic need to implimented. Please Clear and proceed." + Expression.Text;
            }
        }
        private void Button_Click_Reminder(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Button_Click_sqrt(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Button_Click_check(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Expression.Text))
            {
                Expression.Text = Expression.Text.Substring(0, Expression.Text.Length - 1);
            }
            else
            {
                Expression.Text = "0";
            }
        }

    }
}

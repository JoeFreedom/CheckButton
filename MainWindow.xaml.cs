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

namespace ExaminationCheckButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score;
        string NameExaminant;
        string SexExaminant;
        bool IsItalyChecked = false;
        bool IsLondonChecked = false;
        bool IsAbujaChecked = false;
        bool IsNewYorkChecked = false;
        bool IsLisbonChecked = false;
        bool IsYes = false;
        bool IsNo = false;
        public MainWindow()
        {
           InitializeComponent();
        }
        private void button_Submit(object sender, RoutedEventArgs e)
        {
            NameExaminant = textBox_Name.Text;
            SexExaminant = textBox_Sex.Text;

            if(IsAbujaChecked && IsLisbonChecked && IsLondonChecked && IsYes)  // To-DO
            {
                MessageBox.Show(NameExaminant + " you chose ALL answers correctly");
                MessageBox.Show("Your score is  4 over 4");
            }
            else if(IsNo || IsNewYorkChecked || IsItalyChecked)
            {
                MessageBox.Show("Click CANCEL to re-check your answers or OK to submit.", "Hint", MessageBoxButton.OKCancel);
            }
            else
            {
                MessageBox.Show("You can't be graded UNLESS you choose an/some answer(s)!");
            }
        }
        private void checkBox_Italy_Checked(object sender, RoutedEventArgs e)
        {
            IsItalyChecked = true;
        }
        private void checkBox_Italy_Unchecked(object sender, RoutedEventArgs e)
        {
            IsItalyChecked = false;
        }
        private void checkBox_London_Checked(object sender, RoutedEventArgs e)
        {
            IsLondonChecked = true;
            score++;
        }
        private void checkBox_London_Unchecked(object sender, RoutedEventArgs e)
        {
            IsLondonChecked = false;
        }
        private void checkBox_Abuja_Checked(object sender, RoutedEventArgs e)
        {
            IsAbujaChecked = true;
            score++;
        }
        private void checkBox_Abuja_Unchecked(object sender, RoutedEventArgs e)
        {
            IsAbujaChecked = false;
        }
        private void checkBox_NewYork_Checked(object sender, RoutedEventArgs e)
        {
            IsNewYorkChecked = true;
        }
        private void checkBox_NewYork_Unchecked(object sender, RoutedEventArgs e)
        {
            IsNewYorkChecked = false;
        }
        private void checkBox_Lisbon_Checked(object sender, RoutedEventArgs e)
        {
            IsLisbonChecked = true;
            score++;
        }
        private void checkBox_Lisbon_Unchecked(object sender, RoutedEventArgs e)
        {
            IsLisbonChecked = false;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            IsYes = true;
            score++;

            IsNo = false;
            score--;
        }
    }
}

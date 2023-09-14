using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

namespace BindowanieWpfAppp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string SourceValue { get; set; }
        public string StringNumberOfDay { get; set; }
        
        public string NameDayOfWeek
        { 
            get
            {
                return NameDayOfWeek;
            }
            set
            {
                NameDayOfWeek = value;
            }
       
        
        }




        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = textBoxInfo.Text;
            textBlockWynik.Text = value;
        }

        private void textBoxInfo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = textBoxInfo.Text;
            textBlockWynik.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("zawartość: " + SourceValue);
        }

        private void ButtonShowDayOfWeek_Click(object sender, RoutedEventArgs e)
        {
            switch (StringNumberOfDay)
            {
                case "1":
                    NameDayOfWeek = "Poniedzialek";
                    OnPropertyChanged("NameDayOfWeek");
                    break;
                case "2":
                    NameDayOfWeek = "Wtorek";
                    break;
                case "3":
                    NameDayOfWeek = "Środa";
                    break;
                case "4":
                    NameDayOfWeek = "Czwartek";
                    break;
                case "5":
                    NameDayOfWeek = "Piątek";
                    break;
                default:
                    NameDayOfWeek = "Zła dana";
                    break;







            }
        }
    }
}


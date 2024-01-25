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

namespace ListaRzeczy.wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string newItem = DaneTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newItem))
            {
                ListaZakupow.Items.Add($"- {newItem}");
                DaneTextBox.Clear();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)


        {
            string selectedItem = ListaZakupow.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedItem))
            {
                ListaZakupow.Items.Remove(selectedItem);
            }

}     
    }
}

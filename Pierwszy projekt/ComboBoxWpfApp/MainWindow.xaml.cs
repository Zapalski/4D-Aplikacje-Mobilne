﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ComboBoxWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<string> ItemsList { get; set; }

        public string NewPosition { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


        public MainWindow()
        {
            InitializeComponent();
            ItemsList = new ObservableCollection<string>();
            OnPropertyChanged(nameof(ItemsList));

            ItemsList.Add("Pozycja bindowania 1");
            ItemsList.Add("Pozycja bindowania 2");
            ItemsList.Add("Pozycja bindowania 3");
        }

        private void ButtonNewComboBoxPosition_Click(object sender, RoutedEventArgs e)
        {
          ItemsList.Add(NewPosition);
        }
    }   
}

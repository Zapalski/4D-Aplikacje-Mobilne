﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UtilsWpf
{
    public class ObserverVM :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

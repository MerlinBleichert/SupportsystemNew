﻿using PropertyChanged;
using System.ComponentModel;
using System.Windows;

namespace Supportsystem
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };
    }
}

using Roster.Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(() => Title = "Roster App (v2.0)");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        string title = "Roster App";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged("Title");

                }
            }
        }

        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>() { new Person() { Name = "Delores Feil", Company = "Legros Group" }, new Person() { Name = "Ann Zboncak", Company = "Ledner - Ferry" }, new Person() { Name = "Jaime Lesch", Company = "Herzog and Sons" } };//Delores Feil | Legros Group | | Ann Zboncak | Ledner - Ferry | | Jaime Lesch | Herzog and Sons

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command UpdateApplicationCommand
        {
            get;
        }
    }
}

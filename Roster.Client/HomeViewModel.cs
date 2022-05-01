using System;
using System.Collections.Generic;
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

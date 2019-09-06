using Prism.Mvvm;
using System;

namespace TaskBook.WPF
{
    public class ToDoItem : BindableBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;
                RaisePropertyChanged();
            }
        }

        private DateTime due;

        public DateTime Due
        {
            get { return due; }
            set { due = value;
                RaisePropertyChanged();
            }
        }


    }
}
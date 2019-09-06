using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook.WPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            AddNewTask = new DelegateCommand(
                () =>
                {
                    //execute
                    
                },
                () =>
                {
                    //can execute                    
                    return !string.IsNullOrEmpty(NewTaskName) && NewTaskDue > DateTime.MinValue;
                });
            ToDoList = new ObservableCollection<ToDoItem>();
            ToDoList.Add(new ToDoItem { Name = "DEMO" });
        }

        
        private string newTaskName;

        public string NewTaskName
        {
            get { return newTaskName; }
            set { newTaskName = value;
                RaisePropertyChanged();
                AddNewTask.RaiseCanExecuteChanged();
            }
        }

        private DateTime newTaskDue;

        public DateTime NewTaskDue
        {
            get { return newTaskDue; }
            set { newTaskDue = value;
                RaisePropertyChanged();
                AddNewTask.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<ToDoItem> toDoList;

        public ObservableCollection<ToDoItem> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public DelegateCommand AddNewTask { get; }



    }
}

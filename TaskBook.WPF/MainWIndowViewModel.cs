using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskBook.WPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            ToDoList = new ObservableCollection<ToDoItem>();           


            AddNewTask = new DelegateCommand(
                () =>
                {
                    //execute
                    //string message = "ADDED TODO";
                    //MessageBox.Show(message);
                    ToDoList.Add(new ToDoItem { Name = NewTaskName + " ~ ", Due = NewTaskDue });
                    NewTaskName = null;
                    //NewTaskDue = default;
                },
                () =>
                {
                    //can execute                    
                    return !string.IsNullOrEmpty(NewTaskName) && NewTaskDue > DateTime.MinValue;
                });

            //CompletedTask = new DelegateCommand(
            //    () =>
            //    {
            //        //execute
            //        string message = "Completed Task";
            //        MessageBox.Show(message);

            //    },
            //    () =>
            //    {
            //        //can execute
            //        return true;
            //    });


            //ToDoList = new ObservableCollection<ToDoItem>();
            //ToDoList.Add(new ToDoItem { Name = "DEMO" });
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

        //public DelegateCommand CompletedTask { get; }

        public DelegateCommand AddNewTask { get; }



    }
}

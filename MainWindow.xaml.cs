using System.Collections.Generic;
using System.Windows;
using System.Data.SQLite;
using System.ComponentModel;
using System;
using System.Windows.Input;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        protected void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TodoItem task = new TodoItem() {Title = taskBox.Text};
            icTodoList.Items.Add(task);
            taskBox.Clear();
        }

        private void btnDelTask_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Delete clicked");
            icTodoList.Items.Remove(icTodoList.SelectedItem);
        }
    }

    public class TodoItem
    { 
        public string Title { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}

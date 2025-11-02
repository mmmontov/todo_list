using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace todo_list
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<TodoItem> tasks = new List<TodoItem>();
        readonly string filePath = "tasks.json";


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
            Console.Write("load main form");
            updateDatesList();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksToFile();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            
            AddTaskForm addTaskForm = new AddTaskForm();

            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                string taskText = addTaskForm.taskText;
                DateTime taskDate = addTaskForm.taskDateTime;
                DateTime taskCreateTime = addTaskForm.taskCreateTime;
                string taskTitle = addTaskForm.taskName;
                AddTaskToList(taskText, taskDate, taskCreateTime, taskTitle);
            }

            updateDatesList();
        }


        public void AddTaskToList(string text, DateTime date, DateTime createdTime, string title)
        {
            TodoItem task = new TodoItem
            {
                Text = text,
                Date = date,
                IsDone = false,
                Title = title,
                CreatedTime = createdTime
            };
            tasks.Add(task);
            UpdateTaskList();
            SaveTasksToFile();
        }

        public void SaveTasksToFile()
        {
            tasks = tasks.OrderBy(t => t.Date).ToList();
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<TodoItem> all_tasks = new List<TodoItem>();

                all_tasks = JsonConvert.DeserializeObject<List<TodoItem>>(json) ?? new List<TodoItem>();
                foreach (var task in all_tasks)
                {
                    if (!task.IsDone)
                    {
                        tasks.Add(task);
                    }
                }

                tasksList.Items.Clear();
                foreach (var task in tasks)
                {
                    if (!task.IsDone)
                    {
                        tasksList.Items.Add(task);
                    }
                }
            }
        }



        public void UpdateTaskList()
        {
            var filteredTasks = tasks;
            if (datesList.SelectedItem != null)
            {
                DateTime selectedTime = DateTime.ParseExact(datesList.SelectedItem.ToString(), "dd.MM.yyyy", null);


                filteredTasks = tasks.Where(t => t.Date.Date == selectedTime).ToList();
            }


            tasksList.Items.Clear();
            foreach (var task in filteredTasks)
            {
                tasksList.Items.Add(task);
            }
        }

        public void updateDatesList()
        {
            datesList.Items.Clear();
            var dates = tasks.Select(t => t.Date.Date).Distinct().OrderBy(d => d);

            foreach (var date in dates)
            {
                datesList.Items.Add(date.ToString("dd.MM.yyyy"));
            }
        }


        private void tasksList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tasksList.SelectedItem is TodoItem selectedTask)
                {
                    selectedTask.IsDone = !selectedTask.IsDone;
                    UpdateTaskList();
                    SaveTasksToFile();
                }
            }

        }
        private void datesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datesList.SelectedItem == null)
            {
                return;
            }

            UpdateTaskList();
        }

        private void resetDateButton_Click(object sender, EventArgs e)
        {
            datesList.ClearSelected();
            UpdateTaskList();
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void reloadTasks_Click(object sender, EventArgs e)
        {
            List<TodoItem> new_tasks = new List<TodoItem>();

            foreach (var task in tasks)
            {
                if (!task.IsDone)
                {
                    new_tasks.Add(task);
                }
            }
            tasks = new_tasks;
            UpdateTaskList();
            updateDatesList();
        }


        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.DarkRed;
        }


        private void tasksList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = tasksList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    tasksList.SelectedIndex = index;

                    if (tasksList.SelectedItem is TodoItem selectedTask)
                    {
                        ViewTaskForm viewForm = new ViewTaskForm(selectedTask);
                        viewForm.Show();
                    }
                }
            }
        }



        public class TodoItem
        {
            public string Text { get; set; }
            public DateTime Date { get; set; }
            public bool IsDone { get; set; }
            public string Title { get; set; }
            public DateTime CreatedTime { get; set; }



            public override string ToString()
            {
                string isDone = IsDone ? "🗹 " : "▢ ";
                return $"{isDone} {Date: HH:mm} - {Title}";
            }
        }

        
    }
}

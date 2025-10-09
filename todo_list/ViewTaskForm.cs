using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static todo_list.MainForm;

namespace todo_list
{
    public partial class ViewTaskForm : Form
    {
        public ViewTaskForm(TodoItem task) 
        {
            if (task != null)
            {
                taskTitleTextBox.Text = task.Text;
                label1.Text = $"Время создания: {task.CreatedTime:dd.MM.yyyy HH:mm}";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void show_info(TodoItem task)
        {
            if (task == null) return;
            taskTitleTextBox.Text = task.Text;
            label1.Text = $"Время создания: {task.CreatedTime:dd.MM.yyyy HH:mm}";
        }
    }
}

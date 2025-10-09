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
            InitializeComponent();
            if (task != null)
            {
                taskTitleLabel.Text = task.Title;
                taskTextBox.Text = task.Text;
                createdDateLabel.Text = $"Дата создания: {task.CreatedTime:dd.MM.yyyy}";
                createdTimeLabel.Text = $"Время создания: {task.CreatedTime:HH:mm}";
                taskDateLabel.Text = $"Запланировано на {task.Date:dd.MM.yyyy} в {task.Date:HH:mm}";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

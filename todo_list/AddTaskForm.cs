using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo_list
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string taskText { get; private set; }
        public DateTime taskDateTime { get; private set; }


        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            taskText = taskTextBox.Text;
            taskDateTime = taskDate.Value.Date.AddHours((int)taskHour.Value).AddMinutes((int)taskMinute.Value);
            if (taskText == "")
            {
                MessageBox.Show("Введите текст задачи");
                return;
            }
            DialogResult = DialogResult.OK;
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.DarkRed;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void taskHour_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

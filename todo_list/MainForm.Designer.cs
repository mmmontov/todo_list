using System.Windows.Forms;

namespace todo_list
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Label();
            this.tasksList = new System.Windows.Forms.ListBox();
            this.datesList = new System.Windows.Forms.ListBox();
            this.resetDateButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadTasks = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Crimson;
            this.closeButton.Location = new System.Drawing.Point(431, 22);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(37, 42);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // tasksList
            // 
            this.tasksList.BackColor = System.Drawing.Color.White;
            this.tasksList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksList.FormattingEnabled = true;
            this.tasksList.ItemHeight = 30;
            this.tasksList.Location = new System.Drawing.Point(47, 223);
            this.tasksList.Name = "tasksList";
            this.tasksList.Size = new System.Drawing.Size(421, 364);
            this.tasksList.TabIndex = 1;
            this.tasksList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tasksList_MouseClick);
            this.tasksList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tasksList_MouseDown);
            // 
            // datesList
            // 
            this.datesList.BackColor = System.Drawing.Color.White;
            this.datesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datesList.ColumnWidth = 200;
            this.datesList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesList.FormattingEnabled = true;
            this.datesList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datesList.ItemHeight = 25;
            this.datesList.Location = new System.Drawing.Point(47, 98);
            this.datesList.Name = "datesList";
            this.datesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datesList.Size = new System.Drawing.Size(421, 77);
            this.datesList.TabIndex = 3;
            this.datesList.SelectedIndexChanged += new System.EventHandler(this.datesList_SelectedIndexChanged);
            // 
            // resetDateButton
            // 
            this.resetDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.resetDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetDateButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDateButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.resetDateButton.Location = new System.Drawing.Point(177, 165);
            this.resetDateButton.Name = "resetDateButton";
            this.resetDateButton.Size = new System.Drawing.Size(268, 30);
            this.resetDateButton.TabIndex = 4;
            this.resetDateButton.Text = "Все задачи";
            this.resetDateButton.UseVisualStyleBackColor = false;
            this.resetDateButton.Click += new System.EventHandler(this.resetDateButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainPanel.Controls.Add(this.resetDateButton);
            this.mainPanel.Controls.Add(this.datesList);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.reloadTasks);
            this.mainPanel.Controls.Add(this.addTaskButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(508, 662);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 3);
            this.panel1.TabIndex = 5;
            // 
            // reloadTasks
            // 
            this.reloadTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.reloadTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadTasks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadTasks.ForeColor = System.Drawing.Color.Cornsilk;
            this.reloadTasks.Location = new System.Drawing.Point(224, 607);
            this.reloadTasks.Name = "reloadTasks";
            this.reloadTasks.Size = new System.Drawing.Size(244, 27);
            this.reloadTasks.TabIndex = 4;
            this.reloadTasks.Text = "Удалить выполненные задачи";
            this.reloadTasks.UseVisualStyleBackColor = false;
            this.reloadTasks.Click += new System.EventHandler(this.reloadTasks_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.addTaskButton.Location = new System.Drawing.Point(47, 29);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(183, 35);
            this.addTaskButton.TabIndex = 3;
            this.addTaskButton.Text = "Добавить задачу";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 662);
            this.Controls.Add(this.tasksList);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.ListBox tasksList;
        private System.Windows.Forms.ListBox datesList;
        private System.Windows.Forms.Button resetDateButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addTaskButton;
        private Button reloadTasks;
        private Panel panel1;
    }
}
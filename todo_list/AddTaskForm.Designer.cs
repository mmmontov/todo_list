namespace todo_list
{
    partial class AddTaskForm
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
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.saveTaskButton = new System.Windows.Forms.Button();
            this.taskDate = new System.Windows.Forms.DateTimePicker();
            this.taskHour = new System.Windows.Forms.NumericUpDown();
            this.taskMinute = new System.Windows.Forms.NumericUpDown();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskTitleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskMinute)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Crimson;
            this.closeButton.Location = new System.Drawing.Point(483, 10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 54);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTextBox.Location = new System.Drawing.Point(29, 238);
            this.taskTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskTextBox.MaxLength = 35;
            this.taskTextBox.Multiline = true;
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(501, 125);
            this.taskTextBox.TabIndex = 2;
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.saveTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTaskButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaskButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.saveTaskButton.Location = new System.Drawing.Point(169, 518);
            this.saveTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.Size = new System.Drawing.Size(199, 52);
            this.saveTaskButton.TabIndex = 3;
            this.saveTaskButton.Text = "Сохранить";
            this.saveTaskButton.UseVisualStyleBackColor = false;
            this.saveTaskButton.Click += new System.EventHandler(this.saveTaskButton_Click);
            // 
            // taskDate
            // 
            this.taskDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDate.Location = new System.Drawing.Point(127, 371);
            this.taskDate.Margin = new System.Windows.Forms.Padding(4);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(300, 36);
            this.taskDate.TabIndex = 5;
            // 
            // taskHour
            // 
            this.taskHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskHour.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskHour.Location = new System.Drawing.Point(92, 456);
            this.taskHour.Margin = new System.Windows.Forms.Padding(4);
            this.taskHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.taskHour.Name = "taskHour";
            this.taskHour.Size = new System.Drawing.Size(160, 32);
            this.taskHour.TabIndex = 8;
            this.taskHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taskHour.ValueChanged += new System.EventHandler(this.taskHour_ValueChanged);
            // 
            // taskMinute
            // 
            this.taskMinute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMinute.Location = new System.Drawing.Point(303, 456);
            this.taskMinute.Margin = new System.Windows.Forms.Padding(4);
            this.taskMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.taskMinute.Name = "taskMinute";
            this.taskMinute.Size = new System.Drawing.Size(160, 32);
            this.taskMinute.TabIndex = 9;
            this.taskMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.taskTitleTextBox);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.taskTextBox);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.saveTaskButton);
            this.mainPanel.Controls.Add(this.taskMinute);
            this.mainPanel.Controls.Add(this.taskDate);
            this.mainPanel.Controls.Add(this.taskHour);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(545, 630);
            this.mainPanel.TabIndex = 10;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(7, 624);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 6);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(538, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 624);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 6);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 630);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Задача:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Минуты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Часы:";
            // 
            // taskTitleTextBox
            // 
            this.taskTitleTextBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleTextBox.Location = new System.Drawing.Point(29, 101);
            this.taskTitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskTitleTextBox.MaxLength = 16;
            this.taskTitleTextBox.Multiline = true;
            this.taskTitleTextBox.Name = "taskTitleTextBox";
            this.taskTitleTextBox.Size = new System.Drawing.Size(501, 94);
            this.taskTitleTextBox.TabIndex = 17;
            this.taskTitleTextBox.TextChanged += new System.EventHandler(this.taskTitleTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название задачи:";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 630);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.taskHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskMinute)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button saveTaskButton;
        private System.Windows.Forms.DateTimePicker taskDate;
        private System.Windows.Forms.NumericUpDown taskHour;
        private System.Windows.Forms.NumericUpDown taskMinute;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taskTitleTextBox;
    }
}
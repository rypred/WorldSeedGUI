namespace WorldSeedGUI
{
    partial class EnvironmentWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            comboBoxMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 123);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Date";
            // 
            // button1
            // 
            button1.Location = new Point(235, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.Click += button1_Click_1;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "month1", "month2", "month3", "month4", "month5", "month6", "month7", "month8", "month9", "month10", "month11", "month12", "month13", "month14" });
            comboBoxMonth.Location = new Point(41, 97);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(121, 23);
            comboBoxMonth.TabIndex = 2;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            comboBoxMonth.SelectionChangeCommitted += comboBoxMonth_SelectedIndexChanged;
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35" });
            comboBoxDay.Location = new Point(168, 97);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(61, 23);
            comboBoxDay.TabIndex = 3;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            comboBoxDay.SelectionChangeCommitted += comboBoxDay_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Weather:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 79);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 79);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 6;
            label4.Text = "Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 150);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxMonth);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public static Label label1;
    }
}
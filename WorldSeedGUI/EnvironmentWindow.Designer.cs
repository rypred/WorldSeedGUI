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
            button1 = new Button();
            comboBoxMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            LocationDropdown = new ComboBox();
            location = new Label();
            label1 = new Label();
            welcome2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(237, 191);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.Click += button1_Click_1;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "Ayles", "Attas", "Neldes", "Elkes", "Levanus", "Cantas", "Enques", "Kirrus", "Toltos", "Nertës", "Selthas", "Heldas", "Minquës", "Yunquës" });
            comboBoxMonth.Location = new Point(43, 191);
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
            comboBoxDay.Location = new Point(170, 191);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(61, 23);
            comboBoxDay.TabIndex = 3;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            comboBoxDay.SelectionChangeCommitted += comboBoxDay_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 173);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Month:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 173);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Day:";
            // 
            // LocationDropdown
            // 
            LocationDropdown.FormattingEnabled = true;
            LocationDropdown.Items.AddRange(new object[] { "Wugrad", "Barjarn", "Dawnridge" });
            LocationDropdown.Location = new Point(43, 102);
            LocationDropdown.Name = "LocationDropdown";
            LocationDropdown.Size = new Size(269, 23);
            LocationDropdown.TabIndex = 7;
            LocationDropdown.SelectedIndexChanged += LocationDropdown_SelectedIndexChanged;
            // 
            // location
            // 
            location.AutoSize = true;
            location.Location = new Point(43, 84);
            location.Name = "location";
            location.Size = new Size(56, 15);
            location.TabIndex = 8;
            location.Text = "Location:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 9;
            label1.Text = "Welcome to Anacaea! ";
            // 
            // welcome2
            // 
            welcome2.AutoSize = true;
            welcome2.Location = new Point(97, 47);
            welcome2.Name = "welcome2";
            welcome2.Size = new Size(162, 15);
            welcome2.TabIndex = 10;
            welcome2.Text = "Where and when is the party?";
            // 
            // EnvironmentWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 282);
            Controls.Add(welcome2);
            Controls.Add(label1);
            Controls.Add(location);
            Controls.Add(LocationDropdown);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxMonth);
            Controls.Add(button1);
            Name = "EnvironmentWindow";
            Text = "Form1";
            Load += EnvironmentWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDay;
        private Label label3;
        private Label label4;
        private ComboBox LocationDropdown;
        private Label location;
        private Label label1;
        private Label welcome2;
    }
}
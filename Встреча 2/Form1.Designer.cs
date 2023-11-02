namespace Встреча_2
{
    partial class Form1
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
            monthCalendar1 = new MonthCalendar();
            TBDay = new TextBox();
            TBMonth = new TextBox();
            TBYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(537, 59);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // TBDay
            // 
            TBDay.Location = new Point(59, 62);
            TBDay.Name = "TBDay";
            TBDay.Size = new Size(34, 27);
            TBDay.TabIndex = 1;
            // 
            // TBMonth
            // 
            TBMonth.Location = new Point(135, 62);
            TBMonth.Name = "TBMonth";
            TBMonth.Size = new Size(42, 27);
            TBMonth.TabIndex = 2;
            // 
            // TBYear
            // 
            TBYear.Location = new Point(221, 62);
            TBYear.Name = "TBYear";
            TBYear.Size = new Size(94, 27);
            TBYear.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 69);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 4;
            label1.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 69);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 5;
            label2.Text = ".";
            // 
            // button1
            // 
            button1.Location = new Point(135, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBYear);
            Controls.Add(TBMonth);
            Controls.Add(TBDay);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox TBDay;
        private TextBox TBMonth;
        private TextBox TBYear;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
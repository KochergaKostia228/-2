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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TBName = new TextBox();
            TBSoname = new TextBox();
            TBSurname = new TextBox();
            CBGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            TBStatus = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Soname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 109);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 143);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 183);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 4;
            label5.Text = "Year and data birsday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 222);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Family status";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 261);
            label7.Name = "label7";
            label7.Size = new Size(272, 20);
            label7.TabIndex = 6;
            label7.Text = "Additional Information (not necessarily)";
            label7.Click += label7_Click;
            // 
            // TBName
            // 
            TBName.Location = new Point(137, 35);
            TBName.Name = "TBName";
            TBName.Size = new Size(125, 27);
            TBName.TabIndex = 7;
            // 
            // TBSoname
            // 
            TBSoname.Location = new Point(137, 70);
            TBSoname.Name = "TBSoname";
            TBSoname.Size = new Size(125, 27);
            TBSoname.TabIndex = 8;
            // 
            // TBSurname
            // 
            TBSurname.Location = new Point(137, 106);
            TBSurname.Name = "TBSurname";
            TBSurname.Size = new Size(125, 27);
            TBSurname.TabIndex = 9;
            // 
            // CBGender
            // 
            CBGender.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CBGender.FormattingEnabled = true;
            CBGender.Location = new Point(137, 140);
            CBGender.Name = "CBGender";
            CBGender.Size = new Size(125, 28);
            CBGender.TabIndex = 10;
            CBGender.SelectedIndexChanged += CBGender_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(207, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // TBStatus
            // 
            TBStatus.Location = new Point(151, 219);
            TBStatus.Name = "TBStatus";
            TBStatus.Size = new Size(125, 27);
            TBStatus.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 27);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(250, 326);
            button1.Name = "button1";
            button1.Size = new Size(178, 59);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 433);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(TBStatus);
            Controls.Add(dateTimePicker1);
            Controls.Add(CBGender);
            Controls.Add(TBSurname);
            Controls.Add(TBSoname);
            Controls.Add(TBName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TBName;
        private TextBox TBSoname;
        private TextBox TBSurname;
        private ComboBox CBGender;
        private DateTimePicker dateTimePicker1;
        private TextBox TBStatus;
        private TextBox textBox2;
        private Button button1;
    }
}
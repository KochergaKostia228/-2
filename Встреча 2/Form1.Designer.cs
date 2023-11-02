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
            DTStart = new DateTimePicker();
            DTEnd = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // DTStart
            // 
            DTStart.Location = new Point(97, 103);
            DTStart.Name = "DTStart";
            DTStart.Size = new Size(250, 27);
            DTStart.TabIndex = 0;
            DTStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // DTEnd
            // 
            DTEnd.Location = new Point(432, 103);
            DTEnd.Name = "DTEnd";
            DTEnd.Size = new Size(250, 27);
            DTEnd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 279);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "days";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(342, 194);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
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
            Controls.Add(label1);
            Controls.Add(DTEnd);
            Controls.Add(DTStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DTStart;
        private DateTimePicker DTEnd;
        private Label label1;
        private Button button1;
    }
}
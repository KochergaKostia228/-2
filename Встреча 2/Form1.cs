namespace Встреча_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(DTStart.Text);
            DateTime end = DateTime.Parse(DTEnd.Text);
            double days = (end - start).TotalDays;
            label1.Text = days.ToString() + " days";
        }
    }
}
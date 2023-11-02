namespace Встреча_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TBDay.Text != "" && TBMonth.Text != "" && TBYear.Text != "")
            {
                string data = TBDay.Text + "." + TBMonth.Text + "." + TBYear.Text;
                DateTime dt = DateTime.Parse(data);
                monthCalendar1.TodayDate=dt;
            }
        }
    }
}
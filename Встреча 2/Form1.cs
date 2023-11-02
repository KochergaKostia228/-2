namespace Встреча_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CBGender.Items.Add("Mate");
            CBGender.Items.Add("Female");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CBGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBSoname.Text != "" && TBSurname.Text != "" && CBGender.Text != "" && TBStatus.Text != "")
            {
                MessageBox.Show("data saved successfully");
            }
            else
            {
                MessageBox.Show("you did not fill in all the data");
            }
        }
    }
}
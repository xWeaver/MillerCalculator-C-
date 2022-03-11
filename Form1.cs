namespace MillerCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var startDate =
                    dateTimePicker1.Value;

                var endDate =
                    dateTimePicker2.Value;

                var difinDate = endDate - startDate;
                var convertToDays = difinDate.TotalDays;
                var convertToHours = convertToDays * 24;
                var toMillerMin = (convertToHours * 60) / 61362;
                var toMillerHour = (toMillerMin / 60);

                textBox1.Text = "" + ((short)toMillerMin);
                textBox2.Text = "" + ((short)toMillerHour);
            }
            catch
            {

            }
        }
    }
}
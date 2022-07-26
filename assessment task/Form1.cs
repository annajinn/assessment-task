namespace assessment_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //opens easy level
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hardbutton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            //opens hard level
        }
    }
}
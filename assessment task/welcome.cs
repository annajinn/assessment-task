namespace assessment_task
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            easyLevel f2 = new easyLevel();
            f2.ShowDialog();
            //opens easy level
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hardbutton_Click(object sender, EventArgs e)
        {
            hardLevel f3 = new hardLevel();
            f3.ShowDialog();
            //opens hard level
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
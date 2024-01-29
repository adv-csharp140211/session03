using session02.Utils;

namespace session02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonToJalali_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.MiladiToJalai(DateTime.Now));
        }
    }
}

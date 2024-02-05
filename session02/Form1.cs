using MD.PersianDateTime;
using session02.Model;
using session02.Service;
using session02.UI;
using session02.Utils;
using System.Windows.Forms;

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
            MessageBox.Show(DateUtil.MiladiToJalai(DateTime.Now, "-"));
        }

        private void buttonGetJalaliMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliMonthName(DateTime.Now));
            MessageBox.Show(DateUtil.GetJalaliMonthName_array(DateTime.Now));
        }

        private void buttonGetJalaliSeasonName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliSeasonName(DateTime.Now));
        }

        private void buttonJalaliToMiladi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.JalaliToMilaldi("1402/11/09").ToLongDateString());
        }

        private void buttonLib_Click(object sender, EventArgs e)
        {
            var persianDateTime = new PersianDateTime(DateTime.Now);
            MessageBox.Show(persianDateTime.ToLongDateString());
        }

        private void buttonToJalaliAndDays_out_Click(object sender, EventArgs e)
        {
            //double days;
            var jalali = DateUtil.ToJalaliAndDays_out(new DateTime(2001, 1, 1), out double days);
            MessageBox.Show($"date: {jalali} - day: {days}");
        }

        private void buttonToJalaliAndDays_ref_Click(object sender, EventArgs e)
        {
            double days = 0;
            var jalali = DateUtil.ToJalaliAndDays_ref(new DateTime(2001, 1, 1), ref days);
            MessageBox.Show($"date: {jalali} - day: {days}");
        }

        private void buttonToJalaliAndDaysTouple_Click(object sender, EventArgs e)
        {
            //var result = DateUtil.ToJalaliAndDaysTouple(new DateTime(2001, 1, 1));
            //MessageBox.Show($"date: {result.Item1} - day: {result.Item2}");

            //var jalali = result.Item1;
            //var days = result.Item2;
            //MessageBox.Show($"date: {jalali} - day: {days}");

            //destructure
            var (jalali, days) = DateUtil.ToJalaliAndDaysTouple(new DateTime(2001, 1, 1));
            MessageBox.Show($"date: {jalali} - day: {days}");


            var x = (1, "test", true);

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            var frm = new FormUser();
            frm.ShowDialog();
        }
    }
}

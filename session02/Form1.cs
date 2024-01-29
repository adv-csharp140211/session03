using MD.PersianDateTime;
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
    }
}

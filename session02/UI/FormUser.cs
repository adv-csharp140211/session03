using session02.Model;
using session02.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session02.UI
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var userService = new UserService();
            var user = new User { 
                UserName = textBoxUserName.Text, 
                FirstName = textBoxFirstName.Text, 
                LastName = textBoxLastName.Text
            };
            userService.Create(user);
            MessageBox.Show("success");
        }
    }
}

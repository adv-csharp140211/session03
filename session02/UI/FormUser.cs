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
            var user = new User
            {
                UserName = textBoxUserName.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text
            };
            userService.CreateSP(user);
            MessageBox.Show("success");
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var userService = new UserService();
            dataGridViewUsers.DataSource = userService.Read();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["id"].Value);
            if (dataGridViewUsers.CurrentCell.OwningColumn.Name == "delete")
            {
                if (MessageBox.Show("مطئمن هستید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var userService = new UserService();
                    userService.Delete(id);
                    loadData();
                    MessageBox.Show("success");
                }

            }
            if (dataGridViewUsers.CurrentCell.OwningColumn.Name == "edit")
            {
                textBoxFN.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["firstName"].Value);
                textBoxLN.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["lastName"].Value);
                textBoxUN.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["userName"].Value);
                selectedId = id;
            }
        }

        int selectedId = -1;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var userService = new UserService();
            var user = new User
            {
                Id = selectedId,
                UserName = textBoxUN.Text,
                FirstName = textBoxFN.Text,
                LastName = textBoxLN.Text
            };
            userService.Update(user);
            MessageBox.Show("success");
        }
    }
}

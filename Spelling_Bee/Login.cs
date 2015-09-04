using System;
using System.Windows.Forms;

namespace Spelling_Bee
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handles the login - looks big, but is mainly validation
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Sets a waitcursor
            Cursor.Current = Cursors.WaitCursor;
            // Initialises the id to 0
            int id = 0;
            string stuteach;
            // Checks for empty fields
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Please enter a Username/Password", "Invalid Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Checks that the user id is in the correct format
            try
            {
                id = Convert.ToInt16(txtUser.Text);
            }
            catch
            {
                MessageBox.Show("Username is in an invalid format", "Invalid Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Sets stuteach
            if (studentLogin.Checked)
            {
                stuteach = "students";
            }
            else
            {
                stuteach = "teachers";
            }
            // If the account info is valid then handle the student/teacher opening
            if (AccountControl.checkAccount(id, txtPass.Text, stuteach) == true)
            {
                if (stuteach == "students")
                {
                    Student stu = new Student(Convert.ToInt16(txtUser.Text));
                    stu.Show();
                    this.Hide();
                }
                else
                {
                    Teacher teach = new Teacher(id);
                    teach.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The User ID or password was incorrect, please try again.",
                    "Invalid Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}

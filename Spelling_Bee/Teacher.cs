using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Spelling_Bee
{
    public partial class Teacher : Form
    {
        private string teachclass = "";
        private SQLiteDatabase db = new SQLiteDatabase();
        private DataTable spellTests = new DataTable();
        private DataTable students = new DataTable();

        /// <summary>
        ///     Teacher constructor, initialises teachclass and fills in (student/test)Display
        /// </summary>
        /// <param name="id">Teacher ID</param>
        public Teacher(int id)
        {
            InitializeComponent();
            teachclass = db.ExecuteScalar(string.Format("SELECT class FROM teachers WHERE id={0}", id));
            students = db.GetDataTable(string.Format("SELECT id, name FROM students WHERE class=\"{0}\"", teachclass));
            DataTable tests = db.GetDataTable(string.Format("SELECT number FROM tests WHERE class=\"{0}\"", teachclass));
            dgStudentDisplay.DataSource = students;
            // Populates studentDisplay
            foreach (DataRow row in students.Select())
            {
                // id + dynamic spacing + name
                studentDisplay.Items.Add(row[0].ToString() + 
                    String.Concat(Enumerable.Repeat(" ", 5 - row[0].ToString().Length)) + 
                    row[1].ToString());
            }
            // Populates testDisplay
            foreach (DataRow row in tests.Select())
            {
                testDisplay.Items.Add(row[0]);
            }
            lblDesc.Text = "";
        }

        /// <summary>
        ///     Gets a DataTable of spelling tests for a specified class
        /// </summary>
        /// <param name="teachclass">The class to get the tests for</param>
        /// <returns>A DataTable containing number and words if successful, otherwise an empty one</returns>
        private DataTable getSpellTests(string teachclass)
        {
            DataTable ret = new DataTable();
            try
            {
                ret = db.GetDataTable(
                    string.Format("SELECT number, words, take FROM tests WHERE class=\"{0}\";", teachclass));
            }
            catch { }
            return ret;
        }

        /// <summary>
        ///     Deletes a test
        /// </summary>
        /// <param name="number">The test number</param>
        /// <param name="teachclass">The class the test belongs to</param>
        /// <returns></returns>
        private bool deleteTest(int number, string teachclass)
        {
            bool success = true;
            try
            {
                db.ExecuteNonQuery(string.Format("DELETE FROM tests WHERE number={0} AND class=\"{1}\"", number, teachclass));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                success = false;
            }
            return success;
        }

        /// <summary>
        ///     Just handler code to exit the application on close
        /// </summary>
        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Necessary as it's a secondary form
        }

        /// <summary>
        ///     Code that runs on load, adds classes to the student management tab
        ///     Also populates graph initially
        /// </summary>
        private void Teacher_Load(object sender, EventArgs e)
        {
            DataTable classes = db.GetDataTable("SELECT class FROM teachers");
            DataTable scores = new DataTable();
            // Populates classSelect
            foreach (DataRow row in classes.Select())
            {
                classSelect.Items.Add(row[0]);
            }
            try
            {
                scores = db.GetDataTable(string.Format("SELECT score FROM scores WHERE pupilid={0}", students.Rows[0][0]));
            }
            catch
            {
                MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            // Populates the graph
            foreach (DataRow row in scores.Select())
            {
                chartProg.Series[0].Points.Add(Convert.ToDouble(row[0]));
            }
        }

        /// <summary>
        ///     Refreshing code, updates spellingTestList
        /// </summary>
        private void Teacher_Activated(object sender, EventArgs e)
        {
            spellTests = getSpellTests(teachclass);
            spellingTestList.Nodes[0].Nodes.Clear();
            // If there are spelling tests, populate spellingTestList
            if (spellTests.Rows.Count != 0)
            {
                foreach (DataRow row in spellTests.Rows)
                {
                    TreeNode week = new TreeNode();
                    week.Text = row[0].ToString();
                    // If it's toTake, put a marker
                    if (Convert.ToInt16(row[2]) != 0)
                    {
                        week.Text += " /";
                    }
                    spellingTestList.Nodes[0].Nodes.Add(week);
                }
            }
            lblWords.Text = "No Spelling Test Selected";
        }

        /// <summary>
        ///     Updates spelling test displayed
        /// </summary>
        private void spellingTestList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cmbWords.Items.Clear();
            if (e.Node.Text != "Spelling Tests")
            {
                // Clears the words displayed
                lblWords.Text = "";
                // Obtains the words using Linq
                IEnumerable<string> words = from word in spellTests.AsEnumerable()
                                            where word.Field<int>("number") == Convert.ToInt16(e.Node.Text[0].ToString()) 
                                            select word.Field<string>("words");
                // Even though we are only expecting one string, words is enumerable,
                // so a foreach is required
                foreach (string str in words)
                {
                    foreach (string substr in str.Split(';'))
                    {
                        lblWords.Text += substr + ", ";
                        cmbWords.Items.Add(substr);
                    }
                }
            }
            // If the node "Spelling Tests" (top) has been selected, no test
            else
            {
                lblWords.Text = "No Spelling Test Selected";
                lblDesc.Text = "";
            }
            // Sometimes the node isn't highlighted if the user doesn't click on the
            // text, so this makes sure it is
            spellingTestList.SelectedNode = e.Node;
            // The try is here as not all nodes have a space in
            // This updates checkTake by checking the marker on th node
            try
            {
                if (e.Node.Text.Split(' ')[1] == "/")
                    checkTake.Checked = true;
                else
                    checkTake.Checked = false;
            }
            catch
            {
                checkTake.Checked = false;
            }
        }

        /// <summary>
        ///     Handles adding students
        /// </summary>
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            DialogResult res;
            try
            {
                res = MessageBox.Show(
                    string.Format("Confirm student details:\n\nName: {0}\nPassword: password\nClass: {1}",
                        txtStudentName.Text,
                        classSelect.SelectedItem.ToString()),
                    "Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please check you have entered the student's details correctly",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (res == DialogResult.OK)
            {
                try
                {
                    AccountControl.addStudent(txtStudentName.Text, "password", classSelect.SelectedItem.ToString());
                }
                catch
                {
                    MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                    return;
                }
                DataTable stud = db.GetDataTable(string.Format("SELECT id, name FROM students WHERE class=\"{0}\"", teachclass));
                dgStudentDisplay.DataSource = stud;
            }
        }

        /// <summary>
        ///     Handles deleting students
        /// </summary>
        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            // Gets selected row's ID
            string cell = dgStudentDisplay.CurrentRow.Cells[0].Value.ToString();
            DialogResult res = MessageBox.Show("Are you sure?", 
                "Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                // Delete the student
                int success = AccountControl.deleteAccount(Convert.ToInt32(cell), "students");
                if (success == 0)
                {
                    MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                // Update dgStudentDisplay to reflect the changes
                DataTable stud = db.GetDataTable(string.Format("SELECT id, name FROM students WHERE class=\"{0}\"", teachclass));
                dgStudentDisplay.DataSource = stud;
            }
        }

        /// <summary>
        ///     Pulls up the form for adding a test
        /// </summary>
        private void btnAddTest_Click(object sender, EventArgs e)
        {
            formTestAdd test = new formTestAdd(teachclass);
            test.ShowDialog();
        }

        /// <summary>
        ///     Handles deleting tests
        /// </summary>
        private void btnDelTest_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                success = deleteTest(Convert.ToInt16(spellingTestList.SelectedNode.Text.Split(' ')[0]), teachclass);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            if (!success)
            {
                MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            // Update form
            Teacher_Activated(sender, e);
        }

        /// <summary>
        ///     For changing the chart points when selected student index is changed
        /// </summary>
        private void studentDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears trouble words
            lblTroubleWords.Text = "";
            // Prevents a bug when studentDisplay loses focus
            if (studentDisplay.SelectedIndex < 0)
            {
                chartProg.Series[0].Points.Clear();
                lblTroubleWords.Text = "No trouble words found";
                return;
            }
            // Retrieves scores and trouble words from db
            DataTable scores = new DataTable();
            int pupID = Convert.ToInt16(studentDisplay.Items[studentDisplay.SelectedIndex].ToString().Split(' ')[0]);
            try
            {
                scores = db.GetDataTable(string.Format("SELECT score, trouble FROM scores WHERE pupilid={0}", pupID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Clears graph and replots. Also updates trouble words
            chartProg.Series[0].Points.Clear();
            foreach (DataRow row in scores.Select())
            {
                chartProg.Series[0].Points.Add(Convert.ToDouble(row[0]));
                lblTroubleWords.Text += row[1];
            }

        }

        /// <summary>
        ///     For changing the chart points when selected test index is changed
        /// </summary>
        // See studentDisplay_SelectedIndexChanged
        private void testDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTroubleWords.Text = "";
            if (testDisplay.SelectedIndex < 0)
            {
                chartProg.Series[0].Points.Clear();
                lblTroubleWords.Text = "No trouble words found";
                return;
            }
            DataTable scores = new DataTable();
            try
            {
                scores = db.GetDataTable(string.Format("SELECT score, trouble FROM scores WHERE number={0}", Convert.ToInt16(testDisplay.Items[testDisplay.SelectedIndex])));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            chartProg.Series[0].Points.Clear();
            foreach (DataRow row in scores.Select())
            {
                chartProg.Series[0].Points.Add(Convert.ToDouble(row[0]));
                lblTroubleWords.Text += row[1];
            }
        }

        /// <summary>
        ///     Handles the "To Take" checkbox changing state
        /// </summary>
        private void checkTake_CheckedChanged(object sender, EventArgs e)
        {
            if (spellingTestList.SelectedNode.Text.Length <= 5) // Only supports up to 999 tests
            {
                Cursor.Current = Cursors.WaitCursor;
                // If it has been checked, clear all take flags in db and set the current test's flag
                if (checkTake.Checked)
                {
                    try
                    {
                        db.ExecuteNonQuery("UPDATE tests SET take=0 WHERE take=1");
                        db.ExecuteNonQuery(string.Format("UPDATE tests SET take=1 WHERE number={0}", Convert.ToInt16(spellingTestList.SelectedNode.Text.Split(' ')[0])));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // If it hasn't just remove its flag
                else
                {
                    try
                    {
                        db.ExecuteNonQuery(string.Format("UPDATE tests SET take=0 WHERE number={0}", Convert.ToInt16(spellingTestList.SelectedNode.Text.Split(' ')[0])));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // Update form
                Teacher_Activated(sender, e);
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        ///     Updates description displayed when a different word is selected
        /// </summary>
        private void cmbWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = db.ExecuteScalar(string.Format("SELECT desc FROM words WHERE word=\"{0}\"", cmbWords.SelectedItem));
        }

        /// <summary>
        ///     Resets a student's password
        /// </summary>
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            // Gets selected student's ID
            string cell = dgStudentDisplay.CurrentRow.Cells[0].Value.ToString();
            DialogResult res = MessageBox.Show("Are you sure?", 
                "Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                // Obtains hash for default password and puts it in the db
                string hash = Password.hashAsString("password");
                db.ExecuteNonQuery(string.Format("UPDATE students SET hash=\"{0}\" WHERE id=\"{1}\"", hash, cell));
                MessageBox.Show("Password Reset to 'password'",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///     Handles the "Export as HTML" event
        /// </summary>
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Only shows the save dialog when there is a spelling test selected
            if (lblWords.Text != "No Spelling Test Selected")
            {
                svTest.ShowDialog();
            }
            else MessageBox.Show("No Spelling Test Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        ///     Handles the OK button on the save dialog and handles HTML creation
        /// </summary>
        private void svTest_FileOk(object sender, CancelEventArgs e)
        {
            string path = svTest.FileName;
            // Opens the location selected for writing
            StreamWriter writer = new StreamWriter(path);
            // Opening unordered list tag
            writer.WriteLine("<ul>");
            // For every word in the test, put them in their own list item tag
            foreach(string item in cmbWords.Items)
            {
                try
                {
                    writer.WriteLine("<li>{0} - {1}</li><br />", item,
                        db.ExecuteScalar(string.Format("SELECT desc FROM words WHERE word=\"{0}\"", item)));
                }
                catch { }
            }
            // Closing ul
            writer.WriteLine("</ul>");
            // Close and write stream
            writer.Close();
        }

        /// <summary>
        ///     Handles changing a student's password
        /// </summary>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string cell = dgStudentDisplay.CurrentRow.Cells[0].Value.ToString();
            string newPass = Interaction.InputBox("Please enter the new password", "Password Change", "password");
            string hash = Password.hashAsString(newPass);
            db.ExecuteNonQuery(string.Format("UPDATE students SET hash=\"{0}\" WHERE id=\"{1}\"", hash, cell));
            MessageBox.Show(string.Format("Password changed to '{0}'", newPass),
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

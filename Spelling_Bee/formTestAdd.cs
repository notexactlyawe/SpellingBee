using System;
using System.Data;
using System.Windows.Forms;

namespace Spelling_Bee
{
    public partial class formTestAdd : Form
    {
        /* The following variables are:
         * teachclass   - the class that the teacher teaches, used in the saving of tests
         * selectedWord - Used for updating the description
         * db           - An instance of the SQLiteDatabase class */
        private string teachclass;
        private string selectedWord;
        private SQLiteDatabase db;

        /// <summary>
        ///     Constructor, initialises teachclass and db
        /// </summary>
        /// <param name="teclass">teachclass under a different guise</param>
        public formTestAdd(string teclass)
        {
            InitializeComponent();
            teachclass = teclass;
            db = new SQLiteDatabase();
        }

        /// <summary>
        ///     Handles the search feature
        /// </summary>
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            // Selects a DataTable of up to 10 words that match the search string. GLOB is like regexp but simpler
            DataTable words = db.GetDataTable(string.Format("SELECT word FROM words WHERE word GLOB '{0}*' LIMIT 10", txtSearch.Text));
            lstResults.Items.Clear();
            foreach (DataRow row in words.Select())
            {
                lstResults.Items.Add(row[0]);
            }
        }

        /// <summary>
        ///     Clears the lstTest and resets the selected count
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Words: 0";
            lstTest.Items.Clear();
        }

        /// <summary>
        ///     Adds a random test
        /// </summary>
        private void btnRand_Click(object sender, EventArgs e)
        {
            // Sets cursor to WaitCursor to prevent the user from thinking the application has hung
            Cursor.Current = Cursors.WaitCursor;
            // Selects the first 10 words from randomly ordered words
            DataTable test = db.GetDataTable("SELECT word FROM words ORDER BY RANDOM() LIMIT 10");
            lstTest.Items.Clear();
            foreach (DataRow row in test.Rows)
            {
                lstTest.Items.Add(row[0]);
            }
            // Resets cursor
            Cursor.Current = Cursors.Default;
            lblSelected.Text = "Words: " + lstTest.Items.Count.ToString();
        }

        /// <summary>
        ///     Handles the adding of a word to the list of words
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // The try/catch is to prevent errors when no item is selected
            try
            {
                lstTest.Items.Add(lstResults.SelectedItem);
            }
            catch { }
            lblSelected.Text = "Words: " + lstTest.Items.Count.ToString();
        }

        /// <summary>
        ///     Handles the removing of a word from the list
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // The try/catch is to prevent errors when no item is selected
            try
            {
                lstTest.Items.Remove(lstTest.SelectedItem);
            }
            catch { }
            lblSelected.Text = "Words: " + lstTest.Items.Count.ToString();
        }

        /// <summary>
        ///     Handles the saving of tests
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Checks whether there are exactly 10 words
            if (lstTest.Items.Count == 10)
            {
                /* The formatting function for the words field in test
                 * It cycles through the words selected and adds them together
                 * delimited by a semicolon. On the last word, it only
                 * adds the word and skips the semicolon. This avoids a
                 * ton of bugs.
                 */
                string words = "";
                for (int i = 0; i < 10; i++)
                {
                    words += lstTest.Items[i];
                    if (i < 9)
                    {
                        words += ";";
                    }
                }

                // Takes the highest ID test and adds one to it, prevents bugs with tests having been deleted etc
                int count = Convert.ToInt16(db.ExecuteScalar(
                    string.Format("SELECT number FROM tests WHERE class=\"{0}\" ORDER BY number DESC", teachclass))) + 1;
                // Adds the test
                db.ExecuteNonQuery(string.Format(
                    "INSERT INTO tests VALUES ({0}, \"{1}\", \"{2}\", 0)", count, teachclass, words));
                // Closes and returns
                this.Close();
                return;
            }
            MessageBox.Show("Please select 10 words for the test", 
                "Incorrect number of words", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        ///     Handles bringing up the edit description textbox
        /// </summary>
        private void lblDesc_DoubleClick(object sender, EventArgs e)
        {
            // Checks the text isn't the default and then brings up an edit box
            if (lblDesc.Text != "Select a word to view its description.")
            {
                txtDesc.Text = lblDesc.Text;
                txtDesc.Visible = true;
                lblDesc.Visible = false;
            }
        }

        /// <summary>
        ///     Changes the description displayed and updates selectedWord
        ///     when a different word is clicked on the test pane
        /// </summary>
        private void lstTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = db.ExecuteScalar(string.Format(
                "SELECT desc FROM words WHERE word=\"{0}\"", lstTest.SelectedItem));
            selectedWord = lstTest.SelectedItem.ToString();
        }

        /// <summary>
        ///     Handles saving the description on enter
        /// </summary>
        /// <param name="e">Used to check for return and suppress the keypress</param>
        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks for 'enter' ('return' in american)
            if (e.KeyCode == Keys.Return)
            {
                Cursor.Current = Cursors.WaitCursor;
                // This stops a line break being put in
                e.SuppressKeyPress = true;
                // Updates the db
                db.ExecuteNonQuery(string.Format(
                    "UPDATE words SET desc=\"{0}\" WHERE word=\"{1}\"", txtDesc.Text, selectedWord));
                lblDesc.Text = txtDesc.Text;
                txtDesc.Text = "";
                txtDesc.Visible = false;
                lblDesc.Visible = true;
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        ///     Changes the description displayed and updates selectedWord
        ///     when a different word is clicked on the results pane
        /// </summary>
        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets the description for the word clicked
            lblDesc.Text = db.ExecuteScalar(string.Format(
                "SELECT desc FROM words WHERE word=\"{0}\"", lstResults.SelectedItem));
            selectedWord = lstResults.SelectedItem.ToString();
        }

        /// <summary>
        ///     Pulls up the add word form
        /// </summary>
        private void btnWordAdd_Click(object sender, EventArgs e)
        {
            formWordAdd frm = new formWordAdd();
            frm.Show();
        }
    }
}


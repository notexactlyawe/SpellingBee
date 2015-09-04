using System;
using System.Windows.Forms;

namespace Spelling_Bee
{
    public partial class formWordAdd : Form
    {
        public formWordAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Handles the OK button, adds a word
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Checks whether the description and word are filled in
            if (txtDesc.Text != "" && txtWord.Text != "")
            {
                SQLiteDatabase db = new SQLiteDatabase();
                /* Attempts an insert and if successful it clears the desc and word boxes
                *  to allow further entry, else it shows a messagebox and since most errors
                *  will be that the word is already there, the error is shown */
                try
                {
                    db.ExecuteNonQuery(string.Format("INSERT INTO words VALUES (\"{0}\", \"{1}\")", 
                        txtWord.Text, txtDesc.Text));
                    txtDesc.Clear();
                    txtWord.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format("Something went wrong, the error is given below:\n\n{0}", ex.Message), 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        ///     Handles the cancel button
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

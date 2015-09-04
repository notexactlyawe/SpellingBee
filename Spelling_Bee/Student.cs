using System;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Spelling_Bee
{
    public partial class Student : Form
    {
        private int id; // The student's ID
        private int pos = 0; // For tracking the word displayed
        private int testNum; // The number of the test
        private SQLiteDatabase db = new SQLiteDatabase(); // Entry for db
        private string stuclass; // The student's class gained from id
        private string[] test; // The words to be tested on
        private string[] descs = new string[10]; // The descriptions of the words
        private string[] answers = new string[10]; // The answers the student gives
        SpeechSynthesizer synth = new SpeechSynthesizer(); // Used to speak the words

        /// <summary>
        ///     Constructor for Student class
        /// </summary>
        /// <param name="stuid">The ID of the student viewing the form</param>
        public Student(int stuid)
        {
            id = stuid; // Setting  student id to the private int id
            InitializeComponent();
        }

        /// <summary>
        ///     Calculates the levenshtein distance for two words recursively
        /// </summary>
        /// <param name="s">The first word</param>
        /// <param name="s_len">The length of the first word</param>
        /// <param name="t">The second word</param>
        /// <param name="t_len">The length of the second word</param>
        /// <returns>The levenshtein distance between s and t</returns>
        public int levDistance(string s, int s_len, string t, int t_len)
        {
            int cost;

            s = s.ToLowerInvariant();
            t = t.ToLowerInvariant();

            // If either of the words is "" then the distance will be the length of the other
            // Also used to prevent errors when *_len - 1 would equal < 0
            if (s_len == 0) return t_len;
            if (t_len == 0) return s_len;

            /* The distance is calculated recursively, meaning that the two lines below are the main bit of the
             * function. The *_len variables are enacting the job of taking a substring up to and excluding the
             * last character of s/t, since the recursive call always -1 to the variable in all possible
             * combinations. Therefore, the below lines are effectively checking to see whether the last 
             * characters of the two strings match.
             * 
             * It always returns the minimum distance, but Math.Min only takes two arguments, so there are two
             * calls to it in the return function.
             */ 
            if (s[s_len - 1] == t[t_len - 1]) cost = 0;
            else cost = 1;

            return Math.Min(levDistance(s, s_len - 1, t, t_len    ) + 1,
                   Math.Min(levDistance(s, s_len    , t, t_len - 1) + 1,
                            levDistance(s, s_len - 1, t, t_len - 1) + cost));
        }

        /// <summary>
        ///     Handles speaking the word
        /// </summary>
        private void Speak()
        {
            // pos is tracked withe the word on screen
            synth.Speak(test[pos]);
        }

        /// <summary>
        ///     The Load function for Student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Load(object sender, EventArgs e)
        {
            // Initialises answers
            for (int i = 0; i < 10; i++)
            {
                answers[i] = "";
            }
            // Used as a disaster scenario handler in case AccountControl or Login fails spectacularly
            // due to solar radiation/invasion/SARS
            try
            {
                stuclass = db.ExecuteScalar(string.Format("SELECT class FROM students WHERE id={0}", id)); // Getting class
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                // Loads in test words from db
                string words = db.ExecuteScalar(string.Format(
                    "SELECT words FROM tests WHERE class=\"{0}\" AND take=1", stuclass));
                test = words.Substring(0, words.Length).Split(';');
                // Gets the test number for saving later
                testNum = Convert.ToInt16(db.ExecuteScalar(string.Format(
                    "SELECT number FROM tests WHERE class=\"{0}\" AND take=1", stuclass)));
                int count = 0;
                // Loads descriptions
                foreach (string word in test)
                {
                    string desc = db.ExecuteScalar(string.Format(
                        "SELECT desc FROM words WHERE word=\"{0}\"", word));
                    descs[count] = desc;
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "You have either alredy taken your test, or your teacher hasn't scheduled one.",
                    "No test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            lblWord.Text = descs[pos]; // Initialises lblWord
        }

        /// <summary>
        ///     Handler code to exit on close
        /// </summary>
        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Secondary form, but application needs to exit on close
        }

        /// <summary>
        ///     Handles updating the form when btnRight/Left is pressed
        /// </summary>
        /// <param name="right">True when btnRight is pressed, false when btnLeft is pressed</param>
        private void UpdateForm(bool right) // Updates everything that needs to be updated
        {
            answers[pos] = txtWord.Text; // Saves word for persistency (lasts the session)
            if (right) // If btnRight_Click
            {
                pos++;
            }
            else // If btnLeft_Click
            {
                pos--;
            }
            lblNum.Text = "Word " + (pos + 1).ToString(); // Updates word number
            txtWord.Text = answers[pos]; // Updates textbox with word in
            lblWord.Text = descs[pos]; // Updates description
        }

        /// <summary>
        ///     Handles moving the word on one
        /// </summary>
        private void btnRight_Click(object sender, EventArgs e) // Moves the test along to the next word
        {
            // Checks to see if we are at the end of the words
            if (pos < 9)
            {
                UpdateForm(true);
                return;
            }
            MessageBox.Show("There are no more words, please check your answers then click complete.", 
                "No More Words", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Handles moving the word back one
        /// </summary>
        private void btnLeft_Click(object sender, EventArgs e) // Moves back to the previous word
        {
            // Checks to see whether we are at the beginning of the words
            if (pos > 0)
            {
                UpdateForm(false);
                return;
            }
        }

        /// <summary>
        ///     Handles saving scores
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Please check all your answers and click OK when you are sure you have finished. You cannot change your answers past this point.",
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            // Checks to see whether the student understands this is the end of the test
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                answers[9] = txtWord.Text; // Hacky, yes, but necessary
                string trouble = "";
                int score = 0;
                int count = 0;
                // Marks answers
                foreach (string word in answers)
                {
                    switch (levDistance(word, word.Length, test[count], test[count].Length))
                    {
                        case 0:
                            score += 2;
                            break;
                        case 1:
                            score += 1;
                            break;
                        case 3:
                            trouble += test[count];
                            trouble += ";";
                            break;
                        default:
                            trouble += test[count];
                            trouble += ";";
                            break;
                    }
                    count++;
                }
                try
                {
                    db.ExecuteNonQuery(string.Format("INSERT INTO scores VALUES ({0}, {1}, {2}, \"{3}\")", id, testNum, score, trouble));
                }
                catch
                {
                    MessageBox.Show("Something went wrong, please try again. If this problem persists, please contact your system administrator.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                MessageBox.Show(string.Format("You scored {0}", score));
                Application.Exit();
            }
        }

        /// <summary>
        ///     Dispatches a thread to handle the speaking function to prevent hangs during TTS
        /// </summary>
        private void btnSpeakWord_Click(object sender, EventArgs e)
        {
            // Creates a new thread with the Speak function
            System.Threading.Thread tts = new System.Threading.Thread(Speak);
            tts.IsBackground = true;
            tts.Start();
        }
    }
}

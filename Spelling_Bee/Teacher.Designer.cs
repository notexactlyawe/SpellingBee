namespace Spelling_Bee
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("No Spelling Tests Found");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Spelling Tests", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControlTeach = new System.Windows.Forms.TabControl();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.containerTests = new System.Windows.Forms.SplitContainer();
            this.spellingTestList = new System.Windows.Forms.TreeView();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.cmbWords = new System.Windows.Forms.ComboBox();
            this.checkTake = new System.Windows.Forms.CheckBox();
            this.btnDelTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.lblWords = new System.Windows.Forms.Label();
            this.tabProg = new System.Windows.Forms.TabPage();
            this.containerProgress = new System.Windows.Forms.SplitContainer();
            this.lblTests = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.testDisplay = new System.Windows.Forms.ListBox();
            this.studentDisplay = new System.Windows.Forms.ListBox();
            this.lblTroubleWords = new System.Windows.Forms.Label();
            this.lblTrouble = new System.Windows.Forms.Label();
            this.chartProg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabStudentManage = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.classSelect = new System.Windows.Forms.ListBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.lblDGView = new System.Windows.Forms.Label();
            this.dgStudentDisplay = new System.Windows.Forms.DataGridView();
            this.svTest = new System.Windows.Forms.SaveFileDialog();
            this.tabControlTeach.SuspendLayout();
            this.tabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerTests)).BeginInit();
            this.containerTests.Panel1.SuspendLayout();
            this.containerTests.Panel2.SuspendLayout();
            this.containerTests.SuspendLayout();
            this.tabProg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerProgress)).BeginInit();
            this.containerProgress.Panel1.SuspendLayout();
            this.containerProgress.Panel2.SuspendLayout();
            this.containerProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProg)).BeginInit();
            this.tabStudentManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTeach
            // 
            this.tabControlTeach.Controls.Add(this.tabTest);
            this.tabControlTeach.Controls.Add(this.tabProg);
            this.tabControlTeach.Controls.Add(this.tabStudentManage);
            this.tabControlTeach.Location = new System.Drawing.Point(2, 0);
            this.tabControlTeach.Name = "tabControlTeach";
            this.tabControlTeach.SelectedIndex = 0;
            this.tabControlTeach.Size = new System.Drawing.Size(664, 505);
            this.tabControlTeach.TabIndex = 0;
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.containerTests);
            this.tabTest.Location = new System.Drawing.Point(4, 22);
            this.tabTest.Name = "tabTest";
            this.tabTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabTest.Size = new System.Drawing.Size(656, 479);
            this.tabTest.TabIndex = 0;
            this.tabTest.Text = "Spelling Tests";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // containerTests
            // 
            this.containerTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTests.Location = new System.Drawing.Point(3, 3);
            this.containerTests.Name = "containerTests";
            // 
            // containerTests.Panel1
            // 
            this.containerTests.Panel1.Controls.Add(this.spellingTestList);
            // 
            // containerTests.Panel2
            // 
            this.containerTests.Panel2.Controls.Add(this.btnExport);
            this.containerTests.Panel2.Controls.Add(this.lblDesc);
            this.containerTests.Panel2.Controls.Add(this.lblDefinition);
            this.containerTests.Panel2.Controls.Add(this.cmbWords);
            this.containerTests.Panel2.Controls.Add(this.checkTake);
            this.containerTests.Panel2.Controls.Add(this.btnDelTest);
            this.containerTests.Panel2.Controls.Add(this.btnAddTest);
            this.containerTests.Panel2.Controls.Add(this.lblWords);
            this.containerTests.Size = new System.Drawing.Size(650, 473);
            this.containerTests.SplitterDistance = 216;
            this.containerTests.TabIndex = 0;
            // 
            // spellingTestList
            // 
            this.spellingTestList.Location = new System.Drawing.Point(0, 3);
            this.spellingTestList.Name = "spellingTestList";
            treeNode1.Name = "nodeErr";
            treeNode1.Text = "No Spelling Tests Found";
            treeNode2.Name = "nodeTests";
            treeNode2.Text = "Spelling Tests";
            this.spellingTestList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.spellingTestList.Size = new System.Drawing.Size(213, 467);
            this.spellingTestList.TabIndex = 0;
            this.spellingTestList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.spellingTestList_NodeMouseClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(173, 447);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export as HTML";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(78, 92);
            this.lblDesc.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(22, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "def";
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Location = new System.Drawing.Point(15, 92);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(57, 13);
            this.lblDefinition.TabIndex = 4;
            this.lblDefinition.Text = "Definition: ";
            // 
            // cmbWords
            // 
            this.cmbWords.FormattingEnabled = true;
            this.cmbWords.Location = new System.Drawing.Point(18, 18);
            this.cmbWords.MaxDropDownItems = 10;
            this.cmbWords.Name = "cmbWords";
            this.cmbWords.Size = new System.Drawing.Size(187, 21);
            this.cmbWords.TabIndex = 1;
            this.cmbWords.SelectedIndexChanged += new System.EventHandler(this.cmbWords_SelectedIndexChanged);
            // 
            // checkTake
            // 
            this.checkTake.AutoSize = true;
            this.checkTake.Location = new System.Drawing.Point(343, 18);
            this.checkTake.Name = "checkTake";
            this.checkTake.Size = new System.Drawing.Size(67, 17);
            this.checkTake.TabIndex = 3;
            this.checkTake.Text = "To Take";
            this.checkTake.UseVisualStyleBackColor = true;
            this.checkTake.Click += new System.EventHandler(this.checkTake_CheckedChanged);
            // 
            // btnDelTest
            // 
            this.btnDelTest.Location = new System.Drawing.Point(18, 448);
            this.btnDelTest.Name = "btnDelTest";
            this.btnDelTest.Size = new System.Drawing.Size(75, 23);
            this.btnDelTest.TabIndex = 2;
            this.btnDelTest.Text = "Delete Test";
            this.btnDelTest.UseVisualStyleBackColor = true;
            this.btnDelTest.Click += new System.EventHandler(this.btnDelTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(347, 448);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(75, 23);
            this.btnAddTest.TabIndex = 1;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(15, 392);
            this.lblWords.MaximumSize = new System.Drawing.Size(265, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(130, 13);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "No Spelling Test Selected";
            // 
            // tabProg
            // 
            this.tabProg.Controls.Add(this.containerProgress);
            this.tabProg.Location = new System.Drawing.Point(4, 22);
            this.tabProg.Name = "tabProg";
            this.tabProg.Padding = new System.Windows.Forms.Padding(3);
            this.tabProg.Size = new System.Drawing.Size(656, 479);
            this.tabProg.TabIndex = 1;
            this.tabProg.Text = "Student Progress";
            this.tabProg.UseVisualStyleBackColor = true;
            // 
            // containerProgress
            // 
            this.containerProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerProgress.Location = new System.Drawing.Point(3, 3);
            this.containerProgress.Name = "containerProgress";
            // 
            // containerProgress.Panel1
            // 
            this.containerProgress.Panel1.Controls.Add(this.lblTests);
            this.containerProgress.Panel1.Controls.Add(this.lblStudents);
            this.containerProgress.Panel1.Controls.Add(this.testDisplay);
            this.containerProgress.Panel1.Controls.Add(this.studentDisplay);
            // 
            // containerProgress.Panel2
            // 
            this.containerProgress.Panel2.Controls.Add(this.lblTroubleWords);
            this.containerProgress.Panel2.Controls.Add(this.lblTrouble);
            this.containerProgress.Panel2.Controls.Add(this.chartProg);
            this.containerProgress.Size = new System.Drawing.Size(650, 473);
            this.containerProgress.SplitterDistance = 214;
            this.containerProgress.TabIndex = 0;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(3, 238);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(33, 13);
            this.lblTests.TabIndex = 4;
            this.lblTests.Text = "Tests";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(3, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(49, 13);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Students";
            // 
            // testDisplay
            // 
            this.testDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testDisplay.FormattingEnabled = true;
            this.testDisplay.ItemHeight = 12;
            this.testDisplay.Location = new System.Drawing.Point(0, 254);
            this.testDisplay.Name = "testDisplay";
            this.testDisplay.Size = new System.Drawing.Size(211, 208);
            this.testDisplay.TabIndex = 2;
            this.testDisplay.SelectedIndexChanged += new System.EventHandler(this.testDisplay_SelectedIndexChanged);
            // 
            // studentDisplay
            // 
            this.studentDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDisplay.FormattingEnabled = true;
            this.studentDisplay.ItemHeight = 12;
            this.studentDisplay.Location = new System.Drawing.Point(0, 25);
            this.studentDisplay.Name = "studentDisplay";
            this.studentDisplay.Size = new System.Drawing.Size(211, 208);
            this.studentDisplay.TabIndex = 1;
            this.studentDisplay.SelectedIndexChanged += new System.EventHandler(this.studentDisplay_SelectedIndexChanged);
            // 
            // lblTroubleWords
            // 
            this.lblTroubleWords.AutoSize = true;
            this.lblTroubleWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleWords.Location = new System.Drawing.Point(108, 298);
            this.lblTroubleWords.Name = "lblTroubleWords";
            this.lblTroubleWords.Size = new System.Drawing.Size(139, 13);
            this.lblTroubleWords.TabIndex = 2;
            this.lblTroubleWords.Text = "No trouble words found";
            // 
            // lblTrouble
            // 
            this.lblTrouble.AutoSize = true;
            this.lblTrouble.Location = new System.Drawing.Point(22, 298);
            this.lblTrouble.Name = "lblTrouble";
            this.lblTrouble.Size = new System.Drawing.Size(80, 13);
            this.lblTrouble.TabIndex = 1;
            this.lblTrouble.Text = "Trouble Words:";
            // 
            // chartProg
            // 
            this.chartProg.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.SystemColors.Menu;
            chartArea1.Name = "ChartArea1";
            this.chartProg.ChartAreas.Add(chartArea1);
            this.chartProg.Location = new System.Drawing.Point(25, 25);
            this.chartProg.Name = "chartProg";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "results";
            this.chartProg.Series.Add(series1);
            this.chartProg.Size = new System.Drawing.Size(377, 270);
            this.chartProg.TabIndex = 0;
            this.chartProg.Text = "Student Progress";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "ttlRes";
            title1.Text = "Results";
            this.chartProg.Titles.Add(title1);
            // 
            // tabStudentManage
            // 
            this.tabStudentManage.Controls.Add(this.btnChangePassword);
            this.tabStudentManage.Controls.Add(this.btnResetPass);
            this.tabStudentManage.Controls.Add(this.classSelect);
            this.tabStudentManage.Controls.Add(this.lblClass);
            this.tabStudentManage.Controls.Add(this.lblStudentName);
            this.tabStudentManage.Controls.Add(this.txtStudentName);
            this.tabStudentManage.Controls.Add(this.btnDelStudent);
            this.tabStudentManage.Controls.Add(this.btnStudentAdd);
            this.tabStudentManage.Controls.Add(this.lblDGView);
            this.tabStudentManage.Controls.Add(this.dgStudentDisplay);
            this.tabStudentManage.Location = new System.Drawing.Point(4, 22);
            this.tabStudentManage.Name = "tabStudentManage";
            this.tabStudentManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentManage.Size = new System.Drawing.Size(656, 479);
            this.tabStudentManage.TabIndex = 2;
            this.tabStudentManage.Text = "Manage Students";
            this.tabStudentManage.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(285, 394);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(95, 23);
            this.btnChangePassword.TabIndex = 11;
            this.btnChangePassword.Text = "Password Change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(285, 423);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(95, 23);
            this.btnResetPass.TabIndex = 10;
            this.btnResetPass.Text = "Password Reset";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // classSelect
            // 
            this.classSelect.FormattingEnabled = true;
            this.classSelect.Location = new System.Drawing.Point(516, 75);
            this.classSelect.Name = "classSelect";
            this.classSelect.Size = new System.Drawing.Size(126, 30);
            this.classSelect.TabIndex = 9;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(435, 75);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(72, 13);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Student Class";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(435, 46);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(516, 43);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(126, 20);
            this.txtStudentName.TabIndex = 5;
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.Location = new System.Drawing.Point(285, 452);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(95, 23);
            this.btnDelStudent.TabIndex = 4;
            this.btnDelStudent.Text = "Delete";
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(567, 109);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 2;
            this.btnStudentAdd.Text = "Add Student";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // lblDGView
            // 
            this.lblDGView.AutoSize = true;
            this.lblDGView.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGView.Location = new System.Drawing.Point(18, 10);
            this.lblDGView.Name = "lblDGView";
            this.lblDGView.Size = new System.Drawing.Size(176, 33);
            this.lblDGView.TabIndex = 1;
            this.lblDGView.Text = "My Students";
            // 
            // dgStudentDisplay
            // 
            this.dgStudentDisplay.AllowUserToAddRows = false;
            this.dgStudentDisplay.AllowUserToDeleteRows = false;
            this.dgStudentDisplay.AllowUserToOrderColumns = true;
            this.dgStudentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStudentDisplay.Location = new System.Drawing.Point(10, 46);
            this.dgStudentDisplay.Name = "dgStudentDisplay";
            this.dgStudentDisplay.Size = new System.Drawing.Size(269, 427);
            this.dgStudentDisplay.TabIndex = 0;
            // 
            // svTest
            // 
            this.svTest.DefaultExt = "html";
            this.svTest.Filter = "HTML files|*.html";
            this.svTest.FileOk += new System.ComponentModel.CancelEventHandler(this.svTest_FileOk);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 508);
            this.Controls.Add(this.tabControlTeach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Activated += new System.EventHandler(this.Teacher_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Teacher_FormClosing);
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.tabControlTeach.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.containerTests.Panel1.ResumeLayout(false);
            this.containerTests.Panel2.ResumeLayout(false);
            this.containerTests.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerTests)).EndInit();
            this.containerTests.ResumeLayout(false);
            this.tabProg.ResumeLayout(false);
            this.containerProgress.Panel1.ResumeLayout(false);
            this.containerProgress.Panel1.PerformLayout();
            this.containerProgress.Panel2.ResumeLayout(false);
            this.containerProgress.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerProgress)).EndInit();
            this.containerProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProg)).EndInit();
            this.tabStudentManage.ResumeLayout(false);
            this.tabStudentManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeach;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.SplitContainer containerTests;
        private System.Windows.Forms.TabPage tabProg;
        private System.Windows.Forms.SplitContainer containerProgress;
        private System.Windows.Forms.TabPage tabStudentManage;
        private System.Windows.Forms.DataGridView dgStudentDisplay;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label lblDGView;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListBox classSelect;
        private System.Windows.Forms.TreeView spellingTestList;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnDelTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProg;
        private System.Windows.Forms.ListBox testDisplay;
        private System.Windows.Forms.ListBox studentDisplay;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.CheckBox checkTake;
        private System.Windows.Forms.Label lblTroubleWords;
        private System.Windows.Forms.Label lblTrouble;
        private System.Windows.Forms.ComboBox cmbWords;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog svTest;
        private System.Windows.Forms.Button btnChangePassword;

    }
}
namespace FinalProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpRole = new System.Windows.Forms.GroupBox();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radStaff = new System.Windows.Forms.RadioButton();
            this.radFaculty = new System.Windows.Forms.RadioButton();
            this.grpFaculty = new System.Windows.Forms.GroupBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpRole.SuspendLayout();
            this.grpFaculty.SuspendLayout();
            this.grpStaff.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.grpRole);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 121);
            this.panel1.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(95, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(356, 22);
            this.txtAge.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(95, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(356, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(95, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(356, 22);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(95, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(356, 22);
            this.txtID.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(62, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 16);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(50, 90);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 16);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(10, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(10, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name: ";
            // 
            // grpRole
            // 
            this.grpRole.Controls.Add(this.radStudent);
            this.grpRole.Controls.Add(this.radStaff);
            this.grpRole.Controls.Add(this.radFaculty);
            this.grpRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRole.Location = new System.Drawing.Point(457, 0);
            this.grpRole.Name = "grpRole";
            this.grpRole.Size = new System.Drawing.Size(155, 121);
            this.grpRole.TabIndex = 5;
            this.grpRole.TabStop = false;
            this.grpRole.Text = "Role";
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStudent.Location = new System.Drawing.Point(7, 80);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(76, 22);
            this.radStudent.TabIndex = 2;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radStaff
            // 
            this.radStaff.AutoSize = true;
            this.radStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStaff.Location = new System.Drawing.Point(7, 52);
            this.radStaff.Name = "radStaff";
            this.radStaff.Size = new System.Drawing.Size(56, 22);
            this.radStaff.TabIndex = 1;
            this.radStaff.Text = "Staff";
            this.radStaff.UseVisualStyleBackColor = true;
            this.radStaff.CheckedChanged += new System.EventHandler(this.radStaff_CheckedChanged);
            // 
            // radFaculty
            // 
            this.radFaculty.AutoSize = true;
            this.radFaculty.Checked = true;
            this.radFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFaculty.Location = new System.Drawing.Point(7, 24);
            this.radFaculty.Name = "radFaculty";
            this.radFaculty.Size = new System.Drawing.Size(73, 22);
            this.radFaculty.TabIndex = 0;
            this.radFaculty.TabStop = true;
            this.radFaculty.Text = "Faculty";
            this.radFaculty.UseVisualStyleBackColor = true;
            this.radFaculty.CheckedChanged += new System.EventHandler(this.radFaculty_CheckedChanged);
            // 
            // grpFaculty
            // 
            this.grpFaculty.Controls.Add(this.txtHours);
            this.grpFaculty.Controls.Add(this.txtDivision);
            this.grpFaculty.Controls.Add(this.lblHours);
            this.grpFaculty.Controls.Add(this.lblDivision);
            this.grpFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFaculty.Location = new System.Drawing.Point(12, 154);
            this.grpFaculty.Name = "grpFaculty";
            this.grpFaculty.Size = new System.Drawing.Size(200, 85);
            this.grpFaculty.TabIndex = 2;
            this.grpFaculty.TabStop = false;
            this.grpFaculty.Text = "Faculty";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(66, 51);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(128, 21);
            this.txtHours.TabIndex = 3;
            // 
            // txtDivision
            // 
            this.txtDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivision.Location = new System.Drawing.Point(66, 24);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(128, 21);
            this.txtDivision.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(17, 54);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(43, 15);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours:";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(7, 27);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(53, 15);
            this.lblDivision.TabIndex = 0;
            this.lblDivision.Text = "Division:";
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.txtPosition);
            this.grpStaff.Controls.Add(this.txtSalary);
            this.grpStaff.Controls.Add(this.lblPosition);
            this.grpStaff.Controls.Add(this.lblSalary);
            this.grpStaff.Enabled = false;
            this.grpStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(218, 154);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(200, 85);
            this.grpStaff.TabIndex = 3;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Staff";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(66, 24);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(128, 21);
            this.txtPosition.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(66, 51);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(128, 21);
            this.txtSalary.TabIndex = 5;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(6, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 15);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(16, 54);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 15);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary:";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.txtMajor);
            this.grpStudent.Controls.Add(this.txtGPA);
            this.grpStudent.Controls.Add(this.lblMajor);
            this.grpStudent.Controls.Add(this.lblGPA);
            this.grpStudent.Enabled = false;
            this.grpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudent.Location = new System.Drawing.Point(424, 154);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(200, 85);
            this.grpStudent.TabIndex = 4;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student";
            // 
            // txtMajor
            // 
            this.txtMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajor.Location = new System.Drawing.Point(66, 24);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(128, 21);
            this.txtMajor.TabIndex = 6;
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(66, 51);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(128, 21);
            this.txtGPA.TabIndex = 7;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(15, 27);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(45, 15);
            this.lblMajor.TabIndex = 4;
            this.lblMajor.Text = "Major: ";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(26, 54);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(34, 15);
            this.lblGPA.TabIndex = 5;
            this.lblGPA.Text = "GPA:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.LightBlue;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDisplay.Location = new System.Drawing.Point(0, 245);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(725, 128);
            this.txtDisplay.TabIndex = 5;
            this.txtDisplay.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Cyan;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(632, 30);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 50);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(632, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(632, 142);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 50);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Show List";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.grpFaculty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpRole.ResumeLayout(false);
            this.grpRole.PerformLayout();
            this.grpFaculty.ResumeLayout(false);
            this.grpFaculty.PerformLayout();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpRole;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radStaff;
        private System.Windows.Forms.RadioButton radFaculty;
        private System.Windows.Forms.GroupBox grpFaculty;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRead;
    }
}


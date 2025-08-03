namespace EmpInt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pic = new PictureBox();
            idTB = new TextBox();
            nameTB = new TextBox();
            emailTB = new TextBox();
            maleRB = new RadioButton();
            femaleRB = new RadioButton();
            LeftBtn = new Button();
            rightBtn = new Button();
            updateBtn = new Button();
            newBtn = new Button();
            browseBtn = new Button();
            deleteBtn = new Button();
            DatePicker = new DateTimePicker();
            salaryTB = new TextBox();
            ofd = new OpenFileDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Location = new Point(6, 26);
            pic.Name = "pic";
            pic.Size = new Size(267, 185);
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // idTB
            // 
            idTB.Location = new Point(16, 35);
            idTB.Name = "idTB";
            idTB.PlaceholderText = "ID";
            idTB.Size = new Size(125, 27);
            idTB.TabIndex = 1;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(16, 68);
            nameTB.Name = "nameTB";
            nameTB.PlaceholderText = "NAME";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 2;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(16, 101);
            emailTB.Name = "emailTB";
            emailTB.PlaceholderText = "E-MAIL";
            emailTB.Size = new Size(125, 27);
            emailTB.TabIndex = 3;
            // 
            // maleRB
            // 
            maleRB.AutoSize = true;
            maleRB.Location = new Point(158, 38);
            maleRB.Name = "maleRB";
            maleRB.Size = new Size(63, 24);
            maleRB.TabIndex = 4;
            maleRB.TabStop = true;
            maleRB.Text = "Male";
            maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            femaleRB.AutoSize = true;
            femaleRB.Location = new Point(253, 38);
            femaleRB.Name = "femaleRB";
            femaleRB.Size = new Size(78, 24);
            femaleRB.TabIndex = 5;
            femaleRB.TabStop = true;
            femaleRB.Text = "Female";
            femaleRB.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            LeftBtn.Location = new Point(36, 259);
            LeftBtn.Name = "LeftBtn";
            LeftBtn.Size = new Size(79, 29);
            LeftBtn.TabIndex = 6;
            LeftBtn.Text = "<";
            LeftBtn.UseVisualStyleBackColor = true;
            LeftBtn.Click += LeftBtn_Click;
            // 
            // rightBtn
            // 
            rightBtn.Location = new Point(165, 259);
            rightBtn.Name = "rightBtn";
            rightBtn.Size = new Size(79, 29);
            rightBtn.TabIndex = 7;
            rightBtn.Text = ">";
            rightBtn.UseVisualStyleBackColor = true;
            rightBtn.Click += rightBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(26, 22);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(215, 29);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(262, 22);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(215, 29);
            newBtn.TabIndex = 9;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(36, 222);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(208, 29);
            browseBtn.TabIndex = 10;
            browseBtn.Text = "BROWSE";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(492, 22);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(225, 29);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(131, 75);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(219, 27);
            DatePicker.TabIndex = 12;
            // 
            // salaryTB
            // 
            salaryTB.Location = new Point(16, 134);
            salaryTB.Name = "salaryTB";
            salaryTB.PlaceholderText = "SALARY";
            salaryTB.Size = new Size(125, 27);
            salaryTB.TabIndex = 13;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(idTB);
            groupBox1.Controls.Add(salaryTB);
            groupBox1.Controls.Add(nameTB);
            groupBox1.Controls.Add(emailTB);
            groupBox1.Location = new Point(22, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 182);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(maleRB);
            groupBox2.Controls.Add(femaleRB);
            groupBox2.Controls.Add(DatePicker);
            groupBox2.Location = new Point(22, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Additional Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 80);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 14;
            label2.Text = "Date Of Birth:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 13;
            label1.Text = "Gender:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Controls.Add(updateBtn);
            groupBox3.Controls.Add(newBtn);
            groupBox3.Controls.Add(deleteBtn);
            groupBox3.Location = new Point(22, 368);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(725, 57);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Window;
            groupBox4.BackgroundImage = (Image)resources.GetObject("groupBox4.BackgroundImage");
            groupBox4.Controls.Add(pic);
            groupBox4.Controls.Add(LeftBtn);
            groupBox4.Controls.Add(rightBtn);
            groupBox4.Controls.Add(browseBtn);
            groupBox4.Location = new Point(466, 36);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(281, 313);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Profile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "EMPLOYEE INTERFACE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic;
        private TextBox idTB;
        private TextBox nameTB;
        private TextBox emailTB;
        private RadioButton maleRB;
        private RadioButton femaleRB;
        private Button LeftBtn;
        private Button rightBtn;
        private Button updateBtn;
        private Button newBtn;
        private Button browseBtn;
        private Button deleteBtn;
        private DateTimePicker DatePicker;
        private TextBox salaryTB;
        private OpenFileDialog ofd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}

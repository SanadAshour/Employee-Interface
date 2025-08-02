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
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Location = new Point(614, 22);
            pic.Name = "pic";
            pic.Size = new Size(125, 143);
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // idTB
            // 
            idTB.Location = new Point(38, 34);
            idTB.Name = "idTB";
            idTB.PlaceholderText = "ID";
            idTB.Size = new Size(125, 27);
            idTB.TabIndex = 1;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(38, 84);
            nameTB.Name = "nameTB";
            nameTB.PlaceholderText = "NAME";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 2;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(38, 138);
            emailTB.Name = "emailTB";
            emailTB.PlaceholderText = "E-MAIL";
            emailTB.Size = new Size(125, 27);
            emailTB.TabIndex = 3;
            // 
            // maleRB
            // 
            maleRB.AutoSize = true;
            maleRB.Location = new Point(22, 253);
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
            femaleRB.Location = new Point(112, 253);
            femaleRB.Name = "femaleRB";
            femaleRB.Size = new Size(78, 24);
            femaleRB.TabIndex = 5;
            femaleRB.TabStop = true;
            femaleRB.Text = "Female";
            femaleRB.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            LeftBtn.Location = new Point(630, 215);
            LeftBtn.Name = "LeftBtn";
            LeftBtn.Size = new Size(32, 29);
            LeftBtn.TabIndex = 6;
            LeftBtn.Text = "<";
            LeftBtn.UseVisualStyleBackColor = true;
            LeftBtn.Click += LeftBtn_Click;
            // 
            // rightBtn
            // 
            rightBtn.Location = new Point(692, 215);
            rightBtn.Name = "rightBtn";
            rightBtn.Size = new Size(32, 29);
            rightBtn.TabIndex = 7;
            rightBtn.Text = ">";
            rightBtn.UseVisualStyleBackColor = true;
            rightBtn.Click += rightBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(239, 371);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(377, 371);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(94, 29);
            newBtn.TabIndex = 9;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(630, 171);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 10;
            browseBtn.Text = "BROWSE";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(530, 371);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(38, 319);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(250, 27);
            DatePicker.TabIndex = 12;
            // 
            // salaryTB
            // 
            salaryTB.Location = new Point(38, 195);
            salaryTB.Name = "salaryTB";
            salaryTB.PlaceholderText = "SALARY";
            salaryTB.Size = new Size(125, 27);
            salaryTB.TabIndex = 13;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salaryTB);
            Controls.Add(DatePicker);
            Controls.Add(deleteBtn);
            Controls.Add(browseBtn);
            Controls.Add(newBtn);
            Controls.Add(updateBtn);
            Controls.Add(rightBtn);
            Controls.Add(LeftBtn);
            Controls.Add(femaleRB);
            Controls.Add(maleRB);
            Controls.Add(emailTB);
            Controls.Add(nameTB);
            Controls.Add(idTB);
            Controls.Add(pic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}

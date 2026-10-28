namespace bai4._2
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
            cboCourse = new ComboBox();
            chkAgree = new CheckBox();
            rdoMale = new RadioButton();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            txtName = new TextBox();
            lblName = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            rdoFemale = new RadioButton();
            lblCourse = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(116, 256);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(709, 28);
            cboCourse.TabIndex = 0;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(876, 258);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(101, 24);
            chkAgree.TabIndex = 1;
            chkAgree.Text = "Tôi đồng ý";
            chkAgree.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(557, 169);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(62, 24);
            rdoMale.TabIndex = 2;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(557, 59);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(268, 27);
            mtxtPhone.TabIndex = 3;
            mtxtPhone.MaskInputRejected += mtxtPhone_MaskInputRejected;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(116, 164);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(111, 27);
            dtpBirthDate.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 27);
            txtName.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Họ và Tên";
            lblName.Click += label1_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(443, 59);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 20);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(12, 169);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(74, 20);
            lblBirthDate.TabIndex = 8;
            lblBirthDate.Text = "Ngày sinh";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(443, 169);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 9;
            lblGender.Text = "Giới tính";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(637, 169);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(50, 24);
            rdoFemale.TabIndex = 10;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(12, 259);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(71, 20);
            lblCourse.TabIndex = 11;
            lblCourse.Text = "Khóa học";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(443, 333);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 450);
            Controls.Add(btnRegister);
            Controls.Add(lblCourse);
            Controls.Add(rdoFemale);
            Controls.Add(lblGender);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Controls.Add(rdoMale);
            Controls.Add(chkAgree);
            Controls.Add(cboCourse);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCourse;
        private CheckBox chkAgree;
        private RadioButton rdoMale;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private TextBox txtName;
        private Label lblName;
        private Label lblPhone;
        private Label lblBirthDate;
        private Label lblGender;
        private RadioButton rdoFemale;
        private Label lblCourse;
        private Button btnRegister;
    }
}

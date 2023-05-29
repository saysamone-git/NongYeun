namespace NongYuen
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txtpassword = new TextBox();
            panel2 = new Panel();
            txtuser = new TextBox();
            btlogin = new Button();
            btclearfields = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(493, 37);
            label1.TabIndex = 0;
            label1.Text = "ຍີນດີເຂົ້າສູ່ລະບົບບໍລິຫານຈັດການຂໍ້ມູນນັກຮຽນ";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(26, 188, 156);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(51, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(247, 153);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 2;
            label2.Text = "ຊື່ຜູ້ໃຊ້ :";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 213);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 2;
            label3.Text = "ລະຫັດຜ່ານ :";
            label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(332, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 1);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(332, 215);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(219, 23);
            txtpassword.TabIndex = 4;
            txtpassword.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(333, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 1);
            panel2.TabIndex = 3;
            panel2.UseWaitCursor = true;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.White;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtuser.Location = new Point(333, 157);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(218, 23);
            txtuser.TabIndex = 4;
            txtuser.UseWaitCursor = true;
            // 
            // btlogin
            // 
            btlogin.BackColor = Color.DarkOliveGreen;
            btlogin.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btlogin.FlatStyle = FlatStyle.Flat;
            btlogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btlogin.ForeColor = Color.White;
            btlogin.Location = new Point(427, 304);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(143, 48);
            btlogin.TabIndex = 5;
            btlogin.Text = "ເຂົ້າສູ່ລະບົບ";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.UseWaitCursor = true;
            btlogin.Click += btlogin_Click;
            // 
            // btclearfields
            // 
            btclearfields.BackColor = Color.Transparent;
            btclearfields.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btclearfields.FlatStyle = FlatStyle.Flat;
            btclearfields.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btclearfields.ForeColor = Color.DarkOliveGreen;
            btclearfields.Location = new Point(247, 304);
            btclearfields.Name = "btclearfields";
            btclearfields.Size = new Size(143, 48);
            btclearfields.TabIndex = 5;
            btclearfields.Text = "ຍົກເລີກ";
            btclearfields.UseVisualStyleBackColor = false;
            btclearfields.UseWaitCursor = true;
            btclearfields.Click += btclearfields_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(175, 61);
            label4.Name = "label4";
            label4.Size = new Size(259, 37);
            label4.TabIndex = 0;
            label4.Text = "ໂຮງຮຽນ ມຕ ໜອງຍືນ";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(617, 416);
            ControlBox = false;
            Controls.Add(btclearfields);
            Controls.Add(btlogin);
            Controls.Add(txtuser);
            Controls.Add(panel2);
            Controls.Add(txtpassword);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            UseWaitCursor = true;
            Load += LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox txtpassword;
        private Panel panel2;
        private TextBox txtuser;
        private Button btlogin;
        private Button btclearfields;
        private Label label4;
    }
}
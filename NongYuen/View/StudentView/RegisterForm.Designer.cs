namespace NongYuen.View
{
    partial class RegisterForm
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
            group_payment = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_stid = new TextBox();
            combo_sttype = new ComboBox();
            label15 = new Label();
            date_register = new DateTimePicker();
            label14 = new Label();
            txt_registerid = new TextBox();
            combyear1 = new ComboBox();
            txt_tatolcost = new TextBox();
            txt_paidmoney = new TextBox();
            txt_change = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            label11 = new Label();
            panel4 = new Panel();
            panel8 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            comboclassroom1 = new ComboBox();
            comboclass1 = new ComboBox();
            txt_stname = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            group_payment.SuspendLayout();
            SuspendLayout();
            // 
            // group_payment
            // 
            group_payment.Controls.Add(textBox2);
            group_payment.Controls.Add(textBox1);
            group_payment.Controls.Add(label2);
            group_payment.Controls.Add(label1);
            group_payment.Controls.Add(txt_stid);
            group_payment.Controls.Add(combo_sttype);
            group_payment.Controls.Add(label15);
            group_payment.Controls.Add(date_register);
            group_payment.Controls.Add(label14);
            group_payment.Controls.Add(txt_registerid);
            group_payment.Controls.Add(combyear1);
            group_payment.Controls.Add(txt_tatolcost);
            group_payment.Controls.Add(txt_paidmoney);
            group_payment.Controls.Add(txt_change);
            group_payment.Controls.Add(label13);
            group_payment.Controls.Add(label12);
            group_payment.Controls.Add(label8);
            group_payment.Controls.Add(panel7);
            group_payment.Controls.Add(label11);
            group_payment.Controls.Add(panel4);
            group_payment.Controls.Add(panel8);
            group_payment.Controls.Add(label9);
            group_payment.Controls.Add(panel1);
            group_payment.Controls.Add(panel6);
            group_payment.Controls.Add(panel5);
            group_payment.Controls.Add(comboclassroom1);
            group_payment.Controls.Add(comboclass1);
            group_payment.Controls.Add(txt_stname);
            group_payment.Controls.Add(label4);
            group_payment.Controls.Add(panel2);
            group_payment.Controls.Add(label5);
            group_payment.Controls.Add(label6);
            group_payment.Controls.Add(label7);
            group_payment.Controls.Add(panel3);
            group_payment.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            group_payment.Location = new Point(7, 53);
            group_payment.Name = "group_payment";
            group_payment.Size = new Size(668, 322);
            group_payment.TabIndex = 26;
            group_payment.TabStop = false;
            group_payment.Enter += group_payment_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(130, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 20);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(130, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 20);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(56, 199);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 24;
            label2.Text = "ຄ່າອື່ນໆ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(56, 165);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 23;
            label1.Text = "ຄ່າຮຽນ :";
            // 
            // txt_stid
            // 
            txt_stid.BackColor = Color.FromArgb(192, 192, 255);
            txt_stid.BorderStyle = BorderStyle.None;
            txt_stid.Location = new Point(132, 59);
            txt_stid.Name = "txt_stid";
            txt_stid.Size = new Size(150, 20);
            txt_stid.TabIndex = 11;
            // 
            // combo_sttype
            // 
            combo_sttype.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_sttype.FormattingEnabled = true;
            combo_sttype.Items.AddRange(new object[] { "ພາຍໃນເມືອງ", "ຕ່າງເມືອງ", "ຕ່າງແຂວງ" });
            combo_sttype.Location = new Point(125, 17);
            combo_sttype.Name = "combo_sttype";
            combo_sttype.Size = new Size(158, 28);
            combo_sttype.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 0, 192);
            label15.Location = new Point(21, 20);
            label15.Name = "label15";
            label15.Size = new Size(93, 20);
            label15.TabIndex = 21;
            label15.Text = "ປະເພດນັກຮຽນ : ";
            // 
            // date_register
            // 
            date_register.Location = new Point(460, 51);
            date_register.Name = "date_register";
            date_register.Size = new Size(150, 27);
            date_register.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 0, 192);
            label14.Location = new Point(395, 92);
            label14.Name = "label14";
            label14.Size = new Size(57, 20);
            label14.TabIndex = 5;
            label14.Text = "ສົກຮຽນ :";
            // 
            // txt_registerid
            // 
            txt_registerid.BackColor = Color.FromArgb(192, 192, 255);
            txt_registerid.BorderStyle = BorderStyle.None;
            txt_registerid.Location = new Point(460, 14);
            txt_registerid.Name = "txt_registerid";
            txt_registerid.Size = new Size(150, 20);
            txt_registerid.TabIndex = 17;
            // 
            // combyear1
            // 
            combyear1.DropDownStyle = ComboBoxStyle.DropDownList;
            combyear1.FormattingEnabled = true;
            combyear1.Items.AddRange(new object[] { "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030" });
            combyear1.Location = new Point(461, 86);
            combyear1.Name = "combyear1";
            combyear1.Size = new Size(117, 28);
            combyear1.TabIndex = 4;
            // 
            // txt_tatolcost
            // 
            txt_tatolcost.BackColor = Color.FromArgb(192, 192, 255);
            txt_tatolcost.BorderStyle = BorderStyle.None;
            txt_tatolcost.Location = new Point(129, 236);
            txt_tatolcost.Name = "txt_tatolcost";
            txt_tatolcost.Size = new Size(150, 20);
            txt_tatolcost.TabIndex = 17;
            // 
            // txt_paidmoney
            // 
            txt_paidmoney.BackColor = Color.FromArgb(192, 192, 255);
            txt_paidmoney.BorderStyle = BorderStyle.None;
            txt_paidmoney.Location = new Point(124, 269);
            txt_paidmoney.Multiline = true;
            txt_paidmoney.Name = "txt_paidmoney";
            txt_paidmoney.Size = new Size(150, 15);
            txt_paidmoney.TabIndex = 18;
            // 
            // txt_change
            // 
            txt_change.BackColor = Color.FromArgb(192, 192, 255);
            txt_change.BorderStyle = BorderStyle.None;
            txt_change.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_change.Location = new Point(443, 169);
            txt_change.Multiline = true;
            txt_change.Name = "txt_change";
            txt_change.Size = new Size(150, 23);
            txt_change.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 0, 192);
            label13.Location = new Point(381, 55);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 13;
            label13.Text = "ວັນທີຊຳລະ :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 0, 192);
            label12.Location = new Point(355, 19);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 13;
            label12.Text = "ເລກທີລົງທະບຽນ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(-5, 238);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 13;
            label8.Text = "ຄ່າລົງທະບຽນທັງໝົດ :";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(126, 287);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 1);
            panel7.TabIndex = 15;
            panel7.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 192);
            label11.Location = new Point(45, 268);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 14;
            label11.Text = "ເງິນທີ່ຈ່າຍ :";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.Location = new Point(443, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 1);
            panel4.TabIndex = 15;
            panel4.UseWaitCursor = true;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(460, 34);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 1);
            panel8.TabIndex = 16;
            panel8.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 192);
            label9.Location = new Point(336, 171);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 14;
            label9.Text = "ເງິນທອນ :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(130, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 1);
            panel1.TabIndex = 16;
            panel1.UseWaitCursor = true;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(130, 219);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 1);
            panel6.TabIndex = 16;
            panel6.UseWaitCursor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(129, 257);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 1);
            panel5.TabIndex = 16;
            panel5.UseWaitCursor = true;
            // 
            // comboclassroom1
            // 
            comboclassroom1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboclassroom1.FormattingEnabled = true;
            comboclassroom1.Items.AddRange(new object[] { "ມ1/1", "ມ1/2", "ມ2/1", "ມ2/2", "ມ3/1", "ມ3/2", "ມ4/1", "ມ4/2" });
            comboclassroom1.Location = new Point(271, 125);
            comboclassroom1.Name = "comboclassroom1";
            comboclassroom1.Size = new Size(65, 28);
            comboclassroom1.TabIndex = 12;
            // 
            // comboclass1
            // 
            comboclass1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboclass1.FormattingEnabled = true;
            comboclass1.Items.AddRange(new object[] { "ມ1", "ມ2", "ມ3", "ມ4" });
            comboclass1.Location = new Point(130, 127);
            comboclass1.Name = "comboclass1";
            comboclass1.Size = new Size(63, 28);
            comboclass1.TabIndex = 12;
            // 
            // txt_stname
            // 
            txt_stname.BackColor = Color.FromArgb(192, 192, 255);
            txt_stname.BorderStyle = BorderStyle.None;
            txt_stname.Location = new Point(133, 91);
            txt_stname.Name = "txt_stname";
            txt_stname.Size = new Size(150, 20);
            txt_stname.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(27, 61);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "ລະຫັດນັກຮຽນ :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(133, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 1);
            panel2.TabIndex = 10;
            panel2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(8, 94);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 8;
            label5.Text = "ຊື່ ແລະ ນາມສະກຸນ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(56, 127);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "ຊັ້ນຮຽນ : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(202, 131);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 8;
            label7.Text = "ຫ້ອງຮຽນ :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(133, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 1);
            panel3.TabIndex = 10;
            panel3.UseWaitCursor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.DarkOliveGreen;
            iconButton1.FlatAppearance.BorderColor = Color.SeaGreen;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(351, 381);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(314, 38);
            iconButton1.TabIndex = 29;
            iconButton1.Text = "Save";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(7, 381);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(314, 38);
            iconButton2.TabIndex = 30;
            iconButton2.Text = "Cancel";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Phetsarath OT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(269, 1);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 31;
            label3.Text = "ລົງທະບຽນ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(679, 470);
            Controls.Add(label3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(group_payment);
            Name = "RegisterForm";
            Text = "RegisterForm";
            group_payment.ResumeLayout(false);
            group_payment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox group_payment;
        private TextBox txt_stid;
        private ComboBox combo_sttype;
        private Label label15;
        private DateTimePicker date_register;
        private Label label14;
        private TextBox txt_registerid;
        private ComboBox combyear1;
        private TextBox txt_tatolcost;
        private TextBox txt_paidmoney;
        private TextBox txt_change;
        private Label label13;
        private Label label12;
        private Label label8;
        private Panel panel7;
        private Label label11;
        private Panel panel4;
        private Panel panel8;
        private Label label9;
        private Panel panel5;
        private ComboBox comboclassroom1;
        private ComboBox comboclass1;
        private TextBox txt_stname;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel6;
        private Label label3;
    }
}
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
            txt_stid = new TextBox();
            combo_sttype = new ComboBox();
            label15 = new Label();
            date_register = new DateTimePicker();
            label14 = new Label();
            txt_registerid = new TextBox();
            combyear1 = new ComboBox();
            txt_tatolcost = new TextBox();
            txt_pay = new TextBox();
            txt_paidmoney = new TextBox();
            txt_payment = new TextBox();
            txt_change = new TextBox();
            panel6 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            panel9 = new Panel();
            label11 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            panel8 = new Panel();
            label9 = new Label();
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
            group_payment.SuspendLayout();
            SuspendLayout();
            // 
            // group_payment
            // 
            group_payment.Controls.Add(txt_stid);
            group_payment.Controls.Add(combo_sttype);
            group_payment.Controls.Add(label15);
            group_payment.Controls.Add(date_register);
            group_payment.Controls.Add(label14);
            group_payment.Controls.Add(txt_registerid);
            group_payment.Controls.Add(combyear1);
            group_payment.Controls.Add(txt_tatolcost);
            group_payment.Controls.Add(txt_pay);
            group_payment.Controls.Add(txt_paidmoney);
            group_payment.Controls.Add(txt_payment);
            group_payment.Controls.Add(txt_change);
            group_payment.Controls.Add(panel6);
            group_payment.Controls.Add(label13);
            group_payment.Controls.Add(label12);
            group_payment.Controls.Add(label8);
            group_payment.Controls.Add(panel7);
            group_payment.Controls.Add(label10);
            group_payment.Controls.Add(panel9);
            group_payment.Controls.Add(label11);
            group_payment.Controls.Add(panel4);
            group_payment.Controls.Add(label17);
            group_payment.Controls.Add(panel8);
            group_payment.Controls.Add(label9);
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
            group_payment.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            group_payment.Location = new Point(7, 33);
            group_payment.Name = "group_payment";
            group_payment.Size = new Size(668, 276);
            group_payment.TabIndex = 26;
            group_payment.TabStop = false;
            group_payment.Text = "ຊຳລະຄ່າຮຽນ";
            // 
            // txt_stid
            // 
            txt_stid.BackColor = SystemColors.Control;
            txt_stid.BorderStyle = BorderStyle.None;
            txt_stid.Location = new Point(119, 62);
            txt_stid.Name = "txt_stid";
            txt_stid.Size = new Size(150, 14);
            txt_stid.TabIndex = 11;
            // 
            // combo_sttype
            // 
            combo_sttype.FormattingEnabled = true;
            combo_sttype.Items.AddRange(new object[] { "ພາຍໃນເມືອງ", "ຕ່າງເມືອງ", "ຕ່າງແຂວງ" });
            combo_sttype.Location = new Point(114, 17);
            combo_sttype.Name = "combo_sttype";
            combo_sttype.Size = new Size(158, 23);
            combo_sttype.TabIndex = 22;
            combo_sttype.Text = "ເລືອກປະເພດ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 20);
            label15.Name = "label15";
            label15.Size = new Size(87, 15);
            label15.TabIndex = 21;
            label15.Text = "ປະເພດນັກຮຽນ : ";
            // 
            // date_register
            // 
            date_register.Location = new Point(449, 51);
            date_register.Name = "date_register";
            date_register.Size = new Size(150, 21);
            date_register.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(384, 92);
            label14.Name = "label14";
            label14.Size = new Size(41, 16);
            label14.TabIndex = 5;
            label14.Text = "ສົກຮຽນ :";
            // 
            // txt_registerid
            // 
            txt_registerid.BackColor = SystemColors.Control;
            txt_registerid.BorderStyle = BorderStyle.None;
            txt_registerid.Location = new Point(449, 17);
            txt_registerid.Name = "txt_registerid";
            txt_registerid.Size = new Size(150, 14);
            txt_registerid.TabIndex = 17;
            // 
            // combyear1
            // 
            combyear1.FormattingEnabled = true;
            combyear1.Location = new Point(450, 86);
            combyear1.Name = "combyear1";
            combyear1.Size = new Size(117, 23);
            combyear1.TabIndex = 4;
            // 
            // txt_tatolcost
            // 
            txt_tatolcost.BackColor = SystemColors.Control;
            txt_tatolcost.BorderStyle = BorderStyle.None;
            txt_tatolcost.Location = new Point(119, 161);
            txt_tatolcost.Name = "txt_tatolcost";
            txt_tatolcost.Size = new Size(150, 14);
            txt_tatolcost.TabIndex = 17;
            // 
            // txt_pay
            // 
            txt_pay.BackColor = SystemColors.Control;
            txt_pay.BorderStyle = BorderStyle.None;
            txt_pay.Location = new Point(117, 226);
            txt_pay.Multiline = true;
            txt_pay.Name = "txt_pay";
            txt_pay.Size = new Size(150, 15);
            txt_pay.TabIndex = 18;
            // 
            // txt_paidmoney
            // 
            txt_paidmoney.BackColor = SystemColors.Control;
            txt_paidmoney.BorderStyle = BorderStyle.None;
            txt_paidmoney.Location = new Point(114, 196);
            txt_paidmoney.Multiline = true;
            txt_paidmoney.Name = "txt_paidmoney";
            txt_paidmoney.Size = new Size(150, 15);
            txt_paidmoney.TabIndex = 18;
            // 
            // txt_payment
            // 
            txt_payment.BackColor = SystemColors.Control;
            txt_payment.BorderStyle = BorderStyle.None;
            txt_payment.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_payment.Location = new Point(435, 164);
            txt_payment.Multiline = true;
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(150, 20);
            txt_payment.TabIndex = 18;
            // 
            // txt_change
            // 
            txt_change.BackColor = SystemColors.Control;
            txt_change.BorderStyle = BorderStyle.None;
            txt_change.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_change.Location = new Point(435, 205);
            txt_change.Multiline = true;
            txt_change.Name = "txt_change";
            txt_change.Size = new Size(150, 23);
            txt_change.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(117, 246);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 1);
            panel6.TabIndex = 15;
            panel6.UseWaitCursor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(370, 55);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 13;
            label13.Text = "ວັນທີຊຳລະ :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(344, 19);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 13;
            label12.Text = "ເລກທີລົງທະບຽນ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 162);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 13;
            label8.Text = "ຄ່າລົງທະບຽນທັງໝົດ :";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(116, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 1);
            panel7.TabIndex = 15;
            panel7.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 226);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 14;
            label10.Text = "ຄ້າງຈ່າຍ :";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaptionText;
            panel9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel9.Location = new Point(435, 186);
            panel9.Name = "panel9";
            panel9.Size = new Size(150, 1);
            panel9.TabIndex = 15;
            panel9.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 196);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 14;
            label11.Text = "ເງິນທີ່ຈ່າຍ :";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.Location = new Point(435, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 1);
            panel4.TabIndex = 15;
            panel4.UseWaitCursor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(278, 164);
            label17.Name = "label17";
            label17.Size = new Size(107, 18);
            label17.TabIndex = 14;
            label17.Text = "ເງິນທີ່ຕ້ອງຊຳລະ :";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaptionText;
            panel8.Location = new Point(449, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 1);
            panel8.TabIndex = 16;
            panel8.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(328, 207);
            label9.Name = "label9";
            label9.Size = new Size(69, 18);
            label9.TabIndex = 14;
            label9.Text = "ເງິນທອນ :";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(119, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 1);
            panel5.TabIndex = 16;
            panel5.UseWaitCursor = true;
            // 
            // comboclassroom1
            // 
            comboclassroom1.FormattingEnabled = true;
            comboclassroom1.Location = new Point(260, 125);
            comboclassroom1.Name = "comboclassroom1";
            comboclassroom1.Size = new Size(65, 23);
            comboclassroom1.TabIndex = 12;
            // 
            // comboclass1
            // 
            comboclass1.FormattingEnabled = true;
            comboclass1.Location = new Point(119, 127);
            comboclass1.Name = "comboclass1";
            comboclass1.Size = new Size(63, 23);
            comboclass1.TabIndex = 12;
            // 
            // txt_stname
            // 
            txt_stname.BackColor = SystemColors.Control;
            txt_stname.BorderStyle = BorderStyle.None;
            txt_stname.Location = new Point(122, 96);
            txt_stname.Name = "txt_stname";
            txt_stname.Size = new Size(150, 14);
            txt_stname.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 61);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 8;
            label4.Text = "ລະຫັດນັກຮຽນ :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(122, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 1);
            panel2.TabIndex = 10;
            panel2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 95);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 8;
            label5.Text = "ຊື່ ແລະ ນາມສະກຸນ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 130);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 8;
            label6.Text = "ຊັ້ນຮຽນ : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 131);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 8;
            label7.Text = "ຫ້ອງຮຽນ :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(122, 85);
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
            iconButton1.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(356, 326);
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
            iconButton2.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(12, 326);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(314, 38);
            iconButton2.TabIndex = 30;
            iconButton2.Text = "Cancel";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 381);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(group_payment);
            Name = "RegisterForm";
            Text = "RegisterForm";
            group_payment.ResumeLayout(false);
            group_payment.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txt_pay;
        private TextBox txt_paidmoney;
        private TextBox txt_payment;
        private TextBox txt_change;
        private Panel panel6;
        private Label label13;
        private Label label12;
        private Label label8;
        private Panel panel7;
        private Label label10;
        private Panel panel9;
        private Label label11;
        private Panel panel4;
        private Label label17;
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
    }
}
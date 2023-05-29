namespace NongYuen.View.CassroomView
{
    partial class Classroom
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Phetsarath OT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "ຫ້ອງຮຽນ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "ລະຫັດຫ້ອງ :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(80, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 16);
            textBox1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(80, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(65, 1);
            panel3.TabIndex = 14;
            panel3.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(17, 95);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "ຊັ້ນຮຽນ : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 16;
            label4.Text = "ຫ້ອງຮຽນ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Phetsarath OT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(19, 177);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 17;
            label5.Text = "ສົກຮຽນ : ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(192, 192, 255);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ມ1", "ມ2", "ມ3", "ມ4" });
            comboBox1.Location = new Point(78, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 25);
            comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(192, 192, 255);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ມ1/1", "ມ1/2", "ມ2/1", "ມ2/2", "ມ3/1", "ມ3/2", "ມ4/1", "ມ4/2" });
            comboBox2.Location = new Point(77, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(62, 25);
            comboBox2.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(192, 192, 255);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030" });
            comboBox3.Location = new Point(77, 177);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(88, 25);
            comboBox3.TabIndex = 20;
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
            iconButton1.Location = new Point(226, 95);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(127, 38);
            iconButton1.TabIndex = 34;
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
            iconButton2.Location = new Point(226, 162);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(127, 38);
            iconButton2.TabIndex = 33;
            iconButton2.Text = "Cancel";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // Classroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(502, 268);
            Controls.Add(iconButton1);
            Controls.Add(iconButton2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Classroom";
            Text = "classroom";
            Load += Classroom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
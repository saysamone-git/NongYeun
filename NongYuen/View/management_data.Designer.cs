namespace NongYuen.View
{
    partial class management_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(management_data));
            panel1 = new Panel();
            btYear = new Button();
            btuser = new Button();
            btAddress = new Button();
            btPay = new Button();
            btTeachercourse = new Button();
            btSubject = new Button();
            btTeacherRoom = new Button();
            btClassRoom = new Button();
            btParent = new Button();
            btTeacher = new Button();
            btStudent = new Button();
            panel2 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panelContainer = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btYear);
            panel1.Controls.Add(btuser);
            panel1.Controls.Add(btAddress);
            panel1.Controls.Add(btPay);
            panel1.Controls.Add(btTeachercourse);
            panel1.Controls.Add(btSubject);
            panel1.Controls.Add(btTeacherRoom);
            panel1.Controls.Add(btClassRoom);
            panel1.Controls.Add(btParent);
            panel1.Controls.Add(btTeacher);
            panel1.Controls.Add(btStudent);
            panel1.Location = new Point(2, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 583);
            panel1.TabIndex = 0;
            // 
            // btYear
            // 
            btYear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btYear.Location = new Point(49, 441);
            btYear.Name = "btYear";
            btYear.Size = new Size(76, 31);
            btYear.TabIndex = 10;
            btYear.Text = "ສົກຮຽນ";
            btYear.UseVisualStyleBackColor = true;
            // 
            // btuser
            // 
            btuser.FlatStyle = FlatStyle.System;
            btuser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btuser.Location = new Point(14, 18);
            btuser.Name = "btuser";
            btuser.Size = new Size(135, 38);
            btuser.TabIndex = 0;
            btuser.Text = "ຜູ້ໃຊ້ລະບົບ";
            btuser.UseVisualStyleBackColor = true;
            btuser.Click += button10_Click;
            // 
            // btAddress
            // 
            btAddress.FlatStyle = FlatStyle.System;
            btAddress.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAddress.Location = new Point(59, 534);
            btAddress.Name = "btAddress";
            btAddress.Size = new Size(63, 34);
            btAddress.TabIndex = 9;
            btAddress.Text = "ທີ່ຢູ່";
            btAddress.UseVisualStyleBackColor = true;
            // 
            // btPay
            // 
            btPay.FlatStyle = FlatStyle.System;
            btPay.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPay.Location = new Point(52, 490);
            btPay.Name = "btPay";
            btPay.Size = new Size(75, 31);
            btPay.TabIndex = 8;
            btPay.Text = "ຄ່າຮຽນ";
            btPay.UseVisualStyleBackColor = true;
            // 
            // btTeachercourse
            // 
            btTeachercourse.FlatStyle = FlatStyle.System;
            btTeachercourse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btTeachercourse.Location = new Point(20, 77);
            btTeachercourse.Name = "btTeachercourse";
            btTeachercourse.Size = new Size(129, 42);
            btTeachercourse.TabIndex = 1;
            btTeachercourse.Text = "ຄູປະຈຳວິຊາ";
            btTeachercourse.UseVisualStyleBackColor = true;
            btTeachercourse.Click += button7_Click;
            // 
            // btSubject
            // 
            btSubject.FlatStyle = FlatStyle.System;
            btSubject.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSubject.Location = new Point(46, 390);
            btSubject.Name = "btSubject";
            btSubject.Size = new Size(83, 31);
            btSubject.TabIndex = 7;
            btSubject.Text = "ວິຊາຮຽນ";
            btSubject.UseVisualStyleBackColor = true;
            // 
            // btTeacherRoom
            // 
            btTeacherRoom.FlatStyle = FlatStyle.System;
            btTeacherRoom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btTeacherRoom.Location = new Point(24, 137);
            btTeacherRoom.Name = "btTeacherRoom";
            btTeacherRoom.Size = new Size(123, 35);
            btTeacherRoom.TabIndex = 2;
            btTeacherRoom.Text = "ຄູປະຈຳຫ້ອງ";
            btTeacherRoom.UseVisualStyleBackColor = true;
            btTeacherRoom.Click += button5_Click;
            // 
            // btClassRoom
            // 
            btClassRoom.FlatStyle = FlatStyle.System;
            btClassRoom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btClassRoom.Location = new Point(34, 240);
            btClassRoom.Name = "btClassRoom";
            btClassRoom.Size = new Size(106, 35);
            btClassRoom.TabIndex = 4;
            btClassRoom.Text = "ຫ້ອງຮຽນ";
            btClassRoom.UseVisualStyleBackColor = true;
            // 
            // btParent
            // 
            btParent.FlatStyle = FlatStyle.System;
            btParent.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btParent.Location = new Point(29, 188);
            btParent.Name = "btParent";
            btParent.Size = new Size(117, 35);
            btParent.TabIndex = 3;
            btParent.Text = "ຜູ້ປົກຄອງ";
            btParent.UseVisualStyleBackColor = true;
            btParent.Click += button3_Click;
            // 
            // btTeacher
            // 
            btTeacher.FlatStyle = FlatStyle.System;
            btTeacher.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btTeacher.Location = new Point(38, 290);
            btTeacher.Name = "btTeacher";
            btTeacher.Size = new Size(94, 36);
            btTeacher.TabIndex = 5;
            btTeacher.Text = "ອາຈານ";
            btTeacher.UseVisualStyleBackColor = true;
            // 
            // btStudent
            // 
            btStudent.FlatStyle = FlatStyle.System;
            btStudent.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btStudent.Location = new Point(41, 341);
            btStudent.Name = "btStudent";
            btStudent.Size = new Size(88, 34);
            btStudent.TabIndex = 6;
            btStudent.Text = "ນັກຮຽນ";
            btStudent.UseVisualStyleBackColor = true;
            btStudent.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 42);
            panel2.TabIndex = 1;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.System;
            button14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(1156, 5);
            button14.Name = "button14";
            button14.Size = new Size(122, 33);
            button14.TabIndex = 7;
            button14.Text = "ອອກຈາກລະບົບ";
            button14.TextAlign = ContentAlignment.TopCenter;
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.System;
            button13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(1018, 6);
            button13.Name = "button13";
            button13.Size = new Size(122, 32);
            button13.TabIndex = 6;
            button13.Text = "ລາຍງານ";
            button13.TextAlign = ContentAlignment.TopCenter;
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.System;
            button12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(868, 3);
            button12.Name = "button12";
            button12.Size = new Size(126, 32);
            button12.TabIndex = 5;
            button12.Text = "ປະເມີນຜົນ";
            button12.TextAlign = ContentAlignment.TopCenter;
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.System;
            button11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(732, 6);
            button11.Name = "button11";
            button11.Size = new Size(111, 32);
            button11.TabIndex = 4;
            button11.Text = "ລົງທະບຽນ";
            button11.TextAlign = ContentAlignment.TopCenter;
            button11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 14);
            label1.Name = "label1";
            label1.Size = new Size(111, 13);
            label1.TabIndex = 2;
            label1.Text = "ໂຮງຮຽນ ມຕ ໜອຍືນ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(647, 45);
            label2.Name = "label2";
            label2.Size = new Size(149, 24);
            label2.TabIndex = 2;
            label2.Text = "ຈັດການຂໍ້ມູນພື້ນຖານ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(172, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1123, 281);
            dataGridView1.TabIndex = 3;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(172, 386);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1123, 296);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(405, 66);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "ສົກຮຽນ :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026" });
            comboBox1.Location = new Point(474, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(956, 67);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "ຄົ້ນຫາ :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1027, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 26);
            textBox1.TabIndex = 8;
            // 
            // management_data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 694);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panelContainer);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "management_data";
            Text = "management_data";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btuser;
        private Button btAddress;
        private Button btPay;
        private Button btTeachercourse;
        private Button btSubject;
        private Button btTeacherRoom;
        private Button btClassRoom;
        private Button btParent;
        private Button btTeacher;
        private Button btStudent;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Panel panelContainer;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Button btYear;
    }
}
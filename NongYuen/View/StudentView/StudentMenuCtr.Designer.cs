namespace NongYuen.View
{
    partial class StudentMenuCtr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelContainer = new Panel();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 738);
            panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelContainer.Location = new Point(0, 51);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1399, 687);
            panelContainer.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1399, 51);
            panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Left;
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(214, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(107, 51);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Payment";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(107, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(107, 51);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Registrant";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 51);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Student";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // StudentMenuCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "StudentMenuCtr";
            Size = new Size(1399, 738);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

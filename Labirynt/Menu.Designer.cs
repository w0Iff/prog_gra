namespace Labirynt
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 20F);
            button1.ForeColor = Color.Gold;
            button1.Image = Properties.Resources._184bt;
            button1.Location = new Point(278, 24);
            button1.Name = "button1";
            button1.Size = new Size(186, 82);
            button1.TabIndex = 0;
            button1.Text = "Start Gry";
            button1.UseVisualStyleBackColor = false;
            button1.Click += GameStart;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Image = Properties.Resources._184bt;
            button2.Location = new Point(278, 124);
            button2.Name = "button2";
            button2.Size = new Size(186, 82);
            button2.TabIndex = 1;
            button2.Text = "Gra Wielosobowa\r\n(wkróce dostępne)";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button3.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Palatino Linotype", 20F);
            button3.ForeColor = Color.Gold;
            button3.Image = Properties.Resources._184bt;
            button3.Location = new Point(278, 224);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(186, 82);
            button3.TabIndex = 2;
            button3.Text = "Ustawienia";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Settings;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Palatino Linotype", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.Gold;
            button4.Image = Properties.Resources._184bt;
            button4.Location = new Point(278, 325);
            button4.Name = "button4";
            button4.Size = new Size(186, 82);
            button4.TabIndex = 3;
            button4.Text = "Wyjście";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Exit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 414);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "v. 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(114, 42);
            label2.TabIndex = 5;
            label2.Text = "Labirynt";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.tlofinal;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Szalony Labirynt";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}

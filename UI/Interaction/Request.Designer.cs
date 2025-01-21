namespace UI.AddTour
{
    partial class Request
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
            panel1 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            comboBox4 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 99);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 7;
            label2.Text = "Chouse the hotel";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 28);
            comboBox1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 99);
            panel2.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(17, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 28);
            comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(429, 28);
            label1.TabIndex = 7;
            label1.Text = "Chouse the country where tour will be";
            label1.Click += this.label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(619, 99);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(17, 13);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 7;
            label3.Text = "Count of people";
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox4);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(619, 99);
            panel4.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(17, 54);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(224, 28);
            comboBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(17, 13);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 7;
            label4.Text = "Chouse the city";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(54, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(619, 486);
            panel5.TabIndex = 12;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(724, 570);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Request";
            Text = "TourAdd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private TextBox textBox1;
        private Panel panel4;
        private ComboBox comboBox4;
        private Label label4;
        private Panel panel5;
    }
}
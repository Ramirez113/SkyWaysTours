namespace UI.Account
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tittleLabel = new Label();
            registrationPanel = new Panel();
            loginLabel = new Label();
            textBox2 = new TextBox();
            passLabel = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            plane1Img = new PictureBox();
            plane2Img = new PictureBox();
            registrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plane1Img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plane2Img).BeginInit();
            SuspendLayout();
            // 
            // tittleLabel
            // 
            tittleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tittleLabel.AutoSize = true;
            tittleLabel.BackColor = Color.Transparent;
            tittleLabel.Font = new Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tittleLabel.ForeColor = SystemColors.ControlLightLight;
            tittleLabel.Location = new Point(250, 104);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(445, 113);
            tittleLabel.TabIndex = 7;
            tittleLabel.Text = "Welcome";
            // 
            // registrationPanel
            // 
            registrationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registrationPanel.Controls.Add(loginLabel);
            registrationPanel.Controls.Add(textBox2);
            registrationPanel.Controls.Add(passLabel);
            registrationPanel.Controls.Add(button1);
            registrationPanel.Controls.Add(textBox1);
            registrationPanel.Location = new Point(353, 203);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(223, 170);
            registrationPanel.TabIndex = 8;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            loginLabel.ForeColor = SystemColors.ControlLightLight;
            loginLabel.Location = new Point(22, 14);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(55, 22);
            loginLabel.TabIndex = 11;
            loginLabel.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 10;
            // 
            // passLabel
            // 
            passLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            passLabel.ForeColor = SystemColors.ControlLightLight;
            passLabel.Location = new Point(22, 69);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(90, 22);
            passLabel.TabIndex = 9;
            passLabel.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 51, 73);
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(22, 127);
            button1.Name = "button1";
            button1.Size = new Size(179, 32);
            button1.TabIndex = 1;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 0;
            // 
            // plane1Img
            // 
            plane1Img.BackColor = Color.Transparent;
            plane1Img.Image = (Image)resources.GetObject("plane1Img.Image");
            plane1Img.Location = new Point(250, 425);
            plane1Img.Name = "plane1Img";
            plane1Img.Size = new Size(210, 228);
            plane1Img.SizeMode = PictureBoxSizeMode.Zoom;
            plane1Img.TabIndex = 9;
            plane1Img.TabStop = false;
            // 
            // plane2Img
            // 
            plane2Img.BackColor = Color.Transparent;
            plane2Img.Image = (Image)resources.GetObject("plane2Img.Image");
            plane2Img.Location = new Point(734, 41);
            plane2Img.Name = "plane2Img";
            plane2Img.Size = new Size(210, 228);
            plane2Img.SizeMode = PictureBoxSizeMode.Zoom;
            plane2Img.TabIndex = 10;
            plane2Img.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(945, 570);
            Controls.Add(plane2Img);
            Controls.Add(plane1Img);
            Controls.Add(registrationPanel);
            Controls.Add(tittleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plane1Img).EndInit();
            ((System.ComponentModel.ISupportInitialize)plane2Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tittleLabel;
        private Panel registrationPanel;
        private Label loginLabel;
        private TextBox textBox2;
        private Label passLabel;
        private Button button1;
        private TextBox textBox1;
        private PictureBox plane1Img;
        private PictureBox plane2Img;
    }
}
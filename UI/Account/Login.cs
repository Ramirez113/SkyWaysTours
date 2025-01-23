﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace UI.Account
{
    public partial class Login : Form
    {
        private Timer timer;
        private Timer textTimer;
        private Timer panelTimer;
        private int startX, startY, endX, endY;
        private int stepX, stepY;
        private int textAlpha = 0;
        private int totalTime = 2000;
        private int interval = 10;

        public Login()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            tittleLabel.ForeColor = Color.FromArgb(0, 255, 255, 255);

            textTimer = new Timer { Interval = 50 };
            textTimer.Tick += TextTimer_Tick;
            textTimer.Start();

            panelTimer = new Timer { Interval = 50 };
            panelTimer.Tick += PanelTime_Tick;
        }

        private void InitializePlaneAnimation()
        {
            startX = plane1Img.Location.X;
            startY = plane1Img.Location.Y;

            endX = startX - 500;
            endY = startY - 300;

            stepX = (endX - startX) / (totalTime / interval);
            stepY = (endY - startY) / (totalTime / interval);

            timer = new Timer { Interval = interval };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            plane1Img.Location = new Point(
                plane1Img.Location.X + stepX,
                plane1Img.Location.Y + stepY
            );

            if ((stepX < 0 && plane1Img.Location.X <= endX) ||
                (stepX > 0 && plane1Img.Location.X >= endX) ||
                (stepY < 0 && plane1Img.Location.Y <= endY) ||
                (stepY > 0 && plane1Img.Location.Y >= endY))
            {
                timer.Stop();
            }
        }

        private void TextTimer_Tick(object sender, EventArgs e)
        {
            if (textAlpha < 255)
            {
                textAlpha += 5;
                tittleLabel.ForeColor = Color.FromArgb(textAlpha, 255, 255, 255);
            }
            else
            {
                textTimer.Stop();
                registrationPanel.Visible = true;
                panelTimer.Start();
            }
        }

        private void PanelTime_Tick(object sender, EventArgs e)
        {
            if (registrationPanel.Height < 200)
            {
                registrationPanel.Height += 10;
            }
            else
            {
                panelTimer.Stop();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InitializePlaneAnimation();
        }
    }
}